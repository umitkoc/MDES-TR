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
    /// RequestActivationMethodsRequestSchema
    /// </summary>
    [DataContract(Name = "requestActivationMethodsRequestSchema")]
    public partial class RequestActivationMethodsRequestSchema : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RequestActivationMethodsRequestSchema" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RequestActivationMethodsRequestSchema() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RequestActivationMethodsRequestSchema" /> class.
        /// </summary>
        /// <param name="requestId">The id of the request submitted. Max length - 64 (required).</param>
        /// <param name="services">Array of services that are being requested for the account. Must be one of ; DIGITIZATION &#x3D; Provision the Funding Account to a device. Max length - Not applicable. Type - Array[String]. (required).</param>
        /// <param name="fundingAccountInfo">fundingAccountInfo (required).</param>
        /// <param name="correlationId">Value linking pre-digitization messages generated during provisioning. (required).</param>
        /// <param name="tokenRequestorId">The party that requested the digitization. Type - String (Numeric). Conditional - Required if tokens are assigned by MDES..</param>
        /// <param name="walletId">The identifier of the Wallet Provider who requested the digitization. Only present when the token is provided to a Wallet Provider..</param>
        /// <param name="paymentAppInstanceId">The identifier of the payment App instance within a device that will be provisioned with a token. Only present when supplied by a Wallet Provider..</param>
        /// <param name="accountIdHash">SHA-256 hash of the Account holder&#39;s account ID with the Payment App Provider. Typically expected to be an email address. Type - String (Alpha-Numeric) Hex-encoded data (case-insensitive)..</param>
        /// <param name="mobileNumberSuffix">The last few digits (typically four) of the device&#39;s mobile phone number..</param>
        /// <param name="tokenType">The type of token requested for this digitization. Valid values are EMBEDDED_SE &#x3D; Embedded Secure Element | CLOUD &#x3D; Mastercard Cloud-Based Payments | STATIC &#x3D; Static token. (required).</param>
        /// <param name="reasonCodes">The reason the account holder is being authenticated. New reason codes can be added at any time and should not result in a failure. Possible push methods are:   * ADD_CARD:  The account holder is being authenticated in order to verify account ownership at the time of adding a card in token requestor system (Token might be in active state)   * VERIFY_ACCOUNT:  The account holder is being authenticated in order to verify account ownership to use a service   * OTHER:  The account holder is being authenticated for a reason not enumerated in this list. Conditional - Only present for Conset Service .</param>
        /// <param name="consumerFacingEntityName">Entity name that account holder recognizes as being where they store their PAN (wallets, merchants, commerce platforms…)..</param>
        public RequestActivationMethodsRequestSchema(string requestId = default(string), List<string> services = default(List<string>), FundingAccountInfoSchema1 fundingAccountInfo = default(FundingAccountInfoSchema1), string correlationId = default(string), string tokenRequestorId = default(string), string walletId = default(string), string paymentAppInstanceId = default(string), string accountIdHash = default(string), string mobileNumberSuffix = default(string), string tokenType = default(string), List<string> reasonCodes = default(List<string>), string consumerFacingEntityName = default(string))
        {
            // to ensure "requestId" is required (not null)
            if (requestId == null)
            {
                throw new ArgumentNullException("requestId is a required property for RequestActivationMethodsRequestSchema and cannot be null");
            }
            this.requestId = requestId;
            // to ensure "services" is required (not null)
            if (services == null)
            {
                throw new ArgumentNullException("services is a required property for RequestActivationMethodsRequestSchema and cannot be null");
            }
            this.services = services;
            // to ensure "fundingAccountInfo" is required (not null)
            if (fundingAccountInfo == null)
            {
                throw new ArgumentNullException("fundingAccountInfo is a required property for RequestActivationMethodsRequestSchema and cannot be null");
            }
            this.fundingAccountInfo = fundingAccountInfo;
            // to ensure "correlationId" is required (not null)
            if (correlationId == null)
            {
                throw new ArgumentNullException("correlationId is a required property for RequestActivationMethodsRequestSchema and cannot be null");
            }
            this.correlationId = correlationId;
            // to ensure "tokenType" is required (not null)
            if (tokenType == null)
            {
                throw new ArgumentNullException("tokenType is a required property for RequestActivationMethodsRequestSchema and cannot be null");
            }
            this.tokenType = tokenType;
            this.tokenRequestorId = tokenRequestorId;
            this.walletId = walletId;
            this.paymentAppInstanceId = paymentAppInstanceId;
            this.accountIdHash = accountIdHash;
            this.mobileNumberSuffix = mobileNumberSuffix;
            this.reasonCodes = reasonCodes;
            this.consumerFacingEntityName = consumerFacingEntityName;
        }

        /// <summary>
        /// The id of the request submitted. Max length - 64
        /// </summary>
        /// <value>The id of the request submitted. Max length - 64</value>
        /// <example>123456</example>
        [DataMember(Name = "requestId", IsRequired = true, EmitDefaultValue = true)]
        public string requestId { get; set; }

        /// <summary>
        /// Array of services that are being requested for the account. Must be one of ; DIGITIZATION &#x3D; Provision the Funding Account to a device. Max length - Not applicable. Type - Array[String].
        /// </summary>
        /// <value>Array of services that are being requested for the account. Must be one of ; DIGITIZATION &#x3D; Provision the Funding Account to a device. Max length - Not applicable. Type - Array[String].</value>
        [DataMember(Name = "services", IsRequired = true, EmitDefaultValue = true)]
        public List<string> services { get; set; }

        /// <summary>
        /// Gets or Sets fundingAccountInfo
        /// </summary>
        [DataMember(Name = "fundingAccountInfo", IsRequired = true, EmitDefaultValue = true)]
        public FundingAccountInfoSchema1 fundingAccountInfo { get; set; }

        /// <summary>
        /// Value linking pre-digitization messages generated during provisioning.
        /// </summary>
        /// <value>Value linking pre-digitization messages generated during provisioning.</value>
        /// <example>D98765432104</example>
        [DataMember(Name = "correlationId", IsRequired = true, EmitDefaultValue = true)]
        public string correlationId { get; set; }

        /// <summary>
        /// The party that requested the digitization. Type - String (Numeric). Conditional - Required if tokens are assigned by MDES.
        /// </summary>
        /// <value>The party that requested the digitization. Type - String (Numeric). Conditional - Required if tokens are assigned by MDES.</value>
        /// <example>12345678901</example>
        [DataMember(Name = "tokenRequestorId", EmitDefaultValue = false)]
        public string tokenRequestorId { get; set; }

        /// <summary>
        /// The identifier of the Wallet Provider who requested the digitization. Only present when the token is provided to a Wallet Provider.
        /// </summary>
        /// <value>The identifier of the Wallet Provider who requested the digitization. Only present when the token is provided to a Wallet Provider.</value>
        /// <example>123</example>
        [DataMember(Name = "walletId", EmitDefaultValue = false)]
        public string walletId { get; set; }

        /// <summary>
        /// The identifier of the payment App instance within a device that will be provisioned with a token. Only present when supplied by a Wallet Provider.
        /// </summary>
        /// <value>The identifier of the payment App instance within a device that will be provisioned with a token. Only present when supplied by a Wallet Provider.</value>
        /// <example>1b24f24a24ba98e27d43e345b532a245e4723d7a9c4f624e</example>
        [DataMember(Name = "paymentAppInstanceId", EmitDefaultValue = false)]
        public string paymentAppInstanceId { get; set; }

        /// <summary>
        /// SHA-256 hash of the Account holder&#39;s account ID with the Payment App Provider. Typically expected to be an email address. Type - String (Alpha-Numeric) Hex-encoded data (case-insensitive).
        /// </summary>
        /// <value>SHA-256 hash of the Account holder&#39;s account ID with the Payment App Provider. Typically expected to be an email address. Type - String (Alpha-Numeric) Hex-encoded data (case-insensitive).</value>
        /// <example>5ae9c9890b326bd23bfa9db9672298ae3b10a9388e56ec17a001e191f24572aa</example>
        [DataMember(Name = "accountIdHash", EmitDefaultValue = false)]
        public string accountIdHash { get; set; }

        /// <summary>
        /// The last few digits (typically four) of the device&#39;s mobile phone number.
        /// </summary>
        /// <value>The last few digits (typically four) of the device&#39;s mobile phone number.</value>
        /// <example>1234</example>
        [DataMember(Name = "mobileNumberSuffix", EmitDefaultValue = false)]
        public string mobileNumberSuffix { get; set; }

        /// <summary>
        /// The type of token requested for this digitization. Valid values are EMBEDDED_SE &#x3D; Embedded Secure Element | CLOUD &#x3D; Mastercard Cloud-Based Payments | STATIC &#x3D; Static token.
        /// </summary>
        /// <value>The type of token requested for this digitization. Valid values are EMBEDDED_SE &#x3D; Embedded Secure Element | CLOUD &#x3D; Mastercard Cloud-Based Payments | STATIC &#x3D; Static token.</value>
        /// <example>CLOUD</example>
        [DataMember(Name = "tokenType", IsRequired = true, EmitDefaultValue = true)]
        public string tokenType { get; set; }

        /// <summary>
        /// The reason the account holder is being authenticated. New reason codes can be added at any time and should not result in a failure. Possible push methods are:   * ADD_CARD:  The account holder is being authenticated in order to verify account ownership at the time of adding a card in token requestor system (Token might be in active state)   * VERIFY_ACCOUNT:  The account holder is being authenticated in order to verify account ownership to use a service   * OTHER:  The account holder is being authenticated for a reason not enumerated in this list. Conditional - Only present for Conset Service 
        /// </summary>
        /// <value>The reason the account holder is being authenticated. New reason codes can be added at any time and should not result in a failure. Possible push methods are:   * ADD_CARD:  The account holder is being authenticated in order to verify account ownership at the time of adding a card in token requestor system (Token might be in active state)   * VERIFY_ACCOUNT:  The account holder is being authenticated in order to verify account ownership to use a service   * OTHER:  The account holder is being authenticated for a reason not enumerated in this list. Conditional - Only present for Conset Service </value>
        [DataMember(Name = "reasonCodes", EmitDefaultValue = false)]
        public List<string> reasonCodes { get; set; }

        /// <summary>
        /// Entity name that account holder recognizes as being where they store their PAN (wallets, merchants, commerce platforms…).
        /// </summary>
        /// <value>Entity name that account holder recognizes as being where they store their PAN (wallets, merchants, commerce platforms…).</value>
        /// <example>My Merchant</example>
        [DataMember(Name = "consumerFacingEntityName", EmitDefaultValue = false)]
        public string consumerFacingEntityName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RequestActivationMethodsRequestSchema {\n");
            sb.Append("  requestId: ").Append(requestId).Append("\n");
            sb.Append("  services: ").Append(services).Append("\n");
            sb.Append("  fundingAccountInfo: ").Append(fundingAccountInfo).Append("\n");
            sb.Append("  correlationId: ").Append(correlationId).Append("\n");
            sb.Append("  tokenRequestorId: ").Append(tokenRequestorId).Append("\n");
            sb.Append("  walletId: ").Append(walletId).Append("\n");
            sb.Append("  paymentAppInstanceId: ").Append(paymentAppInstanceId).Append("\n");
            sb.Append("  accountIdHash: ").Append(accountIdHash).Append("\n");
            sb.Append("  mobileNumberSuffix: ").Append(mobileNumberSuffix).Append("\n");
            sb.Append("  tokenType: ").Append(tokenType).Append("\n");
            sb.Append("  reasonCodes: ").Append(reasonCodes).Append("\n");
            sb.Append("  consumerFacingEntityName: ").Append(consumerFacingEntityName).Append("\n");
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

            // correlationId (string) maxLength
            if (this.correlationId != null && this.correlationId.Length > 14)
            {
                yield return new ValidationResult("Invalid value for correlationId, length must be less than 14.", new [] { "correlationId" });
            }

            // correlationId (string) minLength
            if (this.correlationId != null && this.correlationId.Length < 1)
            {
                yield return new ValidationResult("Invalid value for correlationId, length must be greater than 1.", new [] { "correlationId" });
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

            // walletId (string) maxLength
            if (this.walletId != null && this.walletId.Length > 3)
            {
                yield return new ValidationResult("Invalid value for walletId, length must be less than 3.", new [] { "walletId" });
            }

            // walletId (string) minLength
            if (this.walletId != null && this.walletId.Length < 1)
            {
                yield return new ValidationResult("Invalid value for walletId, length must be greater than 1.", new [] { "walletId" });
            }

            // paymentAppInstanceId (string) maxLength
            if (this.paymentAppInstanceId != null && this.paymentAppInstanceId.Length > 48)
            {
                yield return new ValidationResult("Invalid value for paymentAppInstanceId, length must be less than 48.", new [] { "paymentAppInstanceId" });
            }

            // paymentAppInstanceId (string) minLength
            if (this.paymentAppInstanceId != null && this.paymentAppInstanceId.Length < 1)
            {
                yield return new ValidationResult("Invalid value for paymentAppInstanceId, length must be greater than 1.", new [] { "paymentAppInstanceId" });
            }

            // accountIdHash (string) maxLength
            if (this.accountIdHash != null && this.accountIdHash.Length > 64)
            {
                yield return new ValidationResult("Invalid value for accountIdHash, length must be less than 64.", new [] { "accountIdHash" });
            }

            // accountIdHash (string) minLength
            if (this.accountIdHash != null && this.accountIdHash.Length < 1)
            {
                yield return new ValidationResult("Invalid value for accountIdHash, length must be greater than 1.", new [] { "accountIdHash" });
            }

            // mobileNumberSuffix (string) maxLength
            if (this.mobileNumberSuffix != null && this.mobileNumberSuffix.Length > 32)
            {
                yield return new ValidationResult("Invalid value for mobileNumberSuffix, length must be less than 32.", new [] { "mobileNumberSuffix" });
            }

            // mobileNumberSuffix (string) minLength
            if (this.mobileNumberSuffix != null && this.mobileNumberSuffix.Length < 4)
            {
                yield return new ValidationResult("Invalid value for mobileNumberSuffix, length must be greater than 4.", new [] { "mobileNumberSuffix" });
            }

            // tokenType (string) maxLength
            if (this.tokenType != null && this.tokenType.Length > 16)
            {
                yield return new ValidationResult("Invalid value for tokenType, length must be less than 16.", new [] { "tokenType" });
            }

            // tokenType (string) minLength
            if (this.tokenType != null && this.tokenType.Length < 1)
            {
                yield return new ValidationResult("Invalid value for tokenType, length must be greater than 1.", new [] { "tokenType" });
            }

            // consumerFacingEntityName (string) maxLength
            if (this.consumerFacingEntityName != null && this.consumerFacingEntityName.Length > 100)
            {
                yield return new ValidationResult("Invalid value for consumerFacingEntityName, length must be less than 100.", new [] { "consumerFacingEntityName" });
            }

            // consumerFacingEntityName (string) minLength
            if (this.consumerFacingEntityName != null && this.consumerFacingEntityName.Length < 1)
            {
                yield return new ValidationResult("Invalid value for consumerFacingEntityName, length must be greater than 1.", new [] { "consumerFacingEntityName" });
            }

            yield break;
        }
    }

}
