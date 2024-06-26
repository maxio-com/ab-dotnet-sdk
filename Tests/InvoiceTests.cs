﻿using System.Globalization;
using AdvancedBilling.Standard;
using AdvancedBilling.Standard.Exceptions;
using AutoFixture;
using AdvancedBilling.Standard.Models;
using AdvancedBilling.Standard.Models.Containers;
using AdvancedBillingTests.Utils;
using FluentAssertions;

namespace AdvancedBillingTests
{
    public class InvoiceTests
    {
        private readonly AdvancedBillingClient _client = Client.GetClient();
        private readonly Fixture _fixture = new();

        [Fact]

        public async Task
            Invoices_BasicInvoicesVoidInvoices_AllResponsesAreSuccessfulAndCanBeDeserialized()
        {
            var productFamilyId = await CreationUtils.CreateOrGetProductFamily(_client);

            var productResponse = await CreationUtils.CreateProduct(productFamilyId, _client);

            var customerResponse = await CreationUtils.CreateCustomer(_client);

            var paymentProfileId = await CreationUtils.CreatePaymentProfile(customerResponse.Customer.Id, _client);

            var subscription = new CreateSubscription
            {
                CustomerId = customerResponse.Customer.Id,
                ProductId = productResponse.Product.Id,
                PaymentCollectionMethod = CollectionMethod.Automatic,
                PaymentProfileId = paymentProfileId,
                DunningCommunicationDelayEnabled = false,
                SkipBillingManifestTaxes = false
            };

            var subscriptionResponse =
                await _client.SubscriptionsController.CreateSubscriptionAsync(
                    new CreateSubscriptionRequest(subscription));
            subscriptionResponse.Subscription.Id.Should().NotBeNull();

            var lineItemTitle = $"{TestUtils.GenerateRandomString(5)}lineitem";
            var description = $"{TestUtils.GenerateRandomString(10)} description";

            var invoiceQuantity = "10";
            var invoiceUnitPrice = "150";
            var billingAddress = new CreateInvoiceAddress(TestUtils.GenerateRandomString(8),
                TestUtils.GenerateRandomString(10), "282-329-2085", TestUtils.GenerateRandomString(12),
                TestUtils.GenerateRandomString(6), "ABC", "Washington", "15217", "US");

            var createInvoiceCoupons = new List<CreateInvoiceCoupon>
            {
                new CreateInvoiceCoupon(code: TestUtils.GenerateRandomString(4),
                    percentage: CreateInvoiceCouponPercentage.FromString("50"))
            };

            var invoiceLineItems = new List<CreateInvoiceItem>
            {
                new(title: lineItemTitle, quantity: CreateInvoiceItemQuantity.FromString(invoiceQuantity),
                    unitPrice: CreateInvoiceItemUnitPrice.FromString(invoiceUnitPrice), description: description)
            };

            var invoice = new CreateInvoice(invoiceLineItems, DateTime.Today, billingAddress: billingAddress,
                coupons: createInvoiceCoupons);

            var invoiceResponse = await _client.InvoicesController.CreateInvoiceAsync(
                (int)subscriptionResponse.Subscription.Id,
                new CreateInvoiceRequest(invoice));

            invoiceResponse.Invoice.Uid.Should().NotBeNullOrEmpty();

            var reason = "Duplicate invoice";

            var voidInvoice = new VoidInvoice(reason);

            var voidInvoiceResponse = await _client.InvoicesController.VoidInvoiceAsync(invoiceResponse.Invoice.Uid,
                new VoidInvoiceRequest(voidInvoice));

            voidInvoiceResponse.Uid.Should().NotBeNull();
            
            // sometimes some events are missing
            Thread.Sleep(1500);

            var invoiceEventsResponse = await _client.InvoicesController.ListInvoiceEventsAsync(
                new ListInvoiceEventsInput(
                    sinceDate: DateTime.Now.AddDays(-1).ToString(CultureInfo.InvariantCulture),
                    invoiceUid: invoiceResponse.Invoice.Uid,
                    eventTypes: new List<InvoiceEventType>()
                    {
                        InvoiceEventType.VoidInvoice
                    }));

            invoiceEventsResponse.Events.Count.Should().BeGreaterOrEqualTo(1);

            var singleEvent = invoiceEventsResponse.Events.FirstOrDefault();
            singleEvent.Should().NotBeNull();
            VoidInvoiceEvent voidInvoiceEvent = CastInvoiceEvent<VoidInvoiceEvent>(singleEvent);

            voidInvoiceEvent.EventType.Should().Be(InvoiceEventType.VoidInvoice);
            voidInvoiceEvent.Id.Should().BeGreaterThan(0);
            voidInvoiceEvent.Timestamp.Should().BeAfter(DateTimeOffset.Now.AddYears(-1));
            
            voidInvoiceEvent.EventData.Should().NotBeNull();
            voidInvoiceEvent.EventData.IsAdvanceInvoice.Should().BeTrue();
            voidInvoiceEvent.EventData.Reason.Should().Be("Duplicate invoice");
            voidInvoiceEvent.EventData.CreditNoteAttributes.Should().NotBeNull();
            voidInvoiceEvent.EventData.Memo.Should().StartWith("Credit for remainder of fully voided invoice");
            voidInvoiceEvent.EventData.AppliedAmount.Should().Be("750.0");
            voidInvoiceEvent.EventData.TransactionTime.Should().BeAfter(DateTimeOffset.Now.AddYears(-1));

            voidInvoiceEvent.Invoice.Uid.Should().Be(invoiceResponse.Invoice.Uid);
            
            await CleanupUtils.ExecuteBasicSubscriptionCleanup(subscriptionResponse, customerResponse, paymentProfileId,
                productResponse, _client);
        }
        
