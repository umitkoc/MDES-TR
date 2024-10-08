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
    /// AccountInformationDataSchema
    /// </summary>
    [DataContract(Name = "AccountInformationDataSchema")]
    public partial class AccountInformationDataSchema : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountInformationDataSchema" /> class.
        /// </summary>
        /// <param name="dataValidUntilTimestamp">The date/time after which this encrypted object is considered invalid. If present, all systems must reject this encrypted object after this time and treat it as invalid data. Must be expressed in ISO 8601 extended format as one of the following:   - YYYY-MM-DDThh:mm:ss[.sss]Z   - YYYY-MM-DDThh:mm:ss[.sss]±hh:mm  Where [.sss] is optional and can be 1 to 3 digits. Must be a value no more than 30 days in the future. Mastercard recommends using a value of (Current Time + 30 minutes). .</param>
        /// <param name="balanceInformation">balanceInformation.</param>
        /// <param name="accountStatus">The status of the account. Must be one of ACTIVE &#x3D; The account is active | EXPIRED &#x3D; The account is expired | INVALID &#x3D; The account is not recognized | UNKNOWN &#x3D; The account is in an unknown state | CANCELLED &#x3D; The account is cancelled..</param>
        public AccountInformationDataSchema(string dataValidUntilTimestamp = default(string), BalanceInformationSchema balanceInformation = default(BalanceInformationSchema), string accountStatus = default(string))
        {
            this.dataValidUntilTimestamp = dataValidUntilTimestamp;
            this.balanceInformation = balanceInformation;
            this.accountStatus = accountStatus;
        }

        /// <summary>
        /// The date/time after which this encrypted object is considered invalid. If present, all systems must reject this encrypted object after this time and treat it as invalid data. Must be expressed in ISO 8601 extended format as one of the following:   - YYYY-MM-DDThh:mm:ss[.sss]Z   - YYYY-MM-DDThh:mm:ss[.sss]±hh:mm  Where [.sss] is optional and can be 1 to 3 digits. Must be a value no more than 30 days in the future. Mastercard recommends using a value of (Current Time + 30 minutes). 
        /// </summary>
        /// <value>The date/time after which this encrypted object is considered invalid. If present, all systems must reject this encrypted object after this time and treat it as invalid data. Must be expressed in ISO 8601 extended format as one of the following:   - YYYY-MM-DDThh:mm:ss[.sss]Z   - YYYY-MM-DDThh:mm:ss[.sss]±hh:mm  Where [.sss] is optional and can be 1 to 3 digits. Must be a value no more than 30 days in the future. Mastercard recommends using a value of (Current Time + 30 minutes). </value>
        /// <example>2026-07-04T12:09:56.123-07:00</example>
        [DataMember(Name = "dataValidUntilTimestamp", EmitDefaultValue = false)]
        public string dataValidUntilTimestamp { get; set; }

        /// <summary>
        /// Gets or Sets balanceInformation
        /// </summary>
        [DataMember(Name = "balanceInformation", EmitDefaultValue = false)]
        public BalanceInformationSchema balanceInformation { get; set; }

        /// <summary>
        /// The status of the account. Must be one of ACTIVE &#x3D; The account is active | EXPIRED &#x3D; The account is expired | INVALID &#x3D; The account is not recognized | UNKNOWN &#x3D; The account is in an unknown state | CANCELLED &#x3D; The account is cancelled.
        /// </summary>
        /// <value>The status of the account. Must be one of ACTIVE &#x3D; The account is active | EXPIRED &#x3D; The account is expired | INVALID &#x3D; The account is not recognized | UNKNOWN &#x3D; The account is in an unknown state | CANCELLED &#x3D; The account is cancelled.</value>
        /// <example>INVALID</example>
        [DataMember(Name = "accountStatus", EmitDefaultValue = false)]
        public string accountStatus { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AccountInformationDataSchema {\n");
            sb.Append("  dataValidUntilTimestamp: ").Append(dataValidUntilTimestamp).Append("\n");
            sb.Append("  balanceInformation: ").Append(balanceInformation).Append("\n");
            sb.Append("  accountStatus: ").Append(accountStatus).Append("\n");
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
            // dataValidUntilTimestamp (string) maxLength
            if (this.dataValidUntilTimestamp != null && this.dataValidUntilTimestamp.Length > 29)
            {
                yield return new ValidationResult("Invalid value for dataValidUntilTimestamp, length must be less than 29.", new [] { "dataValidUntilTimestamp" });
            }

            // dataValidUntilTimestamp (string) minLength
            if (this.dataValidUntilTimestamp != null && this.dataValidUntilTimestamp.Length < 20)
            {
                yield return new ValidationResult("Invalid value for dataValidUntilTimestamp, length must be greater than 20.", new [] { "dataValidUntilTimestamp" });
            }

            // accountStatus (string) maxLength
            if (this.accountStatus != null && this.accountStatus.Length > 24)
            {
                yield return new ValidationResult("Invalid value for accountStatus, length must be less than 24.", new [] { "accountStatus" });
            }

            // accountStatus (string) minLength
            if (this.accountStatus != null && this.accountStatus.Length < 1)
            {
                yield return new ValidationResult("Invalid value for accountStatus, length must be greater than 1.", new [] { "accountStatus" });
            }

            yield break;
        }
    }

}
