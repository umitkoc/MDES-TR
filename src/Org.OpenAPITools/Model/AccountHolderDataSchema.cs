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
    /// Additional information that can be used to identify the account holder, such as name, address, etc. Max length - Not applicable.
    /// </summary>
    [DataContract(Name = "accountHolderDataSchema")]
    public partial class AccountHolderDataSchema : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountHolderDataSchema" /> class.
        /// </summary>
        /// <param name="accountHolderName">The name of the account holder in the format LASTNAME/FIRSTNAME or FIRSTNAME LASTNAME . Max length - 27. Type - String..</param>
        /// <param name="accountHolderAddress">accountHolderAddress.</param>
        /// <param name="sourceIp">The IP of the device initiating the request..</param>
        /// <param name="deviceLocation">Latitude and longitude where the device the consumer is attempting to authorize is located. In the format \&quot;(sign) latitude/(sign) longitude\&quot; with a precision of 2 decimal places. Ex:\&quot;38.63/-90.2\&quot;. Latitude is between -90 and 90. Longitude between -180 and 180..</param>
        /// <param name="consumerIdentifier">Consumer Identifier provided by the token requestor. Not required – Optionally present in AuthorizeService when provided by the wallet provider..</param>
        /// <param name="accountHolderEmailAddress">The email address of the account holder. Not required - Optionally present in pushAccount request. Not present otherwise..</param>
        /// <param name="accountHolderMobilePhoneNumber">accountHolderMobilePhoneNumber.</param>
        public AccountHolderDataSchema(string accountHolderName = default(string), BillingAddressSchema accountHolderAddress = default(BillingAddressSchema), string sourceIp = default(string), string deviceLocation = default(string), string consumerIdentifier = default(string), string accountHolderEmailAddress = default(string), PhoneNumberSchema accountHolderMobilePhoneNumber = default(PhoneNumberSchema))
        {
            this.accountHolderName = accountHolderName;
            this.accountHolderAddress = accountHolderAddress;
            this.sourceIp = sourceIp;
            this.deviceLocation = deviceLocation;
            this.consumerIdentifier = consumerIdentifier;
            this.accountHolderEmailAddress = accountHolderEmailAddress;
            this.accountHolderMobilePhoneNumber = accountHolderMobilePhoneNumber;
        }

        /// <summary>
        /// The name of the account holder in the format LASTNAME/FIRSTNAME or FIRSTNAME LASTNAME . Max length - 27. Type - String.
        /// </summary>
        /// <value>The name of the account holder in the format LASTNAME/FIRSTNAME or FIRSTNAME LASTNAME . Max length - 27. Type - String.</value>
        /// <example>John Doe</example>
        [DataMember(Name = "accountHolderName", EmitDefaultValue = false)]
        public string accountHolderName { get; set; }

        /// <summary>
        /// Gets or Sets accountHolderAddress
        /// </summary>
        [DataMember(Name = "accountHolderAddress", EmitDefaultValue = false)]
        public BillingAddressSchema accountHolderAddress { get; set; }

        /// <summary>
        /// The IP of the device initiating the request.
        /// </summary>
        /// <value>The IP of the device initiating the request.</value>
        /// <example>127.0.0.1</example>
        [DataMember(Name = "sourceIp", EmitDefaultValue = false)]
        public string sourceIp { get; set; }

        /// <summary>
        /// Latitude and longitude where the device the consumer is attempting to authorize is located. In the format \&quot;(sign) latitude/(sign) longitude\&quot; with a precision of 2 decimal places. Ex:\&quot;38.63/-90.2\&quot;. Latitude is between -90 and 90. Longitude between -180 and 180.
        /// </summary>
        /// <value>Latitude and longitude where the device the consumer is attempting to authorize is located. In the format \&quot;(sign) latitude/(sign) longitude\&quot; with a precision of 2 decimal places. Ex:\&quot;38.63/-90.2\&quot;. Latitude is between -90 and 90. Longitude between -180 and 180.</value>
        /// <example>38.63/-90.2</example>
        [DataMember(Name = "deviceLocation", EmitDefaultValue = false)]
        public string deviceLocation { get; set; }

        /// <summary>
        /// Consumer Identifier provided by the token requestor. Not required – Optionally present in AuthorizeService when provided by the wallet provider.
        /// </summary>
        /// <value>Consumer Identifier provided by the token requestor. Not required – Optionally present in AuthorizeService when provided by the wallet provider.</value>
        /// <example>1b24f24a24ba98e27d43e345b532a245e4723d7a9c4f624e93452c1b24f24a24b</example>
        [DataMember(Name = "consumerIdentifier", EmitDefaultValue = false)]
        public string consumerIdentifier { get; set; }

        /// <summary>
        /// The email address of the account holder. Not required - Optionally present in pushAccount request. Not present otherwise.
        /// </summary>
        /// <value>The email address of the account holder. Not required - Optionally present in pushAccount request. Not present otherwise.</value>
        /// <example>abcdef@xyz.com</example>
        [DataMember(Name = "accountHolderEmailAddress", EmitDefaultValue = false)]
        public string accountHolderEmailAddress { get; set; }

        /// <summary>
        /// Gets or Sets accountHolderMobilePhoneNumber
        /// </summary>
        [DataMember(Name = "accountHolderMobilePhoneNumber", EmitDefaultValue = false)]
        public PhoneNumberSchema accountHolderMobilePhoneNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AccountHolderDataSchema {\n");
            sb.Append("  accountHolderName: ").Append(accountHolderName).Append("\n");
            sb.Append("  accountHolderAddress: ").Append(accountHolderAddress).Append("\n");
            sb.Append("  sourceIp: ").Append(sourceIp).Append("\n");
            sb.Append("  deviceLocation: ").Append(deviceLocation).Append("\n");
            sb.Append("  consumerIdentifier: ").Append(consumerIdentifier).Append("\n");
            sb.Append("  accountHolderEmailAddress: ").Append(accountHolderEmailAddress).Append("\n");
            sb.Append("  accountHolderMobilePhoneNumber: ").Append(accountHolderMobilePhoneNumber).Append("\n");
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
            // accountHolderName (string) maxLength
            if (this.accountHolderName != null && this.accountHolderName.Length > 27)
            {
                yield return new ValidationResult("Invalid value for accountHolderName, length must be less than 27.", new [] { "accountHolderName" });
            }

            // accountHolderName (string) minLength
            if (this.accountHolderName != null && this.accountHolderName.Length < 1)
            {
                yield return new ValidationResult("Invalid value for accountHolderName, length must be greater than 1.", new [] { "accountHolderName" });
            }

            // sourceIp (string) maxLength
            if (this.sourceIp != null && this.sourceIp.Length > 64)
            {
                yield return new ValidationResult("Invalid value for sourceIp, length must be less than 64.", new [] { "sourceIp" });
            }

            // sourceIp (string) minLength
            if (this.sourceIp != null && this.sourceIp.Length < 7)
            {
                yield return new ValidationResult("Invalid value for sourceIp, length must be greater than 7.", new [] { "sourceIp" });
            }

            // deviceLocation (string) maxLength
            if (this.deviceLocation != null && this.deviceLocation.Length > 64)
            {
                yield return new ValidationResult("Invalid value for deviceLocation, length must be less than 64.", new [] { "deviceLocation" });
            }

            // deviceLocation (string) minLength
            if (this.deviceLocation != null && this.deviceLocation.Length < 1)
            {
                yield return new ValidationResult("Invalid value for deviceLocation, length must be greater than 1.", new [] { "deviceLocation" });
            }

            // consumerIdentifier (string) maxLength
            if (this.consumerIdentifier != null && this.consumerIdentifier.Length > 88)
            {
                yield return new ValidationResult("Invalid value for consumerIdentifier, length must be less than 88.", new [] { "consumerIdentifier" });
            }

            // consumerIdentifier (string) minLength
            if (this.consumerIdentifier != null && this.consumerIdentifier.Length < 1)
            {
                yield return new ValidationResult("Invalid value for consumerIdentifier, length must be greater than 1.", new [] { "consumerIdentifier" });
            }

            // accountHolderEmailAddress (string) maxLength
            if (this.accountHolderEmailAddress != null && this.accountHolderEmailAddress.Length > 320)
            {
                yield return new ValidationResult("Invalid value for accountHolderEmailAddress, length must be less than 320.", new [] { "accountHolderEmailAddress" });
            }

            // accountHolderEmailAddress (string) minLength
            if (this.accountHolderEmailAddress != null && this.accountHolderEmailAddress.Length < 6)
            {
                yield return new ValidationResult("Invalid value for accountHolderEmailAddress, length must be greater than 6.", new [] { "accountHolderEmailAddress" });
            }

            yield break;
        }
    }

}
