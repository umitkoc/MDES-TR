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
    /// Contains the information of the token after redigitization. Conditional – required if reasonCode &#x3D; \&quot;REDIGITIZATION_COMPLETE\&quot;. If an issuer is still configured to receive cardinfo (deprecated) and opt in to receive NTU for re-digitization, they will get cardinfo (deprecated) in the NTU.
    /// </summary>
    [DataContract(Name = "fundingAccountInfoSchemaForNTU")]
    public partial class FundingAccountInfoSchemaForNTU : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FundingAccountInfoSchemaForNTU" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FundingAccountInfoSchemaForNTU() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FundingAccountInfoSchemaForNTU" /> class.
        /// </summary>
        /// <param name="encryptedPayload">encryptedPayload (required).</param>
        public FundingAccountInfoSchemaForNTU(EncryptedPayloadSchemaForNTU encryptedPayload = default(EncryptedPayloadSchemaForNTU))
        {
            // to ensure "encryptedPayload" is required (not null)
            if (encryptedPayload == null)
            {
                throw new ArgumentNullException("encryptedPayload is a required property for FundingAccountInfoSchemaForNTU and cannot be null");
            }
            this.encryptedPayload = encryptedPayload;
        }

        /// <summary>
        /// Gets or Sets encryptedPayload
        /// </summary>
        [DataMember(Name = "encryptedPayload", IsRequired = true, EmitDefaultValue = true)]
        public EncryptedPayloadSchemaForNTU encryptedPayload { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FundingAccountInfoSchemaForNTU {\n");
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
            yield break;
        }
    }

}
