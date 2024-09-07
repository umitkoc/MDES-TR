/*
 * Mastercard Digital Enablement API
 *
 * The Mastercard Digital Enablement API encompasses a set of APIs that are initiated by the Token Requestor for the purposes of creating and managing the life cycle of a token.      **Authentication**  <br><br>  Mastercard uses OAuth 1.0a with body hash extension for authenticating the API clients. This requires every request that you send to  Mastercard to be signed with an RSA private key. A private-public RSA key pair must be generated consisting of:  <br><br>  1. A private key for the OAuth signature for API requests. It is recommended to keep the private key in a password-protected or hardware keystore.  <br>  2. A public key is shared with Mastercard during the project setup process through either a certificate signing request (CSR) or the API Key Generator. Mastercard will use the public key to verify the OAuth signature that is provided on every API call.<br>   An OAUTH1.0a signer library is available on [GitHub](https://github.com/Mastercard/oauth1-signer-java)  <br><br>  **Encryption**  <br><br>  All communications between Issuer web service and the Mastercard gateway is encrypted using TLS.  <br><br>  **Additional Encryption of Sensitive Data**  <br><br>  In addition to the OAuth authentication, when using MDES Digital Enablement Service, any PCI sensitive and all account holder Personally Identifiable Information (PII) data must be encrypted. This requirement applies to the API fields containing encryptedData. Sensitive data is encrypted using a symmetric session (one-time-use) key. The symmetric session key is then wrapped with an RSA Public Key supplied by Mastercard during API setup phase (the Customer Encryption Key). <br>   Java Client Encryption Library available on [GitHub](https://github.com/Mastercard/client-encryption-java) 
 *
 * The version of the OpenAPI document: 1.3.3
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
    /// GetTokenResults
    /// </summary>
    [DataContract(Name = "GetTokenResults")]
    public partial class GetTokenResults : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetTokenResults" /> class.
        /// </summary>
        /// <param name="responseId">Unique identifier for the response. .</param>
        /// <param name="token">token.</param>
        /// <param name="tokenDetail">tokenDetail.</param>
        public GetTokenResults(string responseId = default(string), TokenForGetToken token = default(TokenForGetToken), TokenDetailGetTokenOnly tokenDetail = default(TokenDetailGetTokenOnly))
        {
            this.ResponseId = responseId;
            this.Token = token;
            this.TokenDetail = tokenDetail;
        }

        /// <summary>
        /// Unique identifier for the response. 
        /// </summary>
        /// <value>Unique identifier for the response. </value>
        /// <example>123456</example>
        [DataMember(Name = "responseId", EmitDefaultValue = false)]
        public string ResponseId { get; set; }

        /// <summary>
        /// Gets or Sets Token
        /// </summary>
        [DataMember(Name = "token", EmitDefaultValue = false)]
        public TokenForGetToken Token { get; set; }

        /// <summary>
        /// Gets or Sets TokenDetail
        /// </summary>
        [DataMember(Name = "tokenDetail", EmitDefaultValue = false)]
        public TokenDetailGetTokenOnly TokenDetail { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetTokenResults {\n");
            sb.Append("  ResponseId: ").Append(ResponseId).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("  TokenDetail: ").Append(TokenDetail).Append("\n");
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
            // ResponseId (string) maxLength
            if (this.ResponseId != null && this.ResponseId.Length > 64)
            {
                yield return new ValidationResult("Invalid value for ResponseId, length must be less than 64.", new [] { "ResponseId" });
            }

            // ResponseId (string) minLength
            if (this.ResponseId != null && this.ResponseId.Length < 1)
            {
                yield return new ValidationResult("Invalid value for ResponseId, length must be greater than 1.", new [] { "ResponseId" });
            }

            yield break;
        }
    }

}
