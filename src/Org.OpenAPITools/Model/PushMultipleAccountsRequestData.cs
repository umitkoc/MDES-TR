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
    /// PushMultipleAccountsRequestData
    /// </summary>
    [DataContract(Name = "PushMultipleAccountsRequestData")]
    public partial class PushMultipleAccountsRequestData : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PushMultipleAccountsRequestData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PushMultipleAccountsRequestData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PushMultipleAccountsRequestData" /> class.
        /// </summary>
        /// <param name="requestId">Unique identifier for the request.  __Max Length:__ 64  (required).</param>
        /// <param name="pushFundingAccounts">pushFundingAccounts (required).</param>
        /// <param name="tokenRequestorId">Identifies the Token Requestor __Length:__ 11  (required).</param>
        /// <param name="signatureData">signatureData.</param>
        /// <param name="requestIssuerInitiatedDigitizationData">Boolean value to indicate to return Issuer Initiated Digitization Data or not. A default of false should be assumed if this parameter is not supplied. &lt;br&gt; Must be one of: * true: Issuer Initiated Digitization Data is requested in the response. * false: Issuer Initiated Digitization Data is not requested in the response. .</param>
        /// <param name="pushAccountReceiptsValidityPeriod">Push Account Receipt validity period for given request. Validity period in minutes. If an issuer is pushing more than one accounts then provided value will be applicable to all pushAccountReceipts.   &lt;ul&gt; &lt;li&gt;Default value 15 minutes&lt;/li&gt; &lt;li&gt; Value must be greater than 4 minutes &lt;/li&gt; &lt;li&gt; Value must be lesser or equal to 15 minutes  &lt;/li&gt; &lt;/ul&gt; __Min Length:__ 1 __Max Length:__ 2             .</param>
        public PushMultipleAccountsRequestData(string requestId = default(string), EncryptedPayloadForMultiplePush pushFundingAccounts = default(EncryptedPayloadForMultiplePush), string tokenRequestorId = default(string), PushAccountSignatureData signatureData = default(PushAccountSignatureData), bool requestIssuerInitiatedDigitizationData = default(bool), decimal pushAccountReceiptsValidityPeriod = default(decimal))
        {
            // to ensure "requestId" is required (not null)
            if (requestId == null)
            {
                throw new ArgumentNullException("requestId is a required property for PushMultipleAccountsRequestData and cannot be null");
            }
            this.requestId = requestId;
            // to ensure "pushFundingAccounts" is required (not null)
            if (pushFundingAccounts == null)
            {
                throw new ArgumentNullException("pushFundingAccounts is a required property for PushMultipleAccountsRequestData and cannot be null");
            }
            this.pushFundingAccounts = pushFundingAccounts;
            // to ensure "tokenRequestorId" is required (not null)
            if (tokenRequestorId == null)
            {
                throw new ArgumentNullException("tokenRequestorId is a required property for PushMultipleAccountsRequestData and cannot be null");
            }
            this.tokenRequestorId = tokenRequestorId;
            this.signatureData = signatureData;
            this.requestIssuerInitiatedDigitizationData = requestIssuerInitiatedDigitizationData;
            this.pushAccountReceiptsValidityPeriod = pushAccountReceiptsValidityPeriod;
        }

        /// <summary>
        /// Unique identifier for the request.  __Max Length:__ 64 
        /// </summary>
        /// <value>Unique identifier for the request.  __Max Length:__ 64 </value>
        /// <example>123456</example>
        [DataMember(Name = "requestId", IsRequired = true, EmitDefaultValue = true)]
        public string requestId { get; set; }

        /// <summary>
        /// Gets or Sets pushFundingAccounts
        /// </summary>
        [DataMember(Name = "pushFundingAccounts", IsRequired = true, EmitDefaultValue = true)]
        public EncryptedPayloadForMultiplePush pushFundingAccounts { get; set; }

        /// <summary>
        /// Identifies the Token Requestor __Length:__ 11 
        /// </summary>
        /// <value>Identifies the Token Requestor __Length:__ 11 </value>
        /// <example>50123456789</example>
        [DataMember(Name = "tokenRequestorId", IsRequired = true, EmitDefaultValue = true)]
        public string tokenRequestorId { get; set; }

        /// <summary>
        /// Gets or Sets signatureData
        /// </summary>
        [DataMember(Name = "signatureData", EmitDefaultValue = false)]
        public PushAccountSignatureData signatureData { get; set; }

        /// <summary>
        /// Boolean value to indicate to return Issuer Initiated Digitization Data or not. A default of false should be assumed if this parameter is not supplied. &lt;br&gt; Must be one of: * true: Issuer Initiated Digitization Data is requested in the response. * false: Issuer Initiated Digitization Data is not requested in the response. 
        /// </summary>
        /// <value>Boolean value to indicate to return Issuer Initiated Digitization Data or not. A default of false should be assumed if this parameter is not supplied. &lt;br&gt; Must be one of: * true: Issuer Initiated Digitization Data is requested in the response. * false: Issuer Initiated Digitization Data is not requested in the response. </value>
        /// <example>false</example>
        [DataMember(Name = "requestIssuerInitiatedDigitizationData", EmitDefaultValue = true)]
        public bool requestIssuerInitiatedDigitizationData { get; set; }

        /// <summary>
        /// Push Account Receipt validity period for given request. Validity period in minutes. If an issuer is pushing more than one accounts then provided value will be applicable to all pushAccountReceipts.   &lt;ul&gt; &lt;li&gt;Default value 15 minutes&lt;/li&gt; &lt;li&gt; Value must be greater than 4 minutes &lt;/li&gt; &lt;li&gt; Value must be lesser or equal to 15 minutes  &lt;/li&gt; &lt;/ul&gt; __Min Length:__ 1 __Max Length:__ 2             
        /// </summary>
        /// <value>Push Account Receipt validity period for given request. Validity period in minutes. If an issuer is pushing more than one accounts then provided value will be applicable to all pushAccountReceipts.   &lt;ul&gt; &lt;li&gt;Default value 15 minutes&lt;/li&gt; &lt;li&gt; Value must be greater than 4 minutes &lt;/li&gt; &lt;li&gt; Value must be lesser or equal to 15 minutes  &lt;/li&gt; &lt;/ul&gt; __Min Length:__ 1 __Max Length:__ 2             </value>
        /// <example>15</example>
        [DataMember(Name = "pushAccountReceiptsValidityPeriod", EmitDefaultValue = false)]
        public decimal pushAccountReceiptsValidityPeriod { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PushMultipleAccountsRequestData {\n");
            sb.Append("  requestId: ").Append(requestId).Append("\n");
            sb.Append("  pushFundingAccounts: ").Append(pushFundingAccounts).Append("\n");
            sb.Append("  tokenRequestorId: ").Append(tokenRequestorId).Append("\n");
            sb.Append("  signatureData: ").Append(signatureData).Append("\n");
            sb.Append("  requestIssuerInitiatedDigitizationData: ").Append(requestIssuerInitiatedDigitizationData).Append("\n");
            sb.Append("  pushAccountReceiptsValidityPeriod: ").Append(pushAccountReceiptsValidityPeriod).Append("\n");
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
