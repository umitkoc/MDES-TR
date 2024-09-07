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
    /// GetEligibleTokenRequestorsRequestData
    /// </summary>
    [DataContract(Name = "GetEligibleTokenRequestorsRequestData")]
    public partial class GetEligibleTokenRequestorsRequestData : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetEligibleTokenRequestorsRequestData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetEligibleTokenRequestorsRequestData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetEligibleTokenRequestorsRequestData" /> class.
        /// </summary>
        /// <param name="requestId">Unique identifier for the request.  __Max Length:__ 64  (required).</param>
        /// <param name="accountRanges">Array of the starting numbers of the account ranges to retrieve the enabled Token Requestors for. The starting numbers are numeric strings between 9 and 19 in length.If the starting numbers are less than 19, MDES will zero pad the end of the starting numbers to 19 in length. The padded value must exactly match the account range start number enabled for the Token Requestor.  __Max Number of Items:__ 25  (required).</param>
        /// <param name="supportsTokenConnect">A boolean parameter to receive only token requestors that support Token Connect or not. Must be one of:  * true - Token Connect is supported   * false - Token Connect is not supported .</param>
        public GetEligibleTokenRequestorsRequestData(string requestId = default(string), List<string> accountRanges = default(List<string>), bool supportsTokenConnect = default(bool))
        {
            // to ensure "requestId" is required (not null)
            if (requestId == null)
            {
                throw new ArgumentNullException("requestId is a required property for GetEligibleTokenRequestorsRequestData and cannot be null");
            }
            this.requestId = requestId;
            // to ensure "accountRanges" is required (not null)
            if (accountRanges == null)
            {
                throw new ArgumentNullException("accountRanges is a required property for GetEligibleTokenRequestorsRequestData and cannot be null");
            }
            this.accountRanges = accountRanges;
            this.supportsTokenConnect = supportsTokenConnect;
        }

        /// <summary>
        /// Unique identifier for the request.  __Max Length:__ 64 
        /// </summary>
        /// <value>Unique identifier for the request.  __Max Length:__ 64 </value>
        /// <example>123456</example>
        [DataMember(Name = "requestId", IsRequired = true, EmitDefaultValue = true)]
        public string requestId { get; set; }

        /// <summary>
        /// Array of the starting numbers of the account ranges to retrieve the enabled Token Requestors for. The starting numbers are numeric strings between 9 and 19 in length.If the starting numbers are less than 19, MDES will zero pad the end of the starting numbers to 19 in length. The padded value must exactly match the account range start number enabled for the Token Requestor.  __Max Number of Items:__ 25 
        /// </summary>
        /// <value>Array of the starting numbers of the account ranges to retrieve the enabled Token Requestors for. The starting numbers are numeric strings between 9 and 19 in length.If the starting numbers are less than 19, MDES will zero pad the end of the starting numbers to 19 in length. The padded value must exactly match the account range start number enabled for the Token Requestor.  __Max Number of Items:__ 25 </value>
        [DataMember(Name = "accountRanges", IsRequired = true, EmitDefaultValue = true)]
        public List<string> accountRanges { get; set; }

        /// <summary>
        /// A boolean parameter to receive only token requestors that support Token Connect or not. Must be one of:  * true - Token Connect is supported   * false - Token Connect is not supported 
        /// </summary>
        /// <value>A boolean parameter to receive only token requestors that support Token Connect or not. Must be one of:  * true - Token Connect is supported   * false - Token Connect is not supported </value>
        /// <example>true</example>
        [DataMember(Name = "supportsTokenConnect", EmitDefaultValue = true)]
        [Obsolete]
        public bool supportsTokenConnect { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetEligibleTokenRequestorsRequestData {\n");
            sb.Append("  requestId: ").Append(requestId).Append("\n");
            sb.Append("  accountRanges: ").Append(accountRanges).Append("\n");
            sb.Append("  supportsTokenConnect: ").Append(supportsTokenConnect).Append("\n");
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
