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
    /// The ATCs statuses are reported by the wallet. Conditional – required if EventName is REPLENISH
    /// </summary>
    [DataContract(Name = "WalletAtcStatus")]
    public partial class WalletAtcStatus : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WalletAtcStatus" /> class.
        /// </summary>
        /// <param name="unusedDiscarded">The ATCs reported by the wallet that are unused discarded. Max length - Not applicable. Type - Array[String]..</param>
        /// <param name="usedForContactless">The ATCs reported by the wallet that are used for contactless transaction. Max length - Not applicable. Type - Array[String]..</param>
        /// <param name="usedForDsrp">The ATCs reported by the wallet that are used for DSRP transaction. Max length - Not applicable. Type - Array[String].</param>
        /// <param name="unusedActive">The ATCs reported by the wallet that are unused active. Max length - Not applicable. Type - Array[String].</param>
        public WalletAtcStatus(List<string> unusedDiscarded = default(List<string>), List<string> usedForContactless = default(List<string>), List<string> usedForDsrp = default(List<string>), List<string> unusedActive = default(List<string>))
        {
            this.unusedDiscarded = unusedDiscarded;
            this.usedForContactless = usedForContactless;
            this.usedForDsrp = usedForDsrp;
            this.unusedActive = unusedActive;
        }

        /// <summary>
        /// The ATCs reported by the wallet that are unused discarded. Max length - Not applicable. Type - Array[String].
        /// </summary>
        /// <value>The ATCs reported by the wallet that are unused discarded. Max length - Not applicable. Type - Array[String].</value>
        [DataMember(Name = "unusedDiscarded", EmitDefaultValue = false)]
        public List<string> unusedDiscarded { get; set; }

        /// <summary>
        /// The ATCs reported by the wallet that are used for contactless transaction. Max length - Not applicable. Type - Array[String].
        /// </summary>
        /// <value>The ATCs reported by the wallet that are used for contactless transaction. Max length - Not applicable. Type - Array[String].</value>
        [DataMember(Name = "usedForContactless", EmitDefaultValue = false)]
        public List<string> usedForContactless { get; set; }

        /// <summary>
        /// The ATCs reported by the wallet that are used for DSRP transaction. Max length - Not applicable. Type - Array[String]
        /// </summary>
        /// <value>The ATCs reported by the wallet that are used for DSRP transaction. Max length - Not applicable. Type - Array[String]</value>
        [DataMember(Name = "usedForDsrp", EmitDefaultValue = false)]
        public List<string> usedForDsrp { get; set; }

        /// <summary>
        /// The ATCs reported by the wallet that are unused active. Max length - Not applicable. Type - Array[String]
        /// </summary>
        /// <value>The ATCs reported by the wallet that are unused active. Max length - Not applicable. Type - Array[String]</value>
        [DataMember(Name = "unusedActive", EmitDefaultValue = false)]
        public List<string> unusedActive { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WalletAtcStatus {\n");
            sb.Append("  unusedDiscarded: ").Append(unusedDiscarded).Append("\n");
            sb.Append("  usedForContactless: ").Append(usedForContactless).Append("\n");
            sb.Append("  usedForDsrp: ").Append(usedForDsrp).Append("\n");
            sb.Append("  unusedActive: ").Append(unusedActive).Append("\n");
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
