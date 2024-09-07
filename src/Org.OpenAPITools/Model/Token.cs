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
    /// Token
    /// </summary>
    [DataContract(Name = "token")]
    public partial class Token : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Token" /> class.
        /// </summary>
        /// <param name="tokenUniqueReference">The unique reference allocated to the Token which is always present even if an error occurs. .</param>
        /// <param name="status">The current status of Token. Must be either:  * &#39;INACTIVE&#39; (Token has not yet been activated)  * &#39;ACTIVE&#39; (Token is active and ready to transact)  * &#39;SUSPENDED&#39; (Token is suspended and unable to transact)  * &#39;DEACTIVATED&#39; (Token has been permanently deactivated). .</param>
        /// <param name="suspendedBy">(CONDITIONAL only supplied if status is SUSPENDED) Who or what caused the Token to be suspended One or more values of:    * ISSUER - Suspended by the Issuer.    * TOKEN_REQUESTOR - Suspended by the Token Requestor    * MOBILE_PIN_LOCKED - Suspended due to the Mobile PIN being locked    * CARDHOLDER - Suspended by the Cardholder .</param>
        /// <param name="statusTimestamp">The date and time the token status was last updated. Expressed in ISO 8601 extended format as one of the following:    * YYYY-MM-DDThh:mm:ss[.sss]Z    * YYYY-MM-DDThh:mm:ss[.sss]±hh:mm    * Where [.sss] is optional and can be 1 to 3 digits. .</param>
        /// <param name="productConfig">productConfig.</param>
        /// <param name="tokenInfo">tokenInfo.</param>
        public Token(string tokenUniqueReference = default(string), string status = default(string), List<string> suspendedBy = default(List<string>), string statusTimestamp = default(string), ProductConfig productConfig = default(ProductConfig), TokenInfo tokenInfo = default(TokenInfo))
        {
            this.TokenUniqueReference = tokenUniqueReference;
            this.Status = status;
            this.SuspendedBy = suspendedBy;
            this.StatusTimestamp = statusTimestamp;
            this.ProductConfig = productConfig;
            this.TokenInfo = tokenInfo;
        }

        /// <summary>
        /// The unique reference allocated to the Token which is always present even if an error occurs. 
        /// </summary>
        /// <value>The unique reference allocated to the Token which is always present even if an error occurs. </value>
        /// <example>DWSPMC000000000132d72d4fcb2f4136a0532d3093ff1a45</example>
        [DataMember(Name = "tokenUniqueReference", EmitDefaultValue = false)]
        public string TokenUniqueReference { get; set; }

        /// <summary>
        /// The current status of Token. Must be either:  * &#39;INACTIVE&#39; (Token has not yet been activated)  * &#39;ACTIVE&#39; (Token is active and ready to transact)  * &#39;SUSPENDED&#39; (Token is suspended and unable to transact)  * &#39;DEACTIVATED&#39; (Token has been permanently deactivated). 
        /// </summary>
        /// <value>The current status of Token. Must be either:  * &#39;INACTIVE&#39; (Token has not yet been activated)  * &#39;ACTIVE&#39; (Token is active and ready to transact)  * &#39;SUSPENDED&#39; (Token is suspended and unable to transact)  * &#39;DEACTIVATED&#39; (Token has been permanently deactivated). </value>
        /// <example>SUSPENDED</example>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// (CONDITIONAL only supplied if status is SUSPENDED) Who or what caused the Token to be suspended One or more values of:    * ISSUER - Suspended by the Issuer.    * TOKEN_REQUESTOR - Suspended by the Token Requestor    * MOBILE_PIN_LOCKED - Suspended due to the Mobile PIN being locked    * CARDHOLDER - Suspended by the Cardholder 
        /// </summary>
        /// <value>(CONDITIONAL only supplied if status is SUSPENDED) Who or what caused the Token to be suspended One or more values of:    * ISSUER - Suspended by the Issuer.    * TOKEN_REQUESTOR - Suspended by the Token Requestor    * MOBILE_PIN_LOCKED - Suspended due to the Mobile PIN being locked    * CARDHOLDER - Suspended by the Cardholder </value>
        [DataMember(Name = "suspendedBy", EmitDefaultValue = false)]
        public List<string> SuspendedBy { get; set; }

        /// <summary>
        /// The date and time the token status was last updated. Expressed in ISO 8601 extended format as one of the following:    * YYYY-MM-DDThh:mm:ss[.sss]Z    * YYYY-MM-DDThh:mm:ss[.sss]±hh:mm    * Where [.sss] is optional and can be 1 to 3 digits. 
        /// </summary>
        /// <value>The date and time the token status was last updated. Expressed in ISO 8601 extended format as one of the following:    * YYYY-MM-DDThh:mm:ss[.sss]Z    * YYYY-MM-DDThh:mm:ss[.sss]±hh:mm    * Where [.sss] is optional and can be 1 to 3 digits. </value>
        /// <example>2017-07-20T04:56:23.345-07:00</example>
        [DataMember(Name = "statusTimestamp", EmitDefaultValue = false)]
        public string StatusTimestamp { get; set; }

        /// <summary>
        /// Gets or Sets ProductConfig
        /// </summary>
        [DataMember(Name = "productConfig", EmitDefaultValue = false)]
        public ProductConfig ProductConfig { get; set; }

        /// <summary>
        /// Gets or Sets TokenInfo
        /// </summary>
        [DataMember(Name = "tokenInfo", EmitDefaultValue = false)]
        public TokenInfo TokenInfo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Token {\n");
            sb.Append("  TokenUniqueReference: ").Append(TokenUniqueReference).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  SuspendedBy: ").Append(SuspendedBy).Append("\n");
            sb.Append("  StatusTimestamp: ").Append(StatusTimestamp).Append("\n");
            sb.Append("  ProductConfig: ").Append(ProductConfig).Append("\n");
            sb.Append("  TokenInfo: ").Append(TokenInfo).Append("\n");
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
            // TokenUniqueReference (string) maxLength
            if (this.TokenUniqueReference != null && this.TokenUniqueReference.Length > 64)
            {
                yield return new ValidationResult("Invalid value for TokenUniqueReference, length must be less than 64.", new [] { "TokenUniqueReference" });
            }

            // TokenUniqueReference (string) minLength
            if (this.TokenUniqueReference != null && this.TokenUniqueReference.Length < 48)
            {
                yield return new ValidationResult("Invalid value for TokenUniqueReference, length must be greater than 48.", new [] { "TokenUniqueReference" });
            }

            // Status (string) maxLength
            if (this.Status != null && this.Status.Length > 32)
            {
                yield return new ValidationResult("Invalid value for Status, length must be less than 32.", new [] { "Status" });
            }

            // Status (string) minLength
            if (this.Status != null && this.Status.Length < 1)
            {
                yield return new ValidationResult("Invalid value for Status, length must be greater than 1.", new [] { "Status" });
            }

            // StatusTimestamp (string) maxLength
            if (this.StatusTimestamp != null && this.StatusTimestamp.Length > 29)
            {
                yield return new ValidationResult("Invalid value for StatusTimestamp, length must be less than 29.", new [] { "StatusTimestamp" });
            }

            // StatusTimestamp (string) minLength
            if (this.StatusTimestamp != null && this.StatusTimestamp.Length < 20)
            {
                yield return new ValidationResult("Invalid value for StatusTimestamp, length must be greater than 20.", new [] { "StatusTimestamp" });
            }

            yield break;
        }
    }

}
