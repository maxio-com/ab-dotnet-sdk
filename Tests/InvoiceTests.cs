using System.Globalization;
using AdvancedBilling.Standard;
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
                PaymentCollectionMethod = PaymentCollectionMethod.Automatic,
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

            var createInvoiceCoupons = new List<CreateInvoiceCoupon> { new CreateInvoiceCoupon( code: TestUtils.GenerateRandomString(4), percentage: CreateInvoiceCouponPercentage.FromString("50")) };

            var invoiceLineItems = new List<CreateInvoiceItem>
            {
                new(title: lineItemTitle, quantity: CreateInvoiceItemQuantity.FromString(invoiceQuantity),
                    unitPrice: CreateInvoiceItemUnitPrice.FromString(invoiceUnitPrice), description: description)
            };

            var invoice = new CreateInvoice(invoiceLineItems, DateTime.Today, billingAddress: billingAddress, coupons: createInvoiceCoupons);

            var invoiceResponse = await _client.InvoicesController.CreateInvoiceAsync((int)subscriptionResponse.Subscription.Id,
                new CreateInvoiceRequest(invoice));

            invoiceResponse.Invoice.Uid.Should().NotBeNullOrEmpty();

            var reason = "Duplicate invoice";

            var voidInvoice = new VoidInvoice(reason);

            var voidInvoiceResponse = await _client.InvoicesController.VoidInvoiceAsync(invoiceResponse.Invoice.Uid, new VoidInvoiceRequest(voidInvoice));

            voidInvoiceResponse.Uid.Should().NotBeNull();

            var invoiceEventsResponse = await _client.InvoicesController.ListInvoiceEventsAsync(new ListInvoiceEventsInput(
                sinceDate: DateTime.Now.AddDays(-1).ToString(CultureInfo.InvariantCulture), eventTypes: new List<InvoiceEventType>()
                {
                    InvoiceEventType.VoidInvoice
                }));

            invoiceEventsResponse.Events.Count.Should().BeGreaterOrEqualTo(1);

            var singleEvent = invoiceEventsResponse.Events.FirstOrDefault();

            singleEvent.Should().NotBeNull();

            singleEvent.EventType.Should().Be(InvoiceEventType.VoidInvoice);

            await CleanupUtils.ExecuteBasicSubscriptionCleanup(subscriptionResponse, customerResponse, paymentProfileId,
                productResponse, _client);
        }

    }
}
