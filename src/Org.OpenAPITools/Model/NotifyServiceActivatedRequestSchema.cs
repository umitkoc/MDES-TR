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
    /// NotifyServiceActivatedRequestSchema
    /// </summary>
    [DataContract(Name = "NotifyServiceActivatedRequestSchema")]
    public partial class NotifyServiceActivatedRequestSchema : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NotifyServiceActivatedRequestSchema" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NotifyServiceActivatedRequestSchema() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NotifyServiceActivatedRequestSchema" /> class.
        /// </summary>
        /// <param name="requestId">The id of the request submitted. Max length - 64 (required).</param>
        /// <param name="services">Array of services that are being requested for the account. Must be one of ; DIGITIZATION &#x3D; Provision the Funding Account to a device. Max length - Not applicable. Type - Array [String]. (required).</param>
        /// <param name="fundingAccountInfo">fundingAccountInfo (required).</param>
        /// <param name="deviceInfo">deviceInfo.</param>
        /// <param name="correlationId">Value linking pre-digitization messages generated during provisioning. (required).</param>
        /// <param name="tokenRequestorId">The party that requested the digitization. Type - String (Numeric). (required).</param>
        /// <param name="walletId">The identifier of the Wallet Provider who requested the digitization. Only present when the token is provided to a Wallet Provider..</param>
        /// <param name="paymentAppInstanceId">The identifier of the Payment App instance within a device that will be provisioned with a token. Only present when supplied by a Wallet Provider. Max length - 48. Type - String..</param>
        /// <param name="tokenType">The type of token requested for this digitization. Valid values are - EMBEDDED_SE &#x3D; Embedded Secure Element | CLOUD &#x3D; Mastercard Cloud-Based Payments | STATIC &#x3D; Static token. (required).</param>
        /// <param name="secureElementId">The identifier of the Secure Element to be provisioned with the token. Present only when the token is provisioned to a Secure Element and when provided by the Wallet Provider..</param>
        /// <param name="accountPanSuffix">The last few digits (typically four) of the Account PAN being digitized. (required).</param>
        /// <param name="serviceRequestDateTime">The date and time the service for the PAN was requested. Expressed in ISO 8601 extended format as one of the following - YYYY-MM-DDThh:mm:ss[ .sss ]Z, YYYY-MM-DDThh:mm:ss[ .sss ]±hh:mm . Where [ .sss ] is optional and can be 1 to 3 digits. (required).</param>
        /// <param name="termsAndConditionsAssetId">The Terms and Conditions as presented to and accepted by the Account holder..</param>
        /// <param name="termsAndConditionsAcceptedTimestamp">The date and time the Terms and Conditions were accepted by the Account holder. Expressed in ISO 8601 extended format as one of the following - YYYY-MM-DDThh:mm:ss[ .sss ]Z, YYYY-MM-DDThh:mm:ss[ .sss ]±hh:mm . Where [ .sss ] is optional and can be 1 to 3 digits..</param>
        /// <param name="productConfigurationId">Freeform identifier for the product configuration as assigned by the Issuer..</param>
        /// <param name="consumerLanguage">Language preference selected by the consumer. Formatted as an ISO-639-1 two-letter language code..</param>
        /// <param name="decision">The authorization decision for the service request. Must be one of - APPROVED &#x3D; Service request was approved, REQUIRE_ADDITIONAL_AUTHENTICATION &#x3D; Service request requires additional authentication to be approved. One or more Activation Methods will be provided. (required).</param>
        /// <param name="decisionMadeBy">The process that determined the final authorization decision for the request. Must be one of - * ELIGIBILITY_REQUEST &#x3D; The decision was made by the eligibility request to the Issuer * AUTHORIZATION_REQUEST &#x3D; The decision was made by the authorization request to the Issuer * RULES &#x3D; The decision was made by the rule engine..</param>
        /// <param name="tokenActivatedDateTime">Expressed in ISO 8601 extended format as one of the following - YYYY-MM-DDThh:mm:ss[ .sss ]Z, YYYY-MM-DDThh:mm:ss[ .sss ]±hh:mm, Where [ .sss ] is optional and can be 1 to 3 digits. (required).</param>
        /// <param name="numberOfActivationAttempts">The number of times an Activation Code was received to activate the token. Max length - 1. Type - Number..</param>
        /// <param name="numberOfActiveTokens">The number of active tokens for the Funding Account. Valid values are 0 to 99. A value of 99 means there are 99 or more active tokens. Tokens that have been deleted from the wallet are excluded from the count..</param>
        /// <param name="tokenAssuranceLevel">The assurance level assigned to the token. Type - Number..</param>
        /// <param name="consumerFacingEntityName">Entity name that account holder recognizes as being where they store their PAN (wallets, merchants, commerce platforms…)..</param>
        public NotifyServiceActivatedRequestSchema(string requestId = default(string), List<string> services = default(List<string>), FundingAccountInfoSchema2 fundingAccountInfo = default(FundingAccountInfoSchema2), DeviceInfo deviceInfo = default(DeviceInfo), string correlationId = default(string), string tokenRequestorId = default(string), string walletId = default(string), string paymentAppInstanceId = default(string), string tokenType = default(string), string secureElementId = default(string), string accountPanSuffix = default(string), string serviceRequestDateTime = default(string), string termsAndConditionsAssetId = default(string), string termsAndConditionsAcceptedTimestamp = default(string), string productConfigurationId = default(string), string consumerLanguage = default(string), string decision = default(string), string decisionMadeBy = default(string), string tokenActivatedDateTime = default(string), int numberOfActivationAttempts = default(int), int numberOfActiveTokens = default(int), int tokenAssuranceLevel = default(int), string consumerFacingEntityName = default(string))
        {
            // to ensure "requestId" is required (not null)
            if (requestId == null)
            {
                throw new ArgumentNullException("requestId is a required property for NotifyServiceActivatedRequestSchema and cannot be null");
            }
            this.requestId = requestId;
            // to ensure "services" is required (not null)
            if (services == null)
            {
                throw new ArgumentNullException("services is a required property for NotifyServiceActivatedRequestSchema and cannot be null");
            }
            this.services = services;
            // to ensure "fundingAccountInfo" is required (not null)
            if (fundingAccountInfo == null)
            {
                throw new ArgumentNullException("fundingAccountInfo is a required property for NotifyServiceActivatedRequestSchema and cannot be null");
            }
            this.fundingAccountInfo = fundingAccountInfo;
            // to ensure "correlationId" is required (not null)
            if (correlationId == null)
            {
                throw new ArgumentNullException("correlationId is a required property for NotifyServiceActivatedRequestSchema and cannot be null");
            }
            this.correlationId = correlationId;
            // to ensure "tokenRequestorId" is required (not null)
            if (tokenRequestorId == null)
            {
                throw new ArgumentNullException("tokenRequestorId is a required property for NotifyServiceActivatedRequestSchema and cannot be null");
            }
            this.tokenRequestorId = tokenRequestorId;
            // to ensure "tokenType" is required (not null)
            if (tokenType == null)
            {
                throw new ArgumentNullException("tokenType is a required property for NotifyServiceActivatedRequestSchema and cannot be null");
            }
            this.tokenType = tokenType;
            // to ensure "accountPanSuffix" is required (not null)
            if (accountPanSuffix == null)
            {
                throw new ArgumentNullException("accountPanSuffix is a required property for NotifyServiceActivatedRequestSchema and cannot be null");
            }
            this.accountPanSuffix = accountPanSuffix;
            // to ensure "serviceRequestDateTime" is required (not null)
            if (serviceRequestDateTime == null)
            {
                throw new ArgumentNullException("serviceRequestDateTime is a required property for NotifyServiceActivatedRequestSchema and cannot be null");
            }
            this.serviceRequestDateTime = serviceRequestDateTime;
            // to ensure "decision" is required (not null)
            if (decision == null)
            {
                throw new ArgumentNullException("decision is a required property for NotifyServiceActivatedRequestSchema and cannot be null");
            }
            this.decision = decision;
            // to ensure "tokenActivatedDateTime" is required (not null)
            if (tokenActivatedDateTime == null)
            {
                throw new ArgumentNullException("tokenActivatedDateTime is a required property for NotifyServiceActivatedRequestSchema and cannot be null");
            }
            this.tokenActivatedDateTime = tokenActivatedDateTime;
            this.deviceInfo = deviceInfo;
            this.walletId = walletId;
            this.paymentAppInstanceId = paymentAppInstanceId;
            this.secureElementId = secureElementId;
            this.termsAndConditionsAssetId = termsAndConditionsAssetId;
            this.termsAndConditionsAcceptedTimestamp = termsAndConditionsAcceptedTimestamp;
            this.productConfigurationId = productConfigurationId;
            this.consumerLanguage = consumerLanguage;
            this.decisionMadeBy = decisionMadeBy;
            this.numberOfActivationAttempts = numberOfActivationAttempts;
            this.numberOfActiveTokens = numberOfActiveTokens;
            this.tokenAssuranceLevel = tokenAssuranceLevel;
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
        /// Array of services that are being requested for the account. Must be one of ; DIGITIZATION &#x3D; Provision the Funding Account to a device. Max length - Not applicable. Type - Array [String].
        /// </summary>
        /// <value>Array of services that are being requested for the account. Must be one of ; DIGITIZATION &#x3D; Provision the Funding Account to a device. Max length - Not applicable. Type - Array [String].</value>
        [DataMember(Name = "services", IsRequired = true, EmitDefaultValue = true)]
        public List<string> services { get; set; }

        /// <summary>
        /// Gets or Sets fundingAccountInfo
        /// </summary>
        [DataMember(Name = "fundingAccountInfo", IsRequired = true, EmitDefaultValue = true)]
        public FundingAccountInfoSchema2 fundingAccountInfo { get; set; }

        /// <summary>
        /// Gets or Sets deviceInfo
        /// </summary>
        [DataMember(Name = "deviceInfo", EmitDefaultValue = false)]
        public DeviceInfo deviceInfo { get; set; }

        /// <summary>
        /// Value linking pre-digitization messages generated during provisioning.
        /// </summary>
        /// <value>Value linking pre-digitization messages generated during provisioning.</value>
        /// <example>D98765432104</example>
        [DataMember(Name = "correlationId", IsRequired = true, EmitDefaultValue = true)]
        public string correlationId { get; set; }

        /// <summary>
        /// The party that requested the digitization. Type - String (Numeric).
        /// </summary>
        /// <value>The party that requested the digitization. Type - String (Numeric).</value>
        /// <example>12345678901</example>
        [DataMember(Name = "tokenRequestorId", IsRequired = true, EmitDefaultValue = true)]
        public string tokenRequestorId { get; set; }

        /// <summary>
        /// The identifier of the Wallet Provider who requested the digitization. Only present when the token is provided to a Wallet Provider.
        /// </summary>
        /// <value>The identifier of the Wallet Provider who requested the digitization. Only present when the token is provided to a Wallet Provider.</value>
        /// <example>123</example>
        [DataMember(Name = "walletId", EmitDefaultValue = false)]
        public string walletId { get; set; }

        /// <summary>
        /// The identifier of the Payment App instance within a device that will be provisioned with a token. Only present when supplied by a Wallet Provider. Max length - 48. Type - String.
        /// </summary>
        /// <value>The identifier of the Payment App instance within a device that will be provisioned with a token. Only present when supplied by a Wallet Provider. Max length - 48. Type - String.</value>
        /// <example>1b24f24a24ba98e27d43e345b532a245e4723d7a9c4f624e</example>
        [DataMember(Name = "paymentAppInstanceId", EmitDefaultValue = false)]
        public string paymentAppInstanceId { get; set; }

        /// <summary>
        /// The type of token requested for this digitization. Valid values are - EMBEDDED_SE &#x3D; Embedded Secure Element | CLOUD &#x3D; Mastercard Cloud-Based Payments | STATIC &#x3D; Static token.
        /// </summary>
        /// <value>The type of token requested for this digitization. Valid values are - EMBEDDED_SE &#x3D; Embedded Secure Element | CLOUD &#x3D; Mastercard Cloud-Based Payments | STATIC &#x3D; Static token.</value>
        /// <example>CLOUD</example>
        [DataMember(Name = "tokenType", IsRequired = true, EmitDefaultValue = true)]
        public string tokenType { get; set; }

        /// <summary>
        /// The identifier of the Secure Element to be provisioned with the token. Present only when the token is provisioned to a Secure Element and when provided by the Wallet Provider.
        /// </summary>
        /// <value>The identifier of the Secure Element to be provisioned with the token. Present only when the token is provisioned to a Secure Element and when provided by the Wallet Provider.</value>
        /// <example>1b24f24a24ba98e27d43e345b532a245e4723d7a9c4f624e93452c</example>
        [DataMember(Name = "secureElementId", EmitDefaultValue = false)]
        public string secureElementId { get; set; }

        /// <summary>
        /// The last few digits (typically four) of the Account PAN being digitized.
        /// </summary>
        /// <value>The last few digits (typically four) of the Account PAN being digitized.</value>
        /// <example>1234</example>
        [DataMember(Name = "accountPanSuffix", IsRequired = true, EmitDefaultValue = true)]
        public string accountPanSuffix { get; set; }

        /// <summary>
        /// The date and time the service for the PAN was requested. Expressed in ISO 8601 extended format as one of the following - YYYY-MM-DDThh:mm:ss[ .sss ]Z, YYYY-MM-DDThh:mm:ss[ .sss ]±hh:mm . Where [ .sss ] is optional and can be 1 to 3 digits.
        /// </summary>
        /// <value>The date and time the service for the PAN was requested. Expressed in ISO 8601 extended format as one of the following - YYYY-MM-DDThh:mm:ss[ .sss ]Z, YYYY-MM-DDThh:mm:ss[ .sss ]±hh:mm . Where [ .sss ] is optional and can be 1 to 3 digits.</value>
        /// <example>2023-07-04T12:08:56.123-07:00</example>
        [DataMember(Name = "serviceRequestDateTime", IsRequired = true, EmitDefaultValue = true)]
        public string serviceRequestDateTime { get; set; }

        /// <summary>
        /// The Terms and Conditions as presented to and accepted by the Account holder.
        /// </summary>
        /// <value>The Terms and Conditions as presented to and accepted by the Account holder.</value>
        /// <example>a9f027e5-629d-11e3-949a-0800200c9a66</example>
        [DataMember(Name = "termsAndConditionsAssetId", EmitDefaultValue = false)]
        public string termsAndConditionsAssetId { get; set; }

        /// <summary>
        /// The date and time the Terms and Conditions were accepted by the Account holder. Expressed in ISO 8601 extended format as one of the following - YYYY-MM-DDThh:mm:ss[ .sss ]Z, YYYY-MM-DDThh:mm:ss[ .sss ]±hh:mm . Where [ .sss ] is optional and can be 1 to 3 digits.
        /// </summary>
        /// <value>The date and time the Terms and Conditions were accepted by the Account holder. Expressed in ISO 8601 extended format as one of the following - YYYY-MM-DDThh:mm:ss[ .sss ]Z, YYYY-MM-DDThh:mm:ss[ .sss ]±hh:mm . Where [ .sss ] is optional and can be 1 to 3 digits.</value>
        /// <example>2023-07-04T12:09:56.123-07:00</example>
        [DataMember(Name = "termsAndConditionsAcceptedTimestamp", EmitDefaultValue = false)]
        public string termsAndConditionsAcceptedTimestamp { get; set; }

        /// <summary>
        /// Freeform identifier for the product configuration as assigned by the Issuer.
        /// </summary>
        /// <value>Freeform identifier for the product configuration as assigned by the Issuer.</value>
        /// <example>1234</example>
        [DataMember(Name = "productConfigurationId", EmitDefaultValue = false)]
        public string productConfigurationId { get; set; }

        /// <summary>
        /// Language preference selected by the consumer. Formatted as an ISO-639-1 two-letter language code.
        /// </summary>
        /// <value>Language preference selected by the consumer. Formatted as an ISO-639-1 two-letter language code.</value>
        /// <example>en</example>
        [DataMember(Name = "consumerLanguage", EmitDefaultValue = false)]
        public string consumerLanguage { get; set; }

        /// <summary>
        /// The authorization decision for the service request. Must be one of - APPROVED &#x3D; Service request was approved, REQUIRE_ADDITIONAL_AUTHENTICATION &#x3D; Service request requires additional authentication to be approved. One or more Activation Methods will be provided.
        /// </summary>
        /// <value>The authorization decision for the service request. Must be one of - APPROVED &#x3D; Service request was approved, REQUIRE_ADDITIONAL_AUTHENTICATION &#x3D; Service request requires additional authentication to be approved. One or more Activation Methods will be provided.</value>
        /// <example>REQUIRE_ADDITIONAL_AUTHENTICATION</example>
        [DataMember(Name = "decision", IsRequired = true, EmitDefaultValue = true)]
        public string decision { get; set; }

        /// <summary>
        /// The process that determined the final authorization decision for the request. Must be one of - * ELIGIBILITY_REQUEST &#x3D; The decision was made by the eligibility request to the Issuer * AUTHORIZATION_REQUEST &#x3D; The decision was made by the authorization request to the Issuer * RULES &#x3D; The decision was made by the rule engine.
        /// </summary>
        /// <value>The process that determined the final authorization decision for the request. Must be one of - * ELIGIBILITY_REQUEST &#x3D; The decision was made by the eligibility request to the Issuer * AUTHORIZATION_REQUEST &#x3D; The decision was made by the authorization request to the Issuer * RULES &#x3D; The decision was made by the rule engine.</value>
        /// <example>RULES</example>
        [DataMember(Name = "decisionMadeBy", EmitDefaultValue = false)]
        public string decisionMadeBy { get; set; }

        /// <summary>
        /// Expressed in ISO 8601 extended format as one of the following - YYYY-MM-DDThh:mm:ss[ .sss ]Z, YYYY-MM-DDThh:mm:ss[ .sss ]±hh:mm, Where [ .sss ] is optional and can be 1 to 3 digits.
        /// </summary>
        /// <value>Expressed in ISO 8601 extended format as one of the following - YYYY-MM-DDThh:mm:ss[ .sss ]Z, YYYY-MM-DDThh:mm:ss[ .sss ]±hh:mm, Where [ .sss ] is optional and can be 1 to 3 digits.</value>
        /// <example>2026-07-04T12:09:57.123-07:00</example>
        [DataMember(Name = "tokenActivatedDateTime", IsRequired = true, EmitDefaultValue = true)]
        public string tokenActivatedDateTime { get; set; }

        /// <summary>
        /// The number of times an Activation Code was received to activate the token. Max length - 1. Type - Number.
        /// </summary>
        /// <value>The number of times an Activation Code was received to activate the token. Max length - 1. Type - Number.</value>
        /// <example>1</example>
        [DataMember(Name = "numberOfActivationAttempts", EmitDefaultValue = false)]
        public int numberOfActivationAttempts { get; set; }

        /// <summary>
        /// The number of active tokens for the Funding Account. Valid values are 0 to 99. A value of 99 means there are 99 or more active tokens. Tokens that have been deleted from the wallet are excluded from the count.
        /// </summary>
        /// <value>The number of active tokens for the Funding Account. Valid values are 0 to 99. A value of 99 means there are 99 or more active tokens. Tokens that have been deleted from the wallet are excluded from the count.</value>
        /// <example>2</example>
        [DataMember(Name = "numberOfActiveTokens", EmitDefaultValue = false)]
        public int numberOfActiveTokens { get; set; }

        /// <summary>
        /// The assurance level assigned to the token. Type - Number.
        /// </summary>
        /// <value>The assurance level assigned to the token. Type - Number.</value>
        /// <example>1</example>
        [DataMember(Name = "tokenAssuranceLevel", EmitDefaultValue = false)]
        public int tokenAssuranceLevel { get; set; }

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
            sb.Append("class NotifyServiceActivatedRequestSchema {\n");
            sb.Append("  requestId: ").Append(requestId).Append("\n");
            sb.Append("  services: ").Append(services).Append("\n");
            sb.Append("  fundingAccountInfo: ").Append(fundingAccountInfo).Append("\n");
            sb.Append("  deviceInfo: ").Append(deviceInfo).Append("\n");
            sb.Append("  correlationId: ").Append(correlationId).Append("\n");
            sb.Append("  tokenRequestorId: ").Append(tokenRequestorId).Append("\n");
            sb.Append("  walletId: ").Append(walletId).Append("\n");
            sb.Append("  paymentAppInstanceId: ").Append(paymentAppInstanceId).Append("\n");
            sb.Append("  tokenType: ").Append(tokenType).Append("\n");
            sb.Append("  secureElementId: ").Append(secureElementId).Append("\n");
            sb.Append("  accountPanSuffix: ").Append(accountPanSuffix).Append("\n");
            sb.Append("  serviceRequestDateTime: ").Append(serviceRequestDateTime).Append("\n");
            sb.Append("  termsAndConditionsAssetId: ").Append(termsAndConditionsAssetId).Append("\n");
            sb.Append("  termsAndConditionsAcceptedTimestamp: ").Append(termsAndConditionsAcceptedTimestamp).Append("\n");
            sb.Append("  productConfigurationId: ").Append(productConfigurationId).Append("\n");
            sb.Append("  consumerLanguage: ").Append(consumerLanguage).Append("\n");
            sb.Append("  decision: ").Append(decision).Append("\n");
            sb.Append("  decisionMadeBy: ").Append(decisionMadeBy).Append("\n");
            sb.Append("  tokenActivatedDateTime: ").Append(tokenActivatedDateTime).Append("\n");
            sb.Append("  numberOfActivationAttempts: ").Append(numberOfActivationAttempts).Append("\n");
            sb.Append("  numberOfActiveTokens: ").Append(numberOfActiveTokens).Append("\n");
            sb.Append("  tokenAssuranceLevel: ").Append(tokenAssuranceLevel).Append("\n");
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

            // secureElementId (string) maxLength
            if (this.secureElementId != null && this.secureElementId.Length > 128)
            {
                yield return new ValidationResult("Invalid value for secureElementId, length must be less than 128.", new [] { "secureElementId" });
            }

            // secureElementId (string) minLength
            if (this.secureElementId != null && this.secureElementId.Length < 1)
            {
                yield return new ValidationResult("Invalid value for secureElementId, length must be greater than 1.", new [] { "secureElementId" });
            }

            // accountPanSuffix (string) maxLength
            if (this.accountPanSuffix != null && this.accountPanSuffix.Length > 8)
            {
                yield return new ValidationResult("Invalid value for accountPanSuffix, length must be less than 8.", new [] { "accountPanSuffix" });
            }

            // accountPanSuffix (string) minLength
            if (this.accountPanSuffix != null && this.accountPanSuffix.Length < 4)
            {
                yield return new ValidationResult("Invalid value for accountPanSuffix, length must be greater than 4.", new [] { "accountPanSuffix" });
            }

            // serviceRequestDateTime (string) maxLength
            if (this.serviceRequestDateTime != null && this.serviceRequestDateTime.Length > 29)
            {
                yield return new ValidationResult("Invalid value for serviceRequestDateTime, length must be less than 29.", new [] { "serviceRequestDateTime" });
            }

            // serviceRequestDateTime (string) minLength
            if (this.serviceRequestDateTime != null && this.serviceRequestDateTime.Length < 20)
            {
                yield return new ValidationResult("Invalid value for serviceRequestDateTime, length must be greater than 20.", new [] { "serviceRequestDateTime" });
            }

            // termsAndConditionsAssetId (string) maxLength
            if (this.termsAndConditionsAssetId != null && this.termsAndConditionsAssetId.Length > 64)
            {
                yield return new ValidationResult("Invalid value for termsAndConditionsAssetId, length must be less than 64.", new [] { "termsAndConditionsAssetId" });
            }

            // termsAndConditionsAssetId (string) minLength
            if (this.termsAndConditionsAssetId != null && this.termsAndConditionsAssetId.Length < 1)
            {
                yield return new ValidationResult("Invalid value for termsAndConditionsAssetId, length must be greater than 1.", new [] { "termsAndConditionsAssetId" });
            }

            // termsAndConditionsAcceptedTimestamp (string) maxLength
            if (this.termsAndConditionsAcceptedTimestamp != null && this.termsAndConditionsAcceptedTimestamp.Length > 29)
            {
                yield return new ValidationResult("Invalid value for termsAndConditionsAcceptedTimestamp, length must be less than 29.", new [] { "termsAndConditionsAcceptedTimestamp" });
            }

            // termsAndConditionsAcceptedTimestamp (string) minLength
            if (this.termsAndConditionsAcceptedTimestamp != null && this.termsAndConditionsAcceptedTimestamp.Length < 20)
            {
                yield return new ValidationResult("Invalid value for termsAndConditionsAcceptedTimestamp, length must be greater than 20.", new [] { "termsAndConditionsAcceptedTimestamp" });
            }

            // productConfigurationId (string) maxLength
            if (this.productConfigurationId != null && this.productConfigurationId.Length > 64)
            {
                yield return new ValidationResult("Invalid value for productConfigurationId, length must be less than 64.", new [] { "productConfigurationId" });
            }

            // productConfigurationId (string) minLength
            if (this.productConfigurationId != null && this.productConfigurationId.Length < 1)
            {
                yield return new ValidationResult("Invalid value for productConfigurationId, length must be greater than 1.", new [] { "productConfigurationId" });
            }

            // consumerLanguage (string) maxLength
            if (this.consumerLanguage != null && this.consumerLanguage.Length > 2)
            {
                yield return new ValidationResult("Invalid value for consumerLanguage, length must be less than 2.", new [] { "consumerLanguage" });
            }

            // consumerLanguage (string) minLength
            if (this.consumerLanguage != null && this.consumerLanguage.Length < 2)
            {
                yield return new ValidationResult("Invalid value for consumerLanguage, length must be greater than 2.", new [] { "consumerLanguage" });
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

            // decisionMadeBy (string) maxLength
            if (this.decisionMadeBy != null && this.decisionMadeBy.Length > 32)
            {
                yield return new ValidationResult("Invalid value for decisionMadeBy, length must be less than 32.", new [] { "decisionMadeBy" });
            }

            // decisionMadeBy (string) minLength
            if (this.decisionMadeBy != null && this.decisionMadeBy.Length < 1)
            {
                yield return new ValidationResult("Invalid value for decisionMadeBy, length must be greater than 1.", new [] { "decisionMadeBy" });
            }

            // tokenActivatedDateTime (string) maxLength
            if (this.tokenActivatedDateTime != null && this.tokenActivatedDateTime.Length > 29)
            {
                yield return new ValidationResult("Invalid value for tokenActivatedDateTime, length must be less than 29.", new [] { "tokenActivatedDateTime" });
            }

            // tokenActivatedDateTime (string) minLength
            if (this.tokenActivatedDateTime != null && this.tokenActivatedDateTime.Length < 20)
            {
                yield return new ValidationResult("Invalid value for tokenActivatedDateTime, length must be greater than 20.", new [] { "tokenActivatedDateTime" });
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