        private T CastInvoiceEvent<T>(InvoiceEvent invoiceEvent)
        {
            Object o = invoiceEvent.Match<Object>(applyDebitNoteEvent: @event => @event, applyPaymentEvent: @event => @event,
                backportInvoiceEvent: @event => @event, issueInvoiceEvent: @event => @event,
                refundInvoiceEvent: @event => @event, voidInvoiceEvent: @event => @event,
                voidRemainderEvent: @event => @event, failedPaymentEvent: @event => @event,
                removePaymentEvent: @event => @event, changeInvoiceStatusEvent: @event => @event,
                changeChargebackStatusEvent: @event => @event, applyCreditNoteEvent: @event => @event,
                createCreditNoteEvent: @event => @event, changeInvoiceCollectionMethodEvent: @event => @event,
                createDebitNoteEvent: @event => @event);
            o.Should().BeOfType(typeof(T));
            return (T) o;
        }

        [Fact]

        public async Task
            Invoices_TryToCreateInvalidInvoice_ResponseCodeIs422WithProperErrorMessage()
        {
            var productFamilyId = await CreationUtils.CreateOrGetProductFamily(_client);

            var productResponse = await CreationUtils.CreateProduct(productFamilyId, _client);

            var customerResponse = await CreationUtils.CreateCustomer(_client);

            var paymentProfileId = await CreationUtils.CreatePaymentProfile(customerResponse.Customer.Id, _client);

            var subscription = new CreateSubscription
            {
                CustomerId = customerResponse.Customer.Id,
                ProductId = productResponse.Product.Id,
                PaymentCollectionMethod = CollectionMethod.Automatic,
                PaymentProfileId = paymentProfileId,
                DunningCommunicationDelayEnabled = false,
                SkipBillingManifestTaxes = false
            };

            var subscriptionResponse =
                await _client.SubscriptionsController.CreateSubscriptionAsync(
                    new CreateSubscriptionRequest(subscription));
            subscriptionResponse.Subscription.Id.Should().NotBeNull();


            var lineItemTitle = $"{TestUtils.GenerateRandomString(5)}lineitem";
            var description = $"{TestUtils.GenerateRandomString(10)} description";

            var invoiceQuantity = "10";
            var invoiceUnitPrice = "150";
            var billingAddress = new CreateInvoiceAddress(TestUtils.GenerateRandomString(8),
                TestUtils.GenerateRandomString(10), "282-329-2085", TestUtils.GenerateRandomString(12),
                TestUtils.GenerateRandomString(6), "ABC", "Washington", "15217", "US");

            var startDate = DateTime.Now.Date;

            var invoiceLineItems = new List<CreateInvoiceItem>
            {
                new(title: lineItemTitle, quantity: CreateInvoiceItemQuantity.FromString(invoiceQuantity),
                    unitPrice: CreateInvoiceItemUnitPrice.FromString(invoiceUnitPrice), description: description,
                    periodRangeStart: startDate.ToString(CultureInfo.InvariantCulture),
                    periodRangeEnd: startDate.AddYears(-1).ToString(CultureInfo.InvariantCulture))
            };

            var invoice = new CreateInvoice(invoiceLineItems, DateTime.Today, billingAddress: billingAddress);

            await _client.Invoking(c => c.InvoicesController.CreateInvoiceAsync(
                (int)subscriptionResponse.Subscription.Id,
                new CreateInvoiceRequest(invoice))).Should().ThrowAsync<ErrorArrayMapResponseException>().Where(e =>
                e.ResponseCode == 422 && e.Errors != null && e.Errors.ToString().Contains("period_range_start") && e.Errors.ToString().Contains("period_range_end"));

            await CleanupUtils.ExecuteBasicSubscriptionCleanup(subscriptionResponse, customerResponse, paymentProfileId,
                productResponse, _client);
        }
    }
}
