/*
 * Mastercard Digital Enablement Service Issuer Outbound API
 *
 * The MDES Issuer Outbound Pre-Digitization API supports the pre-digitization web services provided by the Digitization Service. The web services are used to inform Issuers of MDES services being requested by, or on-behalf of, their account holders. Issuers may provide information in their responses to guide or inform the Account holder’s experience through the Token Reqestor.
 *
 * The version of the OpenAPI document: 2.0.21 (Document version)
 * Contact: apisupport@mastercard.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;


namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// The credit or debit card information for the account that is being tokenized. Conditional - required if reasonCode &#x3D; \&quot;REDIGITIZATION_COMPLETE\&quot; or \&quot;FUNDING_ACCOUNT_UPDATE\&quot;. Only present in the FPAN update use case but requires to be opted in.
    /// </summary>
    [DataContract(Name = "cardAccountDataSchema")]
    public partial class CardAccountDataSchema : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CardAccountDataSchema" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CardAccountDataSchema() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CardAccountDataSchema" /> class.
        /// </summary>
        /// <param name="accountNumber">The Account Primary Account Number of the card to be digitized. (required).</param>
        /// <param name="expiryMonth">The month of the expiration date of the card to be digitized. Note that the expiry date may not be in the past. May be omitted if the card does not have an expiry date. (Numeric)..</param>
        /// <param name="expiryYear">The year of the expiration date of the card to be digitized. Note that the expiry date may not be in the past. May be omitted if the card does not have an expiry date. (Numeric)..</param>
        /// <param name="securityCode">The CVC2 for the card to be digitized, as entered by the Cardholder. Verified as part of reaching the digitization decision..</param>
        public CardAccountDataSchema(string accountNumber = default(string), string expiryMonth = default(string), string expiryYear = default(string), string securityCode = default(string))
        {
            // to ensure "accountNumber" is required (not null)
            if (accountNumber == null)
            {
                throw new ArgumentNullException("accountNumber is a required property for CardAccountDataSchema and cannot be null");
            }
            this.accountNumber = accountNumber;
            this.expiryMonth = expiryMonth;
            this.expiryYear = expiryYear;
            this.securityCode = securityCode;
        }

        /// <summary>
        /// The Account Primary Account Number of the card to be digitized.
        /// </summary>
        /// <value>The Account Primary Account Number of the card to be digitized.</value>
        /// <example>5123456789012345</example>
        [DataMember(Name = "accountNumber", IsRequired = true, EmitDefaultValue = true)]
        public string accountNumber { get; set; }

        /// <summary>
        /// The month of the expiration date of the card to be digitized. Note that the expiry date may not be in the past. May be omitted if the card does not have an expiry date. (Numeric).
        /// </summary>
        /// <value>The month of the expiration date of the card to be digitized. Note that the expiry date may not be in the past. May be omitted if the card does not have an expiry date. (Numeric).</value>
        /// <example>12</example>
        [DataMember(Name = "expiryMonth", EmitDefaultValue = false)]
        public string expiryMonth { get; set; }

        /// <summary>
        /// The year of the expiration date of the card to be digitized. Note that the expiry date may not be in the past. May be omitted if the card does not have an expiry date. (Numeric).
        /// </summary>
        /// <value>The year of the expiration date of the card to be digitized. Note that the expiry date may not be in the past. May be omitted if the card does not have an expiry date. (Numeric).</value>
        /// <example>26</example>
        [DataMember(Name = "expiryYear", EmitDefaultValue = false)]
        public string expiryYear { get; set; }

        /// <summary>
        /// The CVC2 for the card to be digitized, as entered by the Cardholder. Verified as part of reaching the digitization decision.
        /// </summary>
        /// <value>The CVC2 for the card to be digitized, as entered by the Cardholder. Verified as part of reaching the digitization decision.</value>
        /// <example>123</example>
        [DataMember(Name = "securityCode", EmitDefaultValue = false)]
        public string securityCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CardAccountDataSchema {\n");
            sb.Append("  accountNumber: ").Append(accountNumber).Append("\n");
            sb.Append("  expiryMonth: ").Append(expiryMonth).Append("\n");
            sb.Append("  expiryYear: ").Append(expiryYear).Append("\n");
            sb.Append("  securityCode: ").Append(securityCode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // accountNumber (string) maxLength
            if (this.accountNumber != null && this.accountNumber.Length > 19)
            {
                yield return new ValidationResult("Invalid value for accountNumber, length must be less than 19.", new [] { "accountNumber" });
            }

            // accountNumber (string) minLength
            if (this.accountNumber != null && this.accountNumber.Length < 9)
            {
                yield return new ValidationResult("Invalid value for accountNumber, length must be greater than 9.", new [] { "accountNumber" });
            }

            // expiryMonth (string) maxLength
            if (this.expiryMonth != null && this.expiryMonth.Length > 2)
            {
                yield return new ValidationResult("Invalid value for expiryMonth, length must be less than 2.", new [] { "expiryMonth" });
            }

            // expiryMonth (string) minLength
            if (this.expiryMonth != null && this.expiryMonth.Length < 2)
            {
                yield return new ValidationResult("Invalid value for expiryMonth, length must be greater than 2.", new [] { "expiryMonth" });
            }

            // expiryYear (string) maxLength
            if (this.expiryYear != null && this.expiryYear.Length > 2)
            {
                yield return new ValidationResult("Invalid value for expiryYear, length must be less than 2.", new [] { "expiryYear" });
            }

            // expiryYear (string) minLength
            if (this.expiryYear != null && this.expiryYear.Length < 2)
            {
                yield return new ValidationResult("Invalid value for expiryYear, length must be greater than 2.", new [] { "expiryYear" });
            }

            // securityCode (string) maxLength
            if (this.securityCode != null && this.securityCode.Length > 3)
            {
                yield return new ValidationResult("Invalid value for securityCode, length must be less than 3.", new [] { "securityCode" });
            }

            // securityCode (string) minLength
            if (this.securityCode != null && this.securityCode.Length < 3)
            {
                yield return new ValidationResult("Invalid value for securityCode, length must be greater than 3.", new [] { "securityCode" });
            }

            yield break;
        }
    }

}
