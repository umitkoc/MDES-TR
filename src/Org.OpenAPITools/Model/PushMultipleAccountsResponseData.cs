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
    /// PushMultipleAccountsResponseData
    /// </summary>
    [DataContract(Name = "PushMultipleAccountsResponseData")]
    public partial class PushMultipleAccountsResponseData : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PushMultipleAccountsResponseData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PushMultipleAccountsResponseData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PushMultipleAccountsResponseData" /> class.
        /// </summary>
        /// <param name="responseId">Unique identifier for the response matching the requestId supplied in the request.  __Max Length:__ 64  (required).</param>
        /// <param name="pushAccountReceipts">Array of the receipt values to be passed to the token requestor. __Conditional.__ Required if the push operation was successful. Not present otherwise. .</param>
        /// <param name="availablePushMethods">Array of push methods supported by the Token Requestor. __Conditional.__ Required if the push operation was successful. Not present otherwise. .</param>
        /// <param name="signature">The JWS signature output. __Conditional.__ Required if tokenRequestorSignatureSupport is true and at least one pushAccountReceipt is successfully returned .</param>
        /// <param name="tokenRequestorSignatureSupport">Indicates if the Token Requestor supports verification of the signature              .</param>
        /// <param name="errors">Element encapsulating a collection of errors that occurred during a single request. __Conditional.__ Required if one or more errors occurred while performing the operation. Not present if the operation was successful. .</param>
        public PushMultipleAccountsResponseData(string responseId = default(string), List<PushMultipleAccountsData> pushAccountReceipts = default(List<PushMultipleAccountsData>), List<PushMethod> availablePushMethods = default(List<PushMethod>), string signature = default(string), bool tokenRequestorSignatureSupport = default(bool), List<Error> errors = default(List<Error>))
        {
            // to ensure "responseId" is required (not null)
            if (responseId == null)
            {
                throw new ArgumentNullException("responseId is a required property for PushMultipleAccountsResponseData and cannot be null");
            }
            this.responseId = responseId;
            this.pushAccountReceipts = pushAccountReceipts;
            this.availablePushMethods = availablePushMethods;
            this.signature = signature;
            this.tokenRequestorSignatureSupport = tokenRequestorSignatureSupport;
            this.errors = errors;
        }

        /// <summary>
        /// Unique identifier for the response matching the requestId supplied in the request.  __Max Length:__ 64 
        /// </summary>
        /// <value>Unique identifier for the response matching the requestId supplied in the request.  __Max Length:__ 64 </value>
        /// <example>123456</example>
        [DataMember(Name = "responseId", IsRequired = true, EmitDefaultValue = true)]
        public string responseId { get; set; }

        /// <summary>
        /// Array of the receipt values to be passed to the token requestor. __Conditional.__ Required if the push operation was successful. Not present otherwise. 
        /// </summary>
        /// <value>Array of the receipt values to be passed to the token requestor. __Conditional.__ Required if the push operation was successful. Not present otherwise. </value>
        [DataMember(Name = "pushAccountReceipts", EmitDefaultValue = false)]
        public List<PushMultipleAccountsData> pushAccountReceipts { get; set; }

        /// <summary>
        /// Array of push methods supported by the Token Requestor. __Conditional.__ Required if the push operation was successful. Not present otherwise. 
        /// </summary>
        /// <value>Array of push methods supported by the Token Requestor. __Conditional.__ Required if the push operation was successful. Not present otherwise. </value>
        [DataMember(Name = "availablePushMethods", EmitDefaultValue = false)]
        public List<PushMethod> availablePushMethods { get; set; }

        /// <summary>
        /// The JWS signature output. __Conditional.__ Required if tokenRequestorSignatureSupport is true and at least one pushAccountReceipt is successfully returned 
        /// </summary>
        /// <value>The JWS signature output. __Conditional.__ Required if tokenRequestorSignatureSupport is true and at least one pushAccountReceipt is successfully returned </value>
        /// <example>ew0KImFsZyI6ICJSUzI1NiIsDQoNCiJraWQiOiAiYXNkZmctcXdlcnR5LXp4Y3ZiIg0KfQ.ew0KDQrCoCJwdXNoQWNjb3VudFJlY2VpcHQiOiAiTUNDLVNUTC0xMzQzMTNCRi01NTg1LTRFNzEtQUIyNC1FQ0RCQzI4RjIzRjEiLA0KImlzc3VlckNhbGxCYWNrIjogImh0dHBzOi8vaXNzdWVyY2FsbGJhY2sudXJsIiwNCiJjYWxsYmFja1JlcXVpcmVkIjogdHJ1ZSwNCiJjb21wbGV0ZVdlYnNpdGVBY3RpdmF0aW9uIjogdHJ1ZSwNCiJhY2NvdW50SG9sZGVyRGF0YVN1cHBsaWVkIjogdHJ1ZSwNCiJsb2NhbGUiOiAiZW5fVVMiDQoNCn0.dBjftJeZ4CVP-</example>
        [DataMember(Name = "signature", EmitDefaultValue = false)]
        public string signature { get; set; }

        /// <summary>
        /// Indicates if the Token Requestor supports verification of the signature              
        /// </summary>
        /// <value>Indicates if the Token Requestor supports verification of the signature              </value>
        /// <example>true</example>
        [DataMember(Name = "tokenRequestorSignatureSupport", EmitDefaultValue = true)]
        public bool tokenRequestorSignatureSupport { get; set; }

        /// <summary>
        /// Element encapsulating a collection of errors that occurred during a single request. __Conditional.__ Required if one or more errors occurred while performing the operation. Not present if the operation was successful. 
        /// </summary>
        /// <value>Element encapsulating a collection of errors that occurred during a single request. __Conditional.__ Required if one or more errors occurred while performing the operation. Not present if the operation was successful. </value>
        [DataMember(Name = "errors", EmitDefaultValue = false)]
        public List<Error> errors { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PushMultipleAccountsResponseData {\n");
            sb.Append("  responseId: ").Append(responseId).Append("\n");
            sb.Append("  pushAccountReceipts: ").Append(pushAccountReceipts).Append("\n");
            sb.Append("  availablePushMethods: ").Append(availablePushMethods).Append("\n");
            sb.Append("  signature: ").Append(signature).Append("\n");
            sb.Append("  tokenRequestorSignatureSupport: ").Append(tokenRequestorSignatureSupport).Append("\n");
            sb.Append("  errors: ").Append(errors).Append("\n");
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
