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
    /// FinancialAccount
    /// </summary>
    [DataContract(Name = "FinancialAccount")]
    public partial class FinancialAccount : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FinancialAccount" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FinancialAccount() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FinancialAccount" /> class.
        /// </summary>
        /// <param name="financialAccountId">The identifier of the financial account being tokenized.This could be a bank account number or other types of financial accounts. __Max length:__ 64 -  __Min length:__ 9. __Data Type:__ String (spaces not allowed).  (required).</param>
        /// <param name="interbankCardAssociationId">The identifier (ICA) assigned by Mastercard to the financial institution. __Max length:__ 11 -  __Min length:__ 3. __Data Type:__ String (Numeric).  (required).</param>
        /// <param name="countryCode">The country of the financial account. Expressed as a 3-letter (alpha-3) country code as defined in ISO 3166-1. __Length:__ 3  (required).</param>
        public FinancialAccount(string financialAccountId = default(string), string interbankCardAssociationId = default(string), string countryCode = default(string))
        {
            // to ensure "financialAccountId" is required (not null)
            if (financialAccountId == null)
            {
                throw new ArgumentNullException("financialAccountId is a required property for FinancialAccount and cannot be null");
            }
            this.financialAccountId = financialAccountId;
            // to ensure "interbankCardAssociationId" is required (not null)
            if (interbankCardAssociationId == null)
            {
                throw new ArgumentNullException("interbankCardAssociationId is a required property for FinancialAccount and cannot be null");
            }
            this.interbankCardAssociationId = interbankCardAssociationId;
            // to ensure "countryCode" is required (not null)
            if (countryCode == null)
            {
                throw new ArgumentNullException("countryCode is a required property for FinancialAccount and cannot be null");
            }
            this.countryCode = countryCode;
        }

        /// <summary>
        /// The identifier of the financial account being tokenized.This could be a bank account number or other types of financial accounts. __Max length:__ 64 -  __Min length:__ 9. __Data Type:__ String (spaces not allowed). 
        /// </summary>
        /// <value>The identifier of the financial account being tokenized.This could be a bank account number or other types of financial accounts. __Max length:__ 64 -  __Min length:__ 9. __Data Type:__ String (spaces not allowed). </value>
        /// <example>5123456789012345</example>
        [DataMember(Name = "financialAccountId", IsRequired = true, EmitDefaultValue = true)]
        public string financialAccountId { get; set; }

        /// <summary>
        /// The identifier (ICA) assigned by Mastercard to the financial institution. __Max length:__ 11 -  __Min length:__ 3. __Data Type:__ String (Numeric). 
        /// </summary>
        /// <value>The identifier (ICA) assigned by Mastercard to the financial institution. __Max length:__ 11 -  __Min length:__ 3. __Data Type:__ String (Numeric). </value>
        /// <example>1234</example>
        [DataMember(Name = "interbankCardAssociationId", IsRequired = true, EmitDefaultValue = true)]
        public string interbankCardAssociationId { get; set; }

        /// <summary>
        /// The country of the financial account. Expressed as a 3-letter (alpha-3) country code as defined in ISO 3166-1. __Length:__ 3 
        /// </summary>
        /// <value>The country of the financial account. Expressed as a 3-letter (alpha-3) country code as defined in ISO 3166-1. __Length:__ 3 </value>
        /// <example>GBR</example>
        [DataMember(Name = "countryCode", IsRequired = true, EmitDefaultValue = true)]
        public string countryCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FinancialAccount {\n");
            sb.Append("  financialAccountId: ").Append(financialAccountId).Append("\n");
            sb.Append("  interbankCardAssociationId: ").Append(interbankCardAssociationId).Append("\n");
            sb.Append("  countryCode: ").Append(countryCode).Append("\n");
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
