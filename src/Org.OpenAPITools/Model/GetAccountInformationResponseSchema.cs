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
    /// GetAccountInformationResponseSchema
    /// </summary>
    [DataContract(Name = "getAccountInformationResponseSchema")]
    public partial class GetAccountInformationResponseSchema : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetAccountInformationResponseSchema" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetAccountInformationResponseSchema() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetAccountInformationResponseSchema" /> class.
        /// </summary>
        /// <param name="responseId">The Id of the response returned. (required).</param>
        /// <param name="encryptedPayload">encryptedPayload.</param>
        public GetAccountInformationResponseSchema(string responseId = default(string), EncryptedPayloadOut1 encryptedPayload = default(EncryptedPayloadOut1))
        {
            // to ensure "responseId" is required (not null)
            if (responseId == null)
            {
                throw new ArgumentNullException("responseId is a required property for GetAccountInformationResponseSchema and cannot be null");
            }
            this.responseId = responseId;
            this.encryptedPayload = encryptedPayload;
        }

        /// <summary>
        /// The Id of the response returned.
        /// </summary>
        /// <value>The Id of the response returned.</value>
        /// <example>123456</example>
        [DataMember(Name = "responseId", IsRequired = true, EmitDefaultValue = true)]
        public string responseId { get; set; }

        /// <summary>
        /// Gets or Sets encryptedPayload
        /// </summary>
        [DataMember(Name = "encryptedPayload", EmitDefaultValue = false)]
        public EncryptedPayloadOut1 encryptedPayload { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetAccountInformationResponseSchema {\n");
            sb.Append("  responseId: ").Append(responseId).Append("\n");
            sb.Append("  encryptedPayload: ").Append(encryptedPayload).Append("\n");
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
            // responseId (string) maxLength
            if (this.responseId != null && this.responseId.Length > 64)
            {
                yield return new ValidationResult("Invalid value for responseId, length must be less than 64.", new [] { "responseId" });
            }

            // responseId (string) minLength
            if (this.responseId != null && this.responseId.Length < 1)
            {
                yield return new ValidationResult("Invalid value for responseId, length must be greater than 1.", new [] { "responseId" });
            }

            yield break;
        }
    }

}
