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
    /// Contains an encrypted object. Data Type - EncryptedPayload object containing a FundingAccountData object. Max length - N/A.
    /// </summary>
    [DataContract(Name = "encryptedPayloadIn")]
    public partial class EncryptedPayloadIn : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EncryptedPayloadIn" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EncryptedPayloadIn() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EncryptedPayloadIn" /> class.
        /// </summary>
        /// <param name="encryptedData">encryptedData (required).</param>
        /// <param name="publicKeyFingerprint">The fingerprint of the public key used to encrypt the ephemeral AES key. Type - String Hex-encoded Data (case-insensitive). (required).</param>
        /// <param name="encryptedKey">One-time use AES key encrypted by the Mastercard public key (as identified by &#39;publicKeyFingerprint&#39;) using the OAEP or RSA Encryption Standard PKCS 1 v1.5 (depending on the value of &#39;oaepHashingAlgorithm&#39;). Requirement is for a 128-bit key (with 256-bit key supported as an option). Max length - 512. Type - String Hex-encoded Data (case-insensitive). (required).</param>
        /// <param name="oaepHashingAlgorithm">Hashing algorithm used with the OAEP scheme. If omitted, then the RSA Encryption Standard PKCS 1 v1.5 will be used. You must use one of the following algorithms; SHA256 - Use the SHA-256 algorithm | SHA512 - Use the SHA-512 algorithm..</param>
        /// <param name="iv">The initialization vector used when encrypting data using the one-time use AES key. Must be exactly 16 bytes (32 character hex string) to match the block size. If not present, an IV of zero is assumed. Max length - 32 (exact). Type - String Hex-encoded Data (case-insensitive)..</param>
        public EncryptedPayloadIn(FundingAccountDataSchema encryptedData = default(FundingAccountDataSchema), string publicKeyFingerprint = default(string), string encryptedKey = default(string), string oaepHashingAlgorithm = default(string), string iv = default(string))
        {
            // to ensure "encryptedData" is required (not null)
            if (encryptedData == null)
            {
                throw new ArgumentNullException("encryptedData is a required property for EncryptedPayloadIn and cannot be null");
            }
            this.encryptedData = encryptedData;
            // to ensure "publicKeyFingerprint" is required (not null)
            if (publicKeyFingerprint == null)
            {
                throw new ArgumentNullException("publicKeyFingerprint is a required property for EncryptedPayloadIn and cannot be null");
            }
            this.publicKeyFingerprint = publicKeyFingerprint;
            // to ensure "encryptedKey" is required (not null)
            if (encryptedKey == null)
            {
                throw new ArgumentNullException("encryptedKey is a required property for EncryptedPayloadIn and cannot be null");
            }
            this.encryptedKey = encryptedKey;
            this.oaepHashingAlgorithm = oaepHashingAlgorithm;
            this.iv = iv;
        }

        /// <summary>
        /// Gets or Sets encryptedData
        /// </summary>
        [DataMember(Name = "encryptedData", IsRequired = true, EmitDefaultValue = true)]
        public FundingAccountDataSchema encryptedData { get; set; }

        /// <summary>
        /// The fingerprint of the public key used to encrypt the ephemeral AES key. Type - String Hex-encoded Data (case-insensitive).
        /// </summary>
        /// <value>The fingerprint of the public key used to encrypt the ephemeral AES key. Type - String Hex-encoded Data (case-insensitive).</value>
        /// <example>4c4ead5927f0df8117f178eea9308daa58e27c2b</example>
        [DataMember(Name = "publicKeyFingerprint", IsRequired = true, EmitDefaultValue = true)]
        public string publicKeyFingerprint { get; set; }

        /// <summary>
        /// One-time use AES key encrypted by the Mastercard public key (as identified by &#39;publicKeyFingerprint&#39;) using the OAEP or RSA Encryption Standard PKCS 1 v1.5 (depending on the value of &#39;oaepHashingAlgorithm&#39;). Requirement is for a 128-bit key (with 256-bit key supported as an option). Max length - 512. Type - String Hex-encoded Data (case-insensitive).
        /// </summary>
        /// <value>One-time use AES key encrypted by the Mastercard public key (as identified by &#39;publicKeyFingerprint&#39;) using the OAEP or RSA Encryption Standard PKCS 1 v1.5 (depending on the value of &#39;oaepHashingAlgorithm&#39;). Requirement is for a 128-bit key (with 256-bit key supported as an option). Max length - 512. Type - String Hex-encoded Data (case-insensitive).</value>
        /// <example>A1B2C3D4E5F611223344556678965434</example>
        [DataMember(Name = "encryptedKey", IsRequired = true, EmitDefaultValue = true)]
        public string encryptedKey { get; set; }

        /// <summary>
        /// Hashing algorithm used with the OAEP scheme. If omitted, then the RSA Encryption Standard PKCS 1 v1.5 will be used. You must use one of the following algorithms; SHA256 - Use the SHA-256 algorithm | SHA512 - Use the SHA-512 algorithm.
        /// </summary>
        /// <value>Hashing algorithm used with the OAEP scheme. If omitted, then the RSA Encryption Standard PKCS 1 v1.5 will be used. You must use one of the following algorithms; SHA256 - Use the SHA-256 algorithm | SHA512 - Use the SHA-512 algorithm.</value>
        /// <example>SHA512</example>
        [DataMember(Name = "oaepHashingAlgorithm", EmitDefaultValue = false)]
        public string oaepHashingAlgorithm { get; set; }

        /// <summary>
        /// The initialization vector used when encrypting data using the one-time use AES key. Must be exactly 16 bytes (32 character hex string) to match the block size. If not present, an IV of zero is assumed. Max length - 32 (exact). Type - String Hex-encoded Data (case-insensitive).
        /// </summary>
        /// <value>The initialization vector used when encrypting data using the one-time use AES key. Must be exactly 16 bytes (32 character hex string) to match the block size. If not present, an IV of zero is assumed. Max length - 32 (exact). Type - String Hex-encoded Data (case-insensitive).</value>
        /// <example>31323334353637383930313233343536</example>
        [DataMember(Name = "iv", EmitDefaultValue = false)]
        public string iv { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EncryptedPayloadIn {\n");
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
            // publicKeyFingerprint (string) maxLength
            if (this.publicKeyFingerprint != null && this.publicKeyFingerprint.Length > 64)
            {
                yield return new ValidationResult("Invalid value for publicKeyFingerprint, length must be less than 64.", new [] { "publicKeyFingerprint" });
            }

            // publicKeyFingerprint (string) minLength
            if (this.publicKeyFingerprint != null && this.publicKeyFingerprint.Length < 32)
            {
                yield return new ValidationResult("Invalid value for publicKeyFingerprint, length must be greater than 32.", new [] { "publicKeyFingerprint" });
            }

            // encryptedKey (string) maxLength
            if (this.encryptedKey != null && this.encryptedKey.Length > 512)
            {
                yield return new ValidationResult("Invalid value for encryptedKey, length must be less than 512.", new [] { "encryptedKey" });
            }

            // encryptedKey (string) minLength
            if (this.encryptedKey != null && this.encryptedKey.Length < 32)
            {
                yield return new ValidationResult("Invalid value for encryptedKey, length must be greater than 32.", new [] { "encryptedKey" });
            }

            // oaepHashingAlgorithm (string) maxLength
            if (this.oaepHashingAlgorithm != null && this.oaepHashingAlgorithm.Length > 6)
            {
                yield return new ValidationResult("Invalid value for oaepHashingAlgorithm, length must be less than 6.", new [] { "oaepHashingAlgorithm" });
            }

            // oaepHashingAlgorithm (string) minLength
            if (this.oaepHashingAlgorithm != null && this.oaepHashingAlgorithm.Length < 6)
            {
                yield return new ValidationResult("Invalid value for oaepHashingAlgorithm, length must be greater than 6.", new [] { "oaepHashingAlgorithm" });
            }

            // iv (string) maxLength
            if (this.iv != null && this.iv.Length > 32)
            {
                yield return new ValidationResult("Invalid value for iv, length must be less than 32.", new [] { "iv" });
            }

            // iv (string) minLength
            if (this.iv != null && this.iv.Length < 32)
            {
                yield return new ValidationResult("Invalid value for iv, length must be greater than 32.", new [] { "iv" });
            }

            yield break;
        }
    }

}
