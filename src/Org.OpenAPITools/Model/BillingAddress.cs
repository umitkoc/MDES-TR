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
    /// BillingAddress
    /// </summary>
    [DataContract(Name = "billingAddress")]
    public partial class BillingAddress : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BillingAddress" /> class.
        /// </summary>
        /// <param name="line1">**(OPTIONAL)** The first line of the street address for the billing address. .</param>
        /// <param name="line2">**(OPTIONAL)** The second line of the street address for the billing address. .</param>
        /// <param name="city">**(OPTIONAL)** The city of the billing address. .</param>
        /// <param name="countrySubdivision">**(OPTIONAL)** The state or country subdivision of the billing address. .</param>
        /// <param name="postalCode">**(OPTIONAL)** The postal of code of the billing address. .</param>
        /// <param name="country">**(OPTIONAL)** The country of the billing address. Expressed as a 3-letter (alpha-3) country code as defined in ISO 3166-1. .</param>
        public BillingAddress(string line1 = default(string), string line2 = default(string), string city = default(string), string countrySubdivision = default(string), string postalCode = default(string), string country = default(string))
        {
            this.Line1 = line1;
            this.Line2 = line2;
            this.City = city;
            this.CountrySubdivision = countrySubdivision;
            this.PostalCode = postalCode;
            this.Country = country;
        }

        /// <summary>
        /// **(OPTIONAL)** The first line of the street address for the billing address. 
        /// </summary>
        /// <value>**(OPTIONAL)** The first line of the street address for the billing address. </value>
        /// <example>100 1st Street</example>
        [DataMember(Name = "line1", EmitDefaultValue = false)]
        public string Line1 { get; set; }

        /// <summary>
        /// **(OPTIONAL)** The second line of the street address for the billing address. 
        /// </summary>
        /// <value>**(OPTIONAL)** The second line of the street address for the billing address. </value>
        /// <example>Apt. 4B</example>
        [DataMember(Name = "line2", EmitDefaultValue = false)]
        public string Line2 { get; set; }

        /// <summary>
        /// **(OPTIONAL)** The city of the billing address. 
        /// </summary>
        /// <value>**(OPTIONAL)** The city of the billing address. </value>
        /// <example>St. Louis</example>
        [DataMember(Name = "city", EmitDefaultValue = false)]
        public string City { get; set; }

        /// <summary>
        /// **(OPTIONAL)** The state or country subdivision of the billing address. 
        /// </summary>
        /// <value>**(OPTIONAL)** The state or country subdivision of the billing address. </value>
        /// <example>MO</example>
        [DataMember(Name = "countrySubdivision", EmitDefaultValue = false)]
        public string CountrySubdivision { get; set; }

        /// <summary>
        /// **(OPTIONAL)** The postal of code of the billing address. 
        /// </summary>
        /// <value>**(OPTIONAL)** The postal of code of the billing address. </value>
        /// <example>61000</example>
        [DataMember(Name = "postalCode", EmitDefaultValue = false)]
        public string PostalCode { get; set; }

        /// <summary>
        /// **(OPTIONAL)** The country of the billing address. Expressed as a 3-letter (alpha-3) country code as defined in ISO 3166-1. 
        /// </summary>
        /// <value>**(OPTIONAL)** The country of the billing address. Expressed as a 3-letter (alpha-3) country code as defined in ISO 3166-1. </value>
        /// <example>USA</example>
        [DataMember(Name = "country", EmitDefaultValue = false)]
        public string Country { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BillingAddress {\n");
            sb.Append("  Line1: ").Append(Line1).Append("\n");
            sb.Append("  Line2: ").Append(Line2).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  CountrySubdivision: ").Append(CountrySubdivision).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
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
            // Line1 (string) maxLength
            if (this.Line1 != null && this.Line1.Length > 64)
            {
                yield return new ValidationResult("Invalid value for Line1, length must be less than 64.", new [] { "Line1" });
            }

            // Line1 (string) minLength
            if (this.Line1 != null && this.Line1.Length < 1)
            {
                yield return new ValidationResult("Invalid value for Line1, length must be greater than 1.", new [] { "Line1" });
            }

            // Line2 (string) maxLength
            if (this.Line2 != null && this.Line2.Length > 64)
            {
                yield return new ValidationResult("Invalid value for Line2, length must be less than 64.", new [] { "Line2" });
            }

            // Line2 (string) minLength
            if (this.Line2 != null && this.Line2.Length < 1)
            {
                yield return new ValidationResult("Invalid value for Line2, length must be greater than 1.", new [] { "Line2" });
            }

            // City (string) maxLength
            if (this.City != null && this.City.Length > 32)
            {
                yield return new ValidationResult("Invalid value for City, length must be less than 32.", new [] { "City" });
            }

            // City (string) minLength
            if (this.City != null && this.City.Length < 1)
            {
                yield return new ValidationResult("Invalid value for City, length must be greater than 1.", new [] { "City" });
            }

            // CountrySubdivision (string) maxLength
            if (this.CountrySubdivision != null && this.CountrySubdivision.Length > 12)
            {
                yield return new ValidationResult("Invalid value for CountrySubdivision, length must be less than 12.", new [] { "CountrySubdivision" });
            }

            // CountrySubdivision (string) minLength
            if (this.CountrySubdivision != null && this.CountrySubdivision.Length < 1)
            {
                yield return new ValidationResult("Invalid value for CountrySubdivision, length must be greater than 1.", new [] { "CountrySubdivision" });
            }

            // PostalCode (string) maxLength
            if (this.PostalCode != null && this.PostalCode.Length > 16)
            {
                yield return new ValidationResult("Invalid value for PostalCode, length must be less than 16.", new [] { "PostalCode" });
            }

            // PostalCode (string) minLength
            if (this.PostalCode != null && this.PostalCode.Length < 1)
            {
                yield return new ValidationResult("Invalid value for PostalCode, length must be greater than 1.", new [] { "PostalCode" });
            }

            // Country (string) maxLength
            if (this.Country != null && this.Country.Length > 3)
            {
                yield return new ValidationResult("Invalid value for Country, length must be less than 3.", new [] { "Country" });
            }

            // Country (string) minLength
            if (this.Country != null && this.Country.Length < 3)
            {
                yield return new ValidationResult("Invalid value for Country, length must be greater than 3.", new [] { "Country" });
            }

            yield break;
        }
    }

}
