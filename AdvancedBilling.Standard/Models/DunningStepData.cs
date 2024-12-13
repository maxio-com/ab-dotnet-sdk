// <copyright file="DunningStepData.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APIMatic.Core.Utilities.Converters;
using AdvancedBilling.Standard;
using AdvancedBilling.Standard.Utilities;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// DunningStepData.
    /// </summary>
    public class DunningStepData : BaseModel
    {
        private string emailBody;
        private string emailSubject;
        private string smsBody;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "email_body", false },
            { "email_subject", false },
            { "sms_body", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="DunningStepData"/> class.
        /// </summary>
        public DunningStepData()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DunningStepData"/> class.
        /// </summary>
        /// <param name="dayThreshold">day_threshold.</param>
        /// <param name="action">action.</param>
        /// <param name="sendEmail">send_email.</param>
        /// <param name="sendBccEmail">send_bcc_email.</param>
        /// <param name="sendSms">send_sms.</param>
        /// <param name="emailBody">email_body.</param>
        /// <param name="emailSubject">email_subject.</param>
        /// <param name="smsBody">sms_body.</param>
        public DunningStepData(
            int dayThreshold,
            string action,
            bool sendEmail,
            bool sendBccEmail,
            bool sendSms,
            string emailBody = null,
            string emailSubject = null,
            string smsBody = null)
        {
            this.DayThreshold = dayThreshold;
            this.Action = action;

            if (emailBody != null)
            {
                this.EmailBody = emailBody;
            }

            if (emailSubject != null)
            {
                this.EmailSubject = emailSubject;
            }
            this.SendEmail = sendEmail;
            this.SendBccEmail = sendBccEmail;
            this.SendSms = sendSms;

            if (smsBody != null)
            {
                this.SmsBody = smsBody;
            }
        }

        /// <summary>
        /// Gets or sets DayThreshold.
        /// </summary>
        [JsonProperty("day_threshold")]
        public int DayThreshold { get; set; }

        /// <summary>
        /// Gets or sets Action.
        /// </summary>
        [JsonProperty("action")]
        public string Action { get; set; }

        /// <summary>
        /// Gets or sets EmailBody.
        /// </summary>
        [JsonProperty("email_body")]
        public string EmailBody
        {
            get
            {
                return this.emailBody;
            }

            set
            {
                this.shouldSerialize["email_body"] = true;
                this.emailBody = value;
            }
        }

        /// <summary>
        /// Gets or sets EmailSubject.
        /// </summary>
        [JsonProperty("email_subject")]
        public string EmailSubject
        {
            get
            {
                return this.emailSubject;
            }

            set
            {
                this.shouldSerialize["email_subject"] = true;
                this.emailSubject = value;
            }
        }

        /// <summary>
        /// Gets or sets SendEmail.
        /// </summary>
        [JsonProperty("send_email")]
        public bool SendEmail { get; set; }

        /// <summary>
        /// Gets or sets SendBccEmail.
        /// </summary>
        [JsonProperty("send_bcc_email")]
        public bool SendBccEmail { get; set; }

        /// <summary>
        /// Gets or sets SendSms.
        /// </summary>
        [JsonProperty("send_sms")]
        public bool SendSms { get; set; }

        /// <summary>
        /// Gets or sets SmsBody.
        /// </summary>
        [JsonProperty("sms_body")]
        public string SmsBody
        {
            get
            {
                return this.smsBody;
            }

            set
            {
                this.shouldSerialize["sms_body"] = true;
                this.smsBody = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"DunningStepData : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetEmailBody()
        {
            this.shouldSerialize["email_body"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetEmailSubject()
        {
            this.shouldSerialize["email_subject"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetSmsBody()
        {
            this.shouldSerialize["sms_body"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeEmailBody()
        {
            return this.shouldSerialize["email_body"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeEmailSubject()
        {
            return this.shouldSerialize["email_subject"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeSmsBody()
        {
            return this.shouldSerialize["sms_body"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is DunningStepData other &&
                (this.DayThreshold.Equals(other.DayThreshold)) &&
                (this.Action == null && other.Action == null ||
                 this.Action?.Equals(other.Action) == true) &&
                (this.EmailBody == null && other.EmailBody == null ||
                 this.EmailBody?.Equals(other.EmailBody) == true) &&
                (this.EmailSubject == null && other.EmailSubject == null ||
                 this.EmailSubject?.Equals(other.EmailSubject) == true) &&
                (this.SendEmail.Equals(other.SendEmail)) &&
                (this.SendBccEmail.Equals(other.SendBccEmail)) &&
                (this.SendSms.Equals(other.SendSms)) &&
                (this.SmsBody == null && other.SmsBody == null ||
                 this.SmsBody?.Equals(other.SmsBody) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.DayThreshold = {this.DayThreshold}");
            toStringOutput.Add($"this.Action = {this.Action ?? "null"}");
            toStringOutput.Add($"this.EmailBody = {this.EmailBody ?? "null"}");
            toStringOutput.Add($"this.EmailSubject = {this.EmailSubject ?? "null"}");
            toStringOutput.Add($"this.SendEmail = {this.SendEmail}");
            toStringOutput.Add($"this.SendBccEmail = {this.SendBccEmail}");
            toStringOutput.Add($"this.SendSms = {this.SendSms}");
            toStringOutput.Add($"this.SmsBody = {this.SmsBody ?? "null"}");

            base.ToString(toStringOutput);
        }
    }
}