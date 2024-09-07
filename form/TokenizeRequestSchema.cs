﻿using Newtonsoft.Json;
using Org.OpenAPITools.Model;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace form
{
    [DataContract(Name = "TokenizeRequestSchema")]
    public partial class TokenizeRequestSchema : IEquatable<TokenizeRequestSchema>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TokenizeRequestSchema" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TokenizeRequestSchema() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TokenizeRequestSchema" /> class.
        /// </summary>
        /// <param name="responseHost">\&quot;The host that originated the request. Future calls in the same conversation may be routed to this host. Must be provided as: host[:port][/contextRoot] Where port and contextRoot are optional. If contextRoot is not provided, the default (per the URL Scheme) is assumed and must be used.\&quot; .</param>
        /// <param name="requestId">Unique identifier for the request. .</param>
        /// <param name="tokenType">The type of Token requested. Must be CLOUD  (required).</param>
        /// <param name="tokenRequestorId">11-digit numeric ID provided by Mastercard that identifies the Token Requestor.  (required).</param>
        /// <param name="taskId">Identifier for this task as assigned by the Token Requestor, unique across a given Token Requestor Identifier. May be used in the Get Task Status API to query the status of this task.  (required).</param>
        /// <param name="fundingAccountInfo">fundingAccountInfo (required).</param>
        /// <param name="consumerLanguage">Language preference selected by the consumer. Formatted as an ISO- 639-1 two-letter language code. .</param>
        /// <param name="tokenizationAuthenticationValue">The Tokenization Authentication Value (TAV) as cryptographically signed by the Issuer to authorize this digitization request. .</param>
        /// <param name="decisioningData">decisioningData.</param>
        public TokenizeRequestSchema(string responseHost = default(string), string requestId = default(string), string tokenType = default(string), string tokenRequestorId = default(string), string taskId = default(string), FundingAccountInfo fundingAccountInfo = default(FundingAccountInfo), string consumerLanguage = default(string), string tokenizationAuthenticationValue = default(string), DecisioningData decisioningData = default(DecisioningData))
        {
            // to ensure "tokenType" is required (not null)
            this.TokenType = tokenType ?? throw new ArgumentNullException("tokenType is a required property for TokenizeRequestSchema and cannot be null");
            // to ensure "tokenRequestorId" is required (not null)
            this.TokenRequestorId = tokenRequestorId ?? throw new ArgumentNullException("tokenRequestorId is a required property for TokenizeRequestSchema and cannot be null");
            // to ensure "taskId" is required (not null)
            this.TaskId = taskId ?? throw new ArgumentNullException("taskId is a required property for TokenizeRequestSchema and cannot be null");
            // to ensure "fundingAccountInfo" is required (not null)
            this.FundingAccountInfo = fundingAccountInfo ?? throw new ArgumentNullException("fundingAccountInfo is a required property for TokenizeRequestSchema and cannot be null");
            this.ResponseHost = responseHost;
            this.RequestId = requestId;
            this.ConsumerLanguage = consumerLanguage;
            this.TokenizationAuthenticationValue = tokenizationAuthenticationValue;
            this.DecisioningData = decisioningData;
        }

        /// <summary>
        /// \&quot;The host that originated the request. Future calls in the same conversation may be routed to this host. Must be provided as: host[:port][/contextRoot] Where port and contextRoot are optional. If contextRoot is not provided, the default (per the URL Scheme) is assumed and must be used.\&quot; 
        /// </summary>
        /// <value>\&quot;The host that originated the request. Future calls in the same conversation may be routed to this host. Must be provided as: host[:port][/contextRoot] Where port and contextRoot are optional. If contextRoot is not provided, the default (per the URL Scheme) is assumed and must be used.\&quot; </value>
        [DataMember(Name = "responseHost", EmitDefaultValue = false)]
        public string ResponseHost { get; set; }

        /// <summary>
        /// Unique identifier for the request. 
        /// </summary>
        /// <value>Unique identifier for the request. </value>
        [DataMember(Name = "requestId", EmitDefaultValue = false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The type of Token requested. Must be CLOUD 
        /// </summary>
        /// <value>The type of Token requested. Must be CLOUD </value>
        [DataMember(Name = "tokenType", IsRequired = true, EmitDefaultValue = false)]
        public string TokenType { get; set; }

        /// <summary>
        /// 11-digit numeric ID provided by Mastercard that identifies the Token Requestor. 
        /// </summary>
        /// <value>11-digit numeric ID provided by Mastercard that identifies the Token Requestor. </value>
        [DataMember(Name = "tokenRequestorId", IsRequired = true, EmitDefaultValue = false)]
        public string TokenRequestorId { get; set; }

        /// <summary>
        /// Identifier for this task as assigned by the Token Requestor, unique across a given Token Requestor Identifier. May be used in the Get Task Status API to query the status of this task. 
        /// </summary>
        /// <value>Identifier for this task as assigned by the Token Requestor, unique across a given Token Requestor Identifier. May be used in the Get Task Status API to query the status of this task. </value>
        [DataMember(Name = "taskId", IsRequired = true, EmitDefaultValue = false)]
        public string TaskId { get; set; }

        /// <summary>
        /// Gets or Sets FundingAccountInfo
        /// </summary>
        [DataMember(Name = "fundingAccountInfo", IsRequired = true, EmitDefaultValue = false)]
        public FundingAccountInfo FundingAccountInfo { get; set; }

        /// <summary>
        /// Language preference selected by the consumer. Formatted as an ISO- 639-1 two-letter language code. 
        /// </summary>
        /// <value>Language preference selected by the consumer. Formatted as an ISO- 639-1 two-letter language code. </value>
        [DataMember(Name = "consumerLanguage", EmitDefaultValue = false)]
        public string ConsumerLanguage { get; set; }

        /// <summary>
        /// The Tokenization Authentication Value (TAV) as cryptographically signed by the Issuer to authorize this digitization request. 
        /// </summary>
        /// <value>The Tokenization Authentication Value (TAV) as cryptographically signed by the Issuer to authorize this digitization request. </value>
        [DataMember(Name = "tokenizationAuthenticationValue", EmitDefaultValue = false)]
        public string TokenizationAuthenticationValue { get; set; }

        /// <summary>
        /// Gets or Sets DecisioningData
        /// </summary>
        [DataMember(Name = "decisioningData", EmitDefaultValue = false)]
        public DecisioningData DecisioningData { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TokenizeRequestSchema {\n");
            sb.Append("  ResponseHost: ").Append(ResponseHost).Append("\n");
            sb.Append("  RequestId: ").Append(RequestId).Append("\n");
            sb.Append("  TokenType: ").Append(TokenType).Append("\n");
            sb.Append("  TokenRequestorId: ").Append(TokenRequestorId).Append("\n");
            sb.Append("  TaskId: ").Append(TaskId).Append("\n");
            sb.Append("  FundingAccountInfo: ").Append(FundingAccountInfo).Append("\n");
            sb.Append("  ConsumerLanguage: ").Append(ConsumerLanguage).Append("\n");
            sb.Append("  TokenizationAuthenticationValue: ").Append(TokenizationAuthenticationValue).Append("\n");
            sb.Append("  DecisioningData: ").Append(DecisioningData).Append("\n");
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
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as TokenizeRequestSchema);
        }

        /// <summary>
        /// Returns true if TokenizeRequestSchema instances are equal
        /// </summary>
        /// <param name="input">Instance of TokenizeRequestSchema to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TokenizeRequestSchema input)
        {
            if (input == null)
                return false;

            return
                (
                    this.ResponseHost == input.ResponseHost ||
                    (this.ResponseHost != null &&
                    this.ResponseHost.Equals(input.ResponseHost))
                ) &&
                (
                    this.RequestId == input.RequestId ||
                    (this.RequestId != null &&
                    this.RequestId.Equals(input.RequestId))
                ) &&
                (
                    this.TokenType == input.TokenType ||
                    (this.TokenType != null &&
                    this.TokenType.Equals(input.TokenType))
                ) &&
                (
                    this.TokenRequestorId == input.TokenRequestorId ||
                    (this.TokenRequestorId != null &&
                    this.TokenRequestorId.Equals(input.TokenRequestorId))
                ) &&
                (
                    this.TaskId == input.TaskId ||
                    (this.TaskId != null &&
                    this.TaskId.Equals(input.TaskId))
                ) &&
                (
                    this.FundingAccountInfo == input.FundingAccountInfo ||
                    (this.FundingAccountInfo != null &&
                    this.FundingAccountInfo.Equals(input.FundingAccountInfo))
                ) &&
                (
                    this.ConsumerLanguage == input.ConsumerLanguage ||
                    (this.ConsumerLanguage != null &&
                    this.ConsumerLanguage.Equals(input.ConsumerLanguage))
                ) &&
                (
                    this.TokenizationAuthenticationValue == input.TokenizationAuthenticationValue ||
                    (this.TokenizationAuthenticationValue != null &&
                    this.TokenizationAuthenticationValue.Equals(input.TokenizationAuthenticationValue))
                ) &&
                (
                    this.DecisioningData == input.DecisioningData ||
                    (this.DecisioningData != null &&
                    this.DecisioningData.Equals(input.DecisioningData))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.ResponseHost != null)
                    hashCode = hashCode * 59 + this.ResponseHost.GetHashCode();
                if (this.RequestId != null)
                    hashCode = hashCode * 59 + this.RequestId.GetHashCode();
                if (this.TokenType != null)
                    hashCode = hashCode * 59 + this.TokenType.GetHashCode();
                if (this.TokenRequestorId != null)
                    hashCode = hashCode * 59 + this.TokenRequestorId.GetHashCode();
                if (this.TaskId != null)
                    hashCode = hashCode * 59 + this.TaskId.GetHashCode();
                if (this.FundingAccountInfo != null)
                    hashCode = hashCode * 59 + this.FundingAccountInfo.GetHashCode();
                if (this.ConsumerLanguage != null)
                    hashCode = hashCode * 59 + this.ConsumerLanguage.GetHashCode();
                if (this.TokenizationAuthenticationValue != null)
                    hashCode = hashCode * 59 + this.TokenizationAuthenticationValue.GetHashCode();
                if (this.DecisioningData != null)
                    hashCode = hashCode * 59 + this.DecisioningData.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // TokenType (string) maxLength
            if (this.TokenType != null && this.TokenType.Length > 32)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TokenType, length must be less than 32.", new[] { "TokenType" });
            }

            // TokenRequestorId (string) maxLength
            if (this.TokenRequestorId != null && this.TokenRequestorId.Length > 11)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TokenRequestorId, length must be less than 11.", new[] { "TokenRequestorId" });
            }

            // TaskId (string) maxLength
            if (this.TaskId != null && this.TaskId.Length > 64)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TaskId, length must be less than 64.", new[] { "TaskId" });
            }

            // ConsumerLanguage (string) maxLength
            if (this.ConsumerLanguage != null && this.ConsumerLanguage.Length > 2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ConsumerLanguage, length must be less than 2.", new[] { "ConsumerLanguage" });
            }

            // TokenizationAuthenticationValue (string) maxLength
            if (this.TokenizationAuthenticationValue != null && this.TokenizationAuthenticationValue.Length > 2048)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TokenizationAuthenticationValue, length must be less than 2048.", new[] { "TokenizationAuthenticationValue" });
            }

            yield break;
        }
    }

}