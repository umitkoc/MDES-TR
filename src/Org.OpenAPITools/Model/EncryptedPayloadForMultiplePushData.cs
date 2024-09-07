/*
 * Token Connect API
 *
 * The MDES APIs are designed as RPC style stateless web services where each API endpoint represents an operation to be performed. All request and response payloads are sent in the JSON (JavaScript Object Notation) data-interchange format. Each endpoint in the API specifies the HTTP Method used to access it. All strings in request and response objects are to be UTF-8 encoded. All request and response parameters are case sensitive. 
 *
 * The version of the OpenAPI document: 2.0.8
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
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// EncryptedPayloadForMultiplePushData
    /// </summary>
    [DataContract(Name = "EncryptedPayloadForMultiplePushData")]
    public partial class EncryptedPayloadForMultiplePushData : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EncryptedPayloadForMultiplePushData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EncryptedPayloadForMultiplePushData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EncryptedPayloadForMultiplePushData" /> class.
        /// </summary>
        /// <param name="encryptedData">Encrypted object containing array of [Push Multiple Funding Account](https://developer.mastercard.com/mdes-token-connect/documentation/api-reference/api-reference/#push-multiple-funding-account) objects containing the account information to be pushed by the Issuer.  (required).</param>
        /// <param name="publicKeyFingerprint">Refer to Breaking the Encrypted Payload Down &gt; [publicKeyFingerprint](https://developer.mastercard.com/platform/documentation/security-and-authentication/securing-sensitive-data-using-payload-encryption/#breaking-the-encrypted-payload-down) (required).</param>
        /// <param name="encryptedKey">Refer to Breaking the Encrypted Payload Down &gt; [encryptedKey](https://developer.mastercard.com/platform/documentation/security-and-authentication/securing-sensitive-data-using-payload-encryption/#breaking-the-encrypted-payload-down) (required).</param>
        /// <param name="oaepHashingAlgorithm">Refer to Breaking the Encrypted Payload Down &gt; [oaepPaddingDigestAlgorithm](https://developer.mastercard.com/platform/documentation/security-and-authentication/securing-sensitive-data-using-payload-encryption/#breaking-the-encrypted-payload-down).</param>
        /// <param name="iv">Refer to Breaking the Encrypted Payload Down &gt; [iv](https://developer.mastercard.com/platform/documentation/security-and-authentication/securing-sensitive-data-using-payload-encryption/#breaking-the-encrypted-payload-down).</param>
        public EncryptedPayloadForMultiplePushData(List<PushMultipleFundingAccount> encryptedData = default(List<PushMultipleFundingAccount>), string publicKeyFingerprint = default(string), string encryptedKey = default(string), string oaepHashingAlgorithm = default(string), string iv = default(string))
        {
            // to ensure "encryptedData" is required (not null)
            if (encryptedData == null)
            {
                throw new ArgumentNullException("encryptedData is a required property for EncryptedPayloadForMultiplePushData and cannot be null");
            }
            this.encryptedData = encryptedData;
            // to ensure "publicKeyFingerprint" is required (not null)
            if (publicKeyFingerprint == null)
            {
                throw new ArgumentNullException("publicKeyFingerprint is a required property for EncryptedPayloadForMultiplePushData and cannot be null");
            }
            this.publicKeyFingerprint = publicKeyFingerprint;
            // to ensure "encryptedKey" is required (not null)
            if (encryptedKey == null)
            {
                throw new ArgumentNullException("encryptedKey is a required property for EncryptedPayloadForMultiplePushData and cannot be null");
            }
            this.encryptedKey = encryptedKey;
            this.oaepHashingAlgorithm = oaepHashingAlgorithm;
            this.iv = iv;
        }

        /// <summary>
        /// Encrypted object containing array of [Push Multiple Funding Account](https://developer.mastercard.com/mdes-token-connect/documentation/api-reference/api-reference/#push-multiple-funding-account) objects containing the account information to be pushed by the Issuer. 
        /// </summary>
        /// <value>Encrypted object containing array of [Push Multiple Funding Account](https://developer.mastercard.com/mdes-token-connect/documentation/api-reference/api-reference/#push-multiple-funding-account) objects containing the account information to be pushed by the Issuer. </value>
        [DataMember(Name = "encryptedData", IsRequired = true, EmitDefaultValue = true)]
        public List<PushMultipleFundingAccount> encryptedData { get; set; }

        /// <summary>
        /// Refer to Breaking the Encrypted Payload Down &gt; [publicKeyFingerprint](https://developer.mastercard.com/platform/documentation/security-and-authentication/securing-sensitive-data-using-payload-encryption/#breaking-the-encrypted-payload-down)
        /// </summary>
        /// <value>Refer to Breaking the Encrypted Payload Down &gt; [publicKeyFingerprint](https://developer.mastercard.com/platform/documentation/security-and-authentication/securing-sensitive-data-using-payload-encryption/#breaking-the-encrypted-payload-down)</value>
        /// <example>80810fc13a8319fcf0e2e(...)82cc3ce671176343cfe8160c2279</example>
        [DataMember(Name = "publicKeyFingerprint", IsRequired = true, EmitDefaultValue = true)]
        public string publicKeyFingerprint { get; set; }

        /// <summary>
        /// Refer to Breaking the Encrypted Payload Down &gt; [encryptedKey](https://developer.mastercard.com/platform/documentation/security-and-authentication/securing-sensitive-data-using-payload-encryption/#breaking-the-encrypted-payload-down)
        /// </summary>
        /// <value>Refer to Breaking the Encrypted Payload Down &gt; [encryptedKey](https://developer.mastercard.com/platform/documentation/security-and-authentication/securing-sensitive-data-using-payload-encryption/#breaking-the-encrypted-payload-down)</value>
        /// <example>d5112fa08e554e3dbc455d0628(...)52e826dd10311cf0d63bbfb231a1a63ecc13</example>
        [DataMember(Name = "encryptedKey", IsRequired = true, EmitDefaultValue = true)]
        public string encryptedKey { get; set; }

        /// <summary>
        /// Refer to Breaking the Encrypted Payload Down &gt; [oaepPaddingDigestAlgorithm](https://developer.mastercard.com/platform/documentation/security-and-authentication/securing-sensitive-data-using-payload-encryption/#breaking-the-encrypted-payload-down)
        /// </summary>
        /// <value>Refer to Breaking the Encrypted Payload Down &gt; [oaepPaddingDigestAlgorithm](https://developer.mastercard.com/platform/documentation/security-and-authentication/securing-sensitive-data-using-payload-encryption/#breaking-the-encrypted-payload-down)</value>
        /// <example>SHA512</example>
        [DataMember(Name = "oaepHashingAlgorithm", EmitDefaultValue = false)]
        public string oaepHashingAlgorithm { get; set; }

        /// <summary>
        /// Refer to Breaking the Encrypted Payload Down &gt; [iv](https://developer.mastercard.com/platform/documentation/security-and-authentication/securing-sensitive-data-using-payload-encryption/#breaking-the-encrypted-payload-down)
        /// </summary>
        /// <value>Refer to Breaking the Encrypted Payload Down &gt; [iv](https://developer.mastercard.com/platform/documentation/security-and-authentication/securing-sensitive-data-using-payload-encryption/#breaking-the-encrypted-payload-down)</value>
        /// <example>1b9396c98ab2bfd195de661d70905a45</example>
        [DataMember(Name = "iv", EmitDefaultValue = false)]
        public string iv { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EncryptedPayloadForMultiplePushData {\n");
            sb.Append("  encryptedData: ").Append(encryptedData).Append("\n");
            sb.Append("  publicKeyFingerprint: ").Append(publicKeyFingerprint).Append("\n");
            sb.Append("  encryptedKey: ").Append(encryptedKey).Append("\n");
            sb.Append("  oaepHashingAlgorithm: ").Append(oaepHashingAlgorithm).Append("\n");
            sb.Append("  iv: ").Append(iv).Append("\n");
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
