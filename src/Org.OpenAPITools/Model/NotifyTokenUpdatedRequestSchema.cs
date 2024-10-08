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
    /// NotifyTokenUpdatedRequestSchema
    /// </summary>
    [DataContract(Name = "NotifyTokenUpdatedRequestSchema")]
    public partial class NotifyTokenUpdatedRequestSchema : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NotifyTokenUpdatedRequestSchema" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NotifyTokenUpdatedRequestSchema() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NotifyTokenUpdatedRequestSchema" /> class.
        /// </summary>
        /// <param name="requestId">The Id of the request submitted. Max length - 64 (required).</param>
        /// <param name="reasonCode">The reason code for why the notification is being sent. This applies to all tokens in the Tokens array. Must be one of:   * STATUS_UPDATE - The status of the tokens has been changed when the token is activated, suspended, deleted, or inactivated.    * REDIGITIZATION_COMPLETE - The token has been re-digitized to the device in the token expiry and FPAN update to a new range use cases.   * DELETED_FROM_CONSUMER_APP - The token has been deleted from the consumer application. The token may still be active in MDES.    * AUTHENTICATION_PERFORMED - Account holder authentication was performed on the token. The status did not change as a result   * PAYMT_CHANNEL_PREFERENCE_UPDATED - Cardholder has updated the payment channels the token is allowed to be used for (India only).   * FUNDING_ACCOUNT_UPDATE - Token and FPAN mapping has been updated due to FPAN or expiry or Financial account has been changed but Token is not changed. The status did not change as a result.   (required).</param>
        /// <param name="tokens">Contains the Tokens which were updated. (required).</param>
        public NotifyTokenUpdatedRequestSchema(string requestId = default(string), string reasonCode = default(string), List<Token> tokens = default(List<Token>))
        {
            // to ensure "requestId" is required (not null)
            if (requestId == null)
            {
                throw new ArgumentNullException("requestId is a required property for NotifyTokenUpdatedRequestSchema and cannot be null");
            }
            this.requestId = requestId;
            // to ensure "reasonCode" is required (not null)
            if (reasonCode == null)
            {
                throw new ArgumentNullException("reasonCode is a required property for NotifyTokenUpdatedRequestSchema and cannot be null");
            }
            this.reasonCode = reasonCode;
            // to ensure "tokens" is required (not null)
            if (tokens == null)
            {
                throw new ArgumentNullException("tokens is a required property for NotifyTokenUpdatedRequestSchema and cannot be null");
            }
            this.tokens = tokens;
        }

        /// <summary>
        /// The Id of the request submitted. Max length - 64
        /// </summary>
        /// <value>The Id of the request submitted. Max length - 64</value>
        /// <example>123456</example>
        [DataMember(Name = "requestId", IsRequired = true, EmitDefaultValue = true)]
        public string requestId { get; set; }

        /// <summary>
        /// The reason code for why the notification is being sent. This applies to all tokens in the Tokens array. Must be one of:   * STATUS_UPDATE - The status of the tokens has been changed when the token is activated, suspended, deleted, or inactivated.    * REDIGITIZATION_COMPLETE - The token has been re-digitized to the device in the token expiry and FPAN update to a new range use cases.   * DELETED_FROM_CONSUMER_APP - The token has been deleted from the consumer application. The token may still be active in MDES.    * AUTHENTICATION_PERFORMED - Account holder authentication was performed on the token. The status did not change as a result   * PAYMT_CHANNEL_PREFERENCE_UPDATED - Cardholder has updated the payment channels the token is allowed to be used for (India only).   * FUNDING_ACCOUNT_UPDATE - Token and FPAN mapping has been updated due to FPAN or expiry or Financial account has been changed but Token is not changed. The status did not change as a result.  
        /// </summary>
        /// <value>The reason code for why the notification is being sent. This applies to all tokens in the Tokens array. Must be one of:   * STATUS_UPDATE - The status of the tokens has been changed when the token is activated, suspended, deleted, or inactivated.    * REDIGITIZATION_COMPLETE - The token has been re-digitized to the device in the token expiry and FPAN update to a new range use cases.   * DELETED_FROM_CONSUMER_APP - The token has been deleted from the consumer application. The token may still be active in MDES.    * AUTHENTICATION_PERFORMED - Account holder authentication was performed on the token. The status did not change as a result   * PAYMT_CHANNEL_PREFERENCE_UPDATED - Cardholder has updated the payment channels the token is allowed to be used for (India only).   * FUNDING_ACCOUNT_UPDATE - Token and FPAN mapping has been updated due to FPAN or expiry or Financial account has been changed but Token is not changed. The status did not change as a result.  </value>
        /// <example>STATUS_UPDATE</example>
        [DataMember(Name = "reasonCode", IsRequired = true, EmitDefaultValue = true)]
        public string reasonCode { get; set; }

        /// <summary>
        /// Contains the Tokens which were updated.
        /// </summary>
        /// <value>Contains the Tokens which were updated.</value>
        [DataMember(Name = "tokens", IsRequired = true, EmitDefaultValue = true)]
        public List<Token> tokens { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NotifyTokenUpdatedRequestSchema {\n");
            sb.Append("  requestId: ").Append(requestId).Append("\n");
            sb.Append("  reasonCode: ").Append(reasonCode).Append("\n");
            sb.Append("  tokens: ").Append(tokens).Append("\n");
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
            // requestId (string) maxLength
            if (this.requestId != null && this.requestId.Length > 64)
            {
                yield return new ValidationResult("Invalid value for requestId, length must be less than 64.", new [] { "requestId" });
            }

            // requestId (string) minLength
            if (this.requestId != null && this.requestId.Length < 1)
            {
                yield return new ValidationResult("Invalid value for requestId, length must be greater than 1.", new [] { "requestId" });
            }

            // reasonCode (string) maxLength
            if (this.reasonCode != null && this.reasonCode.Length > 32)
            {
                yield return new ValidationResult("Invalid value for reasonCode, length must be less than 32.", new [] { "reasonCode" });
            }

            // reasonCode (string) minLength
            if (this.reasonCode != null && this.reasonCode.Length < 1)
            {
                yield return new ValidationResult("Invalid value for reasonCode, length must be greater than 1.", new [] { "reasonCode" });
            }

            yield break;
        }
    }

}
