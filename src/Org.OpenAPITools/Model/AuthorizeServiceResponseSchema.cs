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
    /// AuthorizeServiceResponseSchema
    /// </summary>
    [DataContract(Name = "AuthorizeServiceResponseSchema")]
    public partial class AuthorizeServiceResponseSchema : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorizeServiceResponseSchema" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AuthorizeServiceResponseSchema() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorizeServiceResponseSchema" /> class.
        /// </summary>
        /// <param name="responseId">The Id of the response returned. (required).</param>
        /// <param name="services">Array of services for the account that the authorization decision applies to. Must be a subset of the services in the request object. Services that are not approved for the account will be omitted. Possible values are; DIGITIZATION &#x3D; Provision the Funding Account to a device. Max length - Not applicable.  Type - Array[String]. Required..</param>
        /// <param name="decision">The authorization decision for the authorization of the requested services. Must be one of ; APPROVED &#x3D; Services request was approved, DECLINED &#x3D; Services request was declined, REQUIRE_ADDITIONAL_AUTHENTICATION &#x3D; Services request requires additional authentication to be approved. One or more ActivationMethods may be provided..</param>
        /// <param name="activationMethods">The activation methods to be used for this digitization. Return empty array if no methods are to be returned. Max length - Not applicable. Type - Array [ActivationMethod]. Optional..</param>
        /// <param name="panSequenceNumber">The pan sequence number for the card. Acceptable values are in the range 000-099..</param>
        /// <param name="issuerProductConfigId">The unique Issuer identifier assigned to the product configuration in BPMS. It is provided for the Digitization service only..</param>
        /// <param name="encryptedPayload">encryptedPayload.</param>
        /// <param name="cvcResponse">The result of the CVC2 validation performed against the value provided by the Account holder. Must be one of ; MATCH &#x3D; Valid CVC2, INVALID &#x3D; Invalid CVC2, NOT_PROCESSED &#x3D; CVC2 was not processed (issuer temporarily unavailable)..</param>
        /// <param name="avsResponse">The result of the address validation performed against the values provided by the Account holder. Must be one of ; POSTAL_DOES_NOT_MATCH &#x3D; Address matches, postal code does not, ADDRESS_AND_POSTAL_DO_NOT_MATCH &#x3D; Neither address nor postal code matches, RETRY &#x3D; Retry, system unable to process, AVS_NOT_SUPPORTED &#x3D; AVS currently not supported, NO_DATA &#x3D; No data from issuer/Authorization Platform, ADDRESS_DOES_NOT_MATCH &#x3D; W - For U.S. addresses, nine-digit postal code matches, address does not; for address outside the U.S., postal code matches, address does not, ADDRESS_AND_POSTAL_MATCH &#x3D; X - For U.S. addresses, nine-digit postal code and address matches; for addresses outside the U.S., postal code and address match; US5_ADDRESS_AND_POSTAL_MATCH &#x3D; Y - For U.S. addresses, five-digit postal code and address matches, US5_ ADDRESS_DOES_NOT_MATCH &#x3D; Z - For U.S. addresses, five-digit postal code matches, address does not..</param>
        /// <param name="tokenRequestorId">The party that requested the digitization. Type - String (Numeric). Conditional - Required if tokens are assigned by external provider, not present otherwise..</param>
        /// <param name="tcis">Terminal Capability Identifier. This parameter is defined as an array of strings designating the primary city or cities where the transit solution will operate. Max length - Not applicable. Type - Array [String]. Optional..</param>
        /// <param name="auxTcis">auxiliary Terminal Capability Identifier. This parameter is defined as an array of strings designating an additional city or cities where the transit solution will operate. Max length - Not applicable. Type - Array [String]. Optional..</param>
        /// <param name="chipDataValidationResponse">The Issuer validated chipData validation result code. Must present if issuer is validating chip data. Must be one of ; VALID &#x3D; Chip data provided is valid, INVALID &#x3D; Chip data provided is not valid, NOT_PROCESSED &#x3D; Unable to process Chip data validation (issuer temporarily unavailable)..</param>
        public AuthorizeServiceResponseSchema(string responseId = default(string), List<string> services = default(List<string>), string decision = default(string), List<ActivationMethod> activationMethods = default(List<ActivationMethod>), string panSequenceNumber = default(string), string issuerProductConfigId = default(string), EncryptedPayloadOut encryptedPayload = default(EncryptedPayloadOut), string cvcResponse = default(string), string avsResponse = default(string), string tokenRequestorId = default(string), List<string> tcis = default(List<string>), List<string> auxTcis = default(List<string>), string chipDataValidationResponse = default(string))
        {
            // to ensure "responseId" is required (not null)
            if (responseId == null)
            {
                throw new ArgumentNullException("responseId is a required property for AuthorizeServiceResponseSchema and cannot be null");
            }
            this.responseId = responseId;
            this.services = services;
            this.decision = decision;
            this.activationMethods = activationMethods;
            this.panSequenceNumber = panSequenceNumber;
            this.issuerProductConfigId = issuerProductConfigId;
            this.encryptedPayload = encryptedPayload;
            this.cvcResponse = cvcResponse;
            this.avsResponse = avsResponse;
            this.tokenRequestorId = tokenRequestorId;
            this.tcis = tcis;
            this.auxTcis = auxTcis;
            this.chipDataValidationResponse = chipDataValidationResponse;
        }

        /// <summary>
        /// The Id of the response returned.
        /// </summary>
        /// <value>The Id of the response returned.</value>
        /// <example>123456</example>
        [DataMember(Name = "responseId", IsRequired = true, EmitDefaultValue = true)]
        public string responseId { get; set; }

        /// <summary>
        /// Array of services for the account that the authorization decision applies to. Must be a subset of the services in the request object. Services that are not approved for the account will be omitted. Possible values are; DIGITIZATION &#x3D; Provision the Funding Account to a device. Max length - Not applicable.  Type - Array[String]. Required.
        /// </summary>
        /// <value>Array of services for the account that the authorization decision applies to. Must be a subset of the services in the request object. Services that are not approved for the account will be omitted. Possible values are; DIGITIZATION &#x3D; Provision the Funding Account to a device. Max length - Not applicable.  Type - Array[String]. Required.</value>
        [DataMember(Name = "services", EmitDefaultValue = false)]
        public List<string> services { get; set; }

        /// <summary>
        /// The authorization decision for the authorization of the requested services. Must be one of ; APPROVED &#x3D; Services request was approved, DECLINED &#x3D; Services request was declined, REQUIRE_ADDITIONAL_AUTHENTICATION &#x3D; Services request requires additional authentication to be approved. One or more ActivationMethods may be provided.
        /// </summary>
        /// <value>The authorization decision for the authorization of the requested services. Must be one of ; APPROVED &#x3D; Services request was approved, DECLINED &#x3D; Services request was declined, REQUIRE_ADDITIONAL_AUTHENTICATION &#x3D; Services request requires additional authentication to be approved. One or more ActivationMethods may be provided.</value>
        /// <example>REQUIRE_ADDITIONAL_AUTHENTICATION</example>
        [DataMember(Name = "decision", EmitDefaultValue = false)]
        public string decision { get; set; }

        /// <summary>
        /// The activation methods to be used for this digitization. Return empty array if no methods are to be returned. Max length - Not applicable. Type - Array [ActivationMethod]. Optional.
        /// </summary>
        /// <value>The activation methods to be used for this digitization. Return empty array if no methods are to be returned. Max length - Not applicable. Type - Array [ActivationMethod]. Optional.</value>
        [DataMember(Name = "activationMethods", EmitDefaultValue = false)]
        public List<ActivationMethod> activationMethods { get; set; }

        /// <summary>
        /// The pan sequence number for the card. Acceptable values are in the range 000-099.
        /// </summary>
        /// <value>The pan sequence number for the card. Acceptable values are in the range 000-099.</value>
        /// <example>001</example>
        [DataMember(Name = "panSequenceNumber", EmitDefaultValue = false)]
        public string panSequenceNumber { get; set; }

        /// <summary>
        /// The unique Issuer identifier assigned to the product configuration in BPMS. It is provided for the Digitization service only.
        /// </summary>
        /// <value>The unique Issuer identifier assigned to the product configuration in BPMS. It is provided for the Digitization service only.</value>
        /// <example>I1234D7890</example>
        [DataMember(Name = "issuerProductConfigId", EmitDefaultValue = false)]
        public string issuerProductConfigId { get; set; }

        /// <summary>
        /// Gets or Sets encryptedPayload
        /// </summary>
        [DataMember(Name = "encryptedPayload", EmitDefaultValue = false)]
        public EncryptedPayloadOut encryptedPayload { get; set; }

        /// <summary>
        /// The result of the CVC2 validation performed against the value provided by the Account holder. Must be one of ; MATCH &#x3D; Valid CVC2, INVALID &#x3D; Invalid CVC2, NOT_PROCESSED &#x3D; CVC2 was not processed (issuer temporarily unavailable).
        /// </summary>
        /// <value>The result of the CVC2 validation performed against the value provided by the Account holder. Must be one of ; MATCH &#x3D; Valid CVC2, INVALID &#x3D; Invalid CVC2, NOT_PROCESSED &#x3D; CVC2 was not processed (issuer temporarily unavailable).</value>
        /// <example>MATCH</example>
        [DataMember(Name = "cvcResponse", EmitDefaultValue = false)]
        public string cvcResponse { get; set; }

        /// <summary>
        /// The result of the address validation performed against the values provided by the Account holder. Must be one of ; POSTAL_DOES_NOT_MATCH &#x3D; Address matches, postal code does not, ADDRESS_AND_POSTAL_DO_NOT_MATCH &#x3D; Neither address nor postal code matches, RETRY &#x3D; Retry, system unable to process, AVS_NOT_SUPPORTED &#x3D; AVS currently not supported, NO_DATA &#x3D; No data from issuer/Authorization Platform, ADDRESS_DOES_NOT_MATCH &#x3D; W - For U.S. addresses, nine-digit postal code matches, address does not; for address outside the U.S., postal code matches, address does not, ADDRESS_AND_POSTAL_MATCH &#x3D; X - For U.S. addresses, nine-digit postal code and address matches; for addresses outside the U.S., postal code and address match; US5_ADDRESS_AND_POSTAL_MATCH &#x3D; Y - For U.S. addresses, five-digit postal code and address matches, US5_ ADDRESS_DOES_NOT_MATCH &#x3D; Z - For U.S. addresses, five-digit postal code matches, address does not.
        /// </summary>
        /// <value>The result of the address validation performed against the values provided by the Account holder. Must be one of ; POSTAL_DOES_NOT_MATCH &#x3D; Address matches, postal code does not, ADDRESS_AND_POSTAL_DO_NOT_MATCH &#x3D; Neither address nor postal code matches, RETRY &#x3D; Retry, system unable to process, AVS_NOT_SUPPORTED &#x3D; AVS currently not supported, NO_DATA &#x3D; No data from issuer/Authorization Platform, ADDRESS_DOES_NOT_MATCH &#x3D; W - For U.S. addresses, nine-digit postal code matches, address does not; for address outside the U.S., postal code matches, address does not, ADDRESS_AND_POSTAL_MATCH &#x3D; X - For U.S. addresses, nine-digit postal code and address matches; for addresses outside the U.S., postal code and address match; US5_ADDRESS_AND_POSTAL_MATCH &#x3D; Y - For U.S. addresses, five-digit postal code and address matches, US5_ ADDRESS_DOES_NOT_MATCH &#x3D; Z - For U.S. addresses, five-digit postal code matches, address does not.</value>
        /// <example>ADDRESS_AND_POSTAL_MATCH</example>
        [DataMember(Name = "avsResponse", EmitDefaultValue = false)]
        public string avsResponse { get; set; }

        /// <summary>
        /// The party that requested the digitization. Type - String (Numeric). Conditional - Required if tokens are assigned by external provider, not present otherwise.
        /// </summary>
        /// <value>The party that requested the digitization. Type - String (Numeric). Conditional - Required if tokens are assigned by external provider, not present otherwise.</value>
        /// <example>12345678901</example>
        [DataMember(Name = "tokenRequestorId", EmitDefaultValue = false)]
        public string tokenRequestorId { get; set; }

        /// <summary>
        /// Terminal Capability Identifier. This parameter is defined as an array of strings designating the primary city or cities where the transit solution will operate. Max length - Not applicable. Type - Array [String]. Optional.
        /// </summary>
        /// <value>Terminal Capability Identifier. This parameter is defined as an array of strings designating the primary city or cities where the transit solution will operate. Max length - Not applicable. Type - Array [String]. Optional.</value>
        [DataMember(Name = "tcis", EmitDefaultValue = false)]
        public List<string> tcis { get; set; }

        /// <summary>
        /// auxiliary Terminal Capability Identifier. This parameter is defined as an array of strings designating an additional city or cities where the transit solution will operate. Max length - Not applicable. Type - Array [String]. Optional.
        /// </summary>
        /// <value>auxiliary Terminal Capability Identifier. This parameter is defined as an array of strings designating an additional city or cities where the transit solution will operate. Max length - Not applicable. Type - Array [String]. Optional.</value>
        [DataMember(Name = "auxTcis", EmitDefaultValue = false)]
        public List<string> auxTcis { get; set; }

        /// <summary>
        /// The Issuer validated chipData validation result code. Must present if issuer is validating chip data. Must be one of ; VALID &#x3D; Chip data provided is valid, INVALID &#x3D; Chip data provided is not valid, NOT_PROCESSED &#x3D; Unable to process Chip data validation (issuer temporarily unavailable).
        /// </summary>
        /// <value>The Issuer validated chipData validation result code. Must present if issuer is validating chip data. Must be one of ; VALID &#x3D; Chip data provided is valid, INVALID &#x3D; Chip data provided is not valid, NOT_PROCESSED &#x3D; Unable to process Chip data validation (issuer temporarily unavailable).</value>
        /// <example>VALID</example>
        [DataMember(Name = "chipDataValidationResponse", EmitDefaultValue = false)]
        public string chipDataValidationResponse { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AuthorizeServiceResponseSchema {\n");
            sb.Append("  responseId: ").Append(responseId).Append("\n");
            sb.Append("  services: ").Append(services).Append("\n");
            sb.Append("  decision: ").Append(decision).Append("\n");
            sb.Append("  activationMethods: ").Append(activationMethods).Append("\n");
            sb.Append("  panSequenceNumber: ").Append(panSequenceNumber).Append("\n");
            sb.Append("  issuerProductConfigId: ").Append(issuerProductConfigId).Append("\n");
            sb.Append("  encryptedPayload: ").Append(encryptedPayload).Append("\n");
            sb.Append("  cvcResponse: ").Append(cvcResponse).Append("\n");
            sb.Append("  avsResponse: ").Append(avsResponse).Append("\n");
            sb.Append("  tokenRequestorId: ").Append(tokenRequestorId).Append("\n");
            sb.Append("  tcis: ").Append(tcis).Append("\n");
            sb.Append("  auxTcis: ").Append(auxTcis).Append("\n");
            sb.Append("  chipDataValidationResponse: ").Append(chipDataValidationResponse).Append("\n");
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

            // decision (string) maxLength
            if (this.decision != null && this.decision.Length > 64)
            {
                yield return new ValidationResult("Invalid value for decision, length must be less than 64.", new [] { "decision" });
            }

            // decision (string) minLength
            if (this.decision != null && this.decision.Length < 1)
            {
                yield return new ValidationResult("Invalid value for decision, length must be greater than 1.", new [] { "decision" });
            }

            // panSequenceNumber (string) maxLength
            if (this.panSequenceNumber != null && this.panSequenceNumber.Length > 3)
            {
                yield return new ValidationResult("Invalid value for panSequenceNumber, length must be less than 3.", new [] { "panSequenceNumber" });
            }

            // panSequenceNumber (string) minLength
            if (this.panSequenceNumber != null && this.panSequenceNumber.Length < 3)
            {
                yield return new ValidationResult("Invalid value for panSequenceNumber, length must be greater than 3.", new [] { "panSequenceNumber" });
            }

            // issuerProductConfigId (string) maxLength
            if (this.issuerProductConfigId != null && this.issuerProductConfigId.Length > 10)
            {
                yield return new ValidationResult("Invalid value for issuerProductConfigId, length must be less than 10.", new [] { "issuerProductConfigId" });
            }

            // issuerProductConfigId (string) minLength
            if (this.issuerProductConfigId != null && this.issuerProductConfigId.Length < 1)
            {
                yield return new ValidationResult("Invalid value for issuerProductConfigId, length must be greater than 1.", new [] { "issuerProductConfigId" });
            }

            // cvcResponse (string) maxLength
            if (this.cvcResponse != null && this.cvcResponse.Length > 32)
            {
                yield return new ValidationResult("Invalid value for cvcResponse, length must be less than 32.", new [] { "cvcResponse" });
            }

            // cvcResponse (string) minLength
            if (this.cvcResponse != null && this.cvcResponse.Length < 1)
            {
                yield return new ValidationResult("Invalid value for cvcResponse, length must be greater than 1.", new [] { "cvcResponse" });
            }

            // avsResponse (string) maxLength
            if (this.avsResponse != null && this.avsResponse.Length > 32)
            {
                yield return new ValidationResult("Invalid value for avsResponse, length must be less than 32.", new [] { "avsResponse" });
            }

            // avsResponse (string) minLength
            if (this.avsResponse != null && this.avsResponse.Length < 1)
            {
                yield return new ValidationResult("Invalid value for avsResponse, length must be greater than 1.", new [] { "avsResponse" });
            }

            // tokenRequestorId (string) maxLength
            if (this.tokenRequestorId != null && this.tokenRequestorId.Length > 11)
            {
                yield return new ValidationResult("Invalid value for tokenRequestorId, length must be less than 11.", new [] { "tokenRequestorId" });
            }

            // tokenRequestorId (string) minLength
            if (this.tokenRequestorId != null && this.tokenRequestorId.Length < 11)
            {
                yield return new ValidationResult("Invalid value for tokenRequestorId, length must be greater than 11.", new [] { "tokenRequestorId" });
            }

            // chipDataValidationResponse (string) maxLength
            if (this.chipDataValidationResponse != null && this.chipDataValidationResponse.Length > 32)
            {
                yield return new ValidationResult("Invalid value for chipDataValidationResponse, length must be less than 32.", new [] { "chipDataValidationResponse" });
            }

            // chipDataValidationResponse (string) minLength
            if (this.chipDataValidationResponse != null && this.chipDataValidationResponse.Length < 1)
            {
                yield return new ValidationResult("Invalid value for chipDataValidationResponse, length must be greater than 1.", new [] { "chipDataValidationResponse" });
            }

            yield break;
        }
    }

}
