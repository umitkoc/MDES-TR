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
    /// Contains an encrypted JSON object. Encrypted by the ephemeral AES key using CBC mode (IV as provided in &#39;iv&#39;, or zero if none provided) and PKCS#7 padding. The JSON object being encrypted will be defined in the context of the API call. Max length - 256k.  Type - String Hex-encoded Data (case-insensitive). Required - Yes.
    /// </summary>
    [DataContract(Name = "AuthorizeServiceResponseDataSchema")]
    public partial class AuthorizeServiceResponseDataSchema : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorizeServiceResponseDataSchema" /> class.
        /// </summary>
        /// <param name="dataValidUntilTimestamp">The date/time after which this encrypted object is considered invalid. If present, all systems must reject this encrypted object after this time and treat it as invalid data. Must be expressed in ISO 8601 extended format as one of the following:   - YYYY-MM-DDThh:mm:ss[.sss]Z   - YYYY-MM-DDThh:mm:ss[.sss]±hh:mm  Where [.sss] is optional and can be 1 to 3 digits. Must be a value no more than 30 days in the future. Mastercard recommends using a value of (Current Time + 30 minutes). .</param>
        /// <param name="paymentAccountReference">The payment account reference assigned to the PAN. This should only be returned if Mastercard is not the BIN controller.  It will be ignored if Mastercard is the BIN controller for the PAN..</param>
        /// <param name="alternateAccountIdentifier">Account holder-friendly reference to a bank account. Typically used when the account holder is not aware of their Account PAN..</param>
        /// <param name="issuerSpecificPersonalizationData">The operator specific data to add to token personalization profile.  Not applicable. Type - Array [String]. Optional..</param>
        /// <param name="externalToken">externalToken.</param>
        public AuthorizeServiceResponseDataSchema(string dataValidUntilTimestamp = default(string), string paymentAccountReference = default(string), string alternateAccountIdentifier = default(string), List<string> issuerSpecificPersonalizationData = default(List<string>), TokenDataSchema externalToken = default(TokenDataSchema))
        {
            this.dataValidUntilTimestamp = dataValidUntilTimestamp;
            this.paymentAccountReference = paymentAccountReference;
            this.alternateAccountIdentifier = alternateAccountIdentifier;
            this.issuerSpecificPersonalizationData = issuerSpecificPersonalizationData;
            this.externalToken = externalToken;
        }

        /// <summary>
        /// The date/time after which this encrypted object is considered invalid. If present, all systems must reject this encrypted object after this time and treat it as invalid data. Must be expressed in ISO 8601 extended format as one of the following:   - YYYY-MM-DDThh:mm:ss[.sss]Z   - YYYY-MM-DDThh:mm:ss[.sss]±hh:mm  Where [.sss] is optional and can be 1 to 3 digits. Must be a value no more than 30 days in the future. Mastercard recommends using a value of (Current Time + 30 minutes). 
        /// </summary>
        /// <value>The date/time after which this encrypted object is considered invalid. If present, all systems must reject this encrypted object after this time and treat it as invalid data. Must be expressed in ISO 8601 extended format as one of the following:   - YYYY-MM-DDThh:mm:ss[.sss]Z   - YYYY-MM-DDThh:mm:ss[.sss]±hh:mm  Where [.sss] is optional and can be 1 to 3 digits. Must be a value no more than 30 days in the future. Mastercard recommends using a value of (Current Time + 30 minutes). </value>
        /// <example>2026-07-04T12:09:56.123-07:00</example>
        [DataMember(Name = "dataValidUntilTimestamp", EmitDefaultValue = false)]
        public string dataValidUntilTimestamp { get; set; }

        /// <summary>
        /// The payment account reference assigned to the PAN. This should only be returned if Mastercard is not the BIN controller.  It will be ignored if Mastercard is the BIN controller for the PAN.
        /// </summary>
        /// <value>The payment account reference assigned to the PAN. This should only be returned if Mastercard is not the BIN controller.  It will be ignored if Mastercard is the BIN controller for the PAN.</value>
        /// <example>512381d9f8e0629211e3949a08002</example>
        [DataMember(Name = "paymentAccountReference", EmitDefaultValue = false)]
        public string paymentAccountReference { get; set; }

        /// <summary>
        /// Account holder-friendly reference to a bank account. Typically used when the account holder is not aware of their Account PAN.
        /// </summary>
        /// <value>Account holder-friendly reference to a bank account. Typically used when the account holder is not aware of their Account PAN.</value>
        /// <example>GB82WEST12345698765432</example>
        [DataMember(Name = "alternateAccountIdentifier", EmitDefaultValue = false)]
        public string alternateAccountIdentifier { get; set; }

        /// <summary>
        /// The operator specific data to add to token personalization profile.  Not applicable. Type - Array [String]. Optional.
        /// </summary>
        /// <value>The operator specific data to add to token personalization profile.  Not applicable. Type - Array [String]. Optional.</value>
        [DataMember(Name = "issuerSpecificPersonalizationData", EmitDefaultValue = false)]
        public List<string> issuerSpecificPersonalizationData { get; set; }

        /// <summary>
        /// Gets or Sets externalToken
        /// </summary>
        [DataMember(Name = "externalToken", EmitDefaultValue = false)]
        public TokenDataSchema externalToken { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AuthorizeServiceResponseDataSchema {\n");
            sb.Append("  dataValidUntilTimestamp: ").Append(dataValidUntilTimestamp).Append("\n");
            sb.Append("  paymentAccountReference: ").Append(paymentAccountReference).Append("\n");
            sb.Append("  alternateAccountIdentifier: ").Append(alternateAccountIdentifier).Append("\n");
            sb.Append("  issuerSpecificPersonalizationData: ").Append(issuerSpecificPersonalizationData).Append("\n");
            sb.Append("  externalToken: ").Append(externalToken).Append("\n");
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

            // paymentAccountReference (string) maxLength
            if (this.paymentAccountReference != null && this.paymentAccountReference.Length > 29)
            {
                yield return new ValidationResult("Invalid value for paymentAccountReference, length must be less than 29.", new [] { "paymentAccountReference" });
            }

            // paymentAccountReference (string) minLength
            if (this.paymentAccountReference != null && this.paymentAccountReference.Length < 29)
            {
                yield return new ValidationResult("Invalid value for paymentAccountReference, length must be greater than 29.", new [] { "paymentAccountReference" });
            }

            // alternateAccountIdentifier (string) maxLength
            if (this.alternateAccountIdentifier != null && this.alternateAccountIdentifier.Length > 64)
            {
                yield return new ValidationResult("Invalid value for alternateAccountIdentifier, length must be less than 64.", new [] { "alternateAccountIdentifier" });
            }

            // alternateAccountIdentifier (string) minLength
            if (this.alternateAccountIdentifier != null && this.alternateAccountIdentifier.Length < 9)
            {
                yield return new ValidationResult("Invalid value for alternateAccountIdentifier, length must be greater than 9.", new [] { "alternateAccountIdentifier" });
            }

            yield break;
        }
    }

}
