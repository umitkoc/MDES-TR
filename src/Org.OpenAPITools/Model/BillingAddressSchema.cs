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
    /// The address for the account holder. Verified as part of reaching the digitization decision. Max length - Not applicable.
    /// </summary>
    [DataContract(Name = "billingAddressSchema")]
    public partial class BillingAddressSchema : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BillingAddressSchema" /> class.
        /// </summary>
        /// <param name="line1">First line of the billing address..</param>
        /// <param name="line2">Second line of the billing address..</param>
        /// <param name="city">The city of the billing address..</param>
        /// <param name="countrySubdivision">The country subdivision (for example, the state in the U.S.) of the billing address..</param>
        /// <param name="postalCode">The postal code (for example, zipcode in the U.S.) of the billing address..</param>
        /// <param name="country">The country of the billing address. Expressed as a 3-letter (alpha-3) country code as defined in ISO 3166-1..</param>
        public BillingAddressSchema(string line1 = default(string), string line2 = default(string), string city = default(string), string countrySubdivision = default(string), string postalCode = default(string), string country = default(string))
        {
            this.line1 = line1;
            this.line2 = line2;
            this.city = city;
            this.countrySubdivision = countrySubdivision;
            this.postalCode = postalCode;
            this.country = country;
        }

        /// <summary>
        /// First line of the billing address.
        /// </summary>
        /// <value>First line of the billing address.</value>
        /// <example>100 1st Street</example>
        [DataMember(Name = "line1", EmitDefaultValue = false)]
        public string line1 { get; set; }

        /// <summary>
        /// Second line of the billing address.
        /// </summary>
        /// <value>Second line of the billing address.</value>
        /// <example>Apt. 4B</example>
        [DataMember(Name = "line2", EmitDefaultValue = false)]
        public string line2 { get; set; }

        /// <summary>
        /// The city of the billing address.
        /// </summary>
        /// <value>The city of the billing address.</value>
        /// <example>St. Louis</example>
        [DataMember(Name = "city", EmitDefaultValue = false)]
        public string city { get; set; }

        /// <summary>
        /// The country subdivision (for example, the state in the U.S.) of the billing address.
        /// </summary>
        /// <value>The country subdivision (for example, the state in the U.S.) of the billing address.</value>
        /// <example>MO</example>
        [DataMember(Name = "countrySubdivision", EmitDefaultValue = false)]
        public string countrySubdivision { get; set; }

        /// <summary>
        /// The postal code (for example, zipcode in the U.S.) of the billing address.
        /// </summary>
        /// <value>The postal code (for example, zipcode in the U.S.) of the billing address.</value>
        /// <example>61000</example>
        [DataMember(Name = "postalCode", EmitDefaultValue = false)]
        public string postalCode { get; set; }

        /// <summary>
        /// The country of the billing address. Expressed as a 3-letter (alpha-3) country code as defined in ISO 3166-1.
        /// </summary>
        /// <value>The country of the billing address. Expressed as a 3-letter (alpha-3) country code as defined in ISO 3166-1.</value>
        /// <example>USA</example>
        [DataMember(Name = "country", EmitDefaultValue = false)]
        public string country { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BillingAddressSchema {\n");
            sb.Append("  line1: ").Append(line1).Append("\n");
            sb.Append("  line2: ").Append(line2).Append("\n");
            sb.Append("  city: ").Append(city).Append("\n");
            sb.Append("  countrySubdivision: ").Append(countrySubdivision).Append("\n");
            sb.Append("  postalCode: ").Append(postalCode).Append("\n");
            sb.Append("  country: ").Append(country).Append("\n");
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
            // line1 (string) maxLength
            if (this.line1 != null && this.line1.Length > 64)
            {
                yield return new ValidationResult("Invalid value for line1, length must be less than 64.", new [] { "line1" });
            }

            // line1 (string) minLength
            if (this.line1 != null && this.line1.Length < 1)
            {
                yield return new ValidationResult("Invalid value for line1, length must be greater than 1.", new [] { "line1" });
            }

            // line2 (string) maxLength
            if (this.line2 != null && this.line2.Length > 64)
            {
                yield return new ValidationResult("Invalid value for line2, length must be less than 64.", new [] { "line2" });
            }

            // line2 (string) minLength
            if (this.line2 != null && this.line2.Length < 1)
            {
                yield return new ValidationResult("Invalid value for line2, length must be greater than 1.", new [] { "line2" });
            }

            // city (string) maxLength
            if (this.city != null && this.city.Length > 32)
            {
                yield return new ValidationResult("Invalid value for city, length must be less than 32.", new [] { "city" });
            }

            // city (string) minLength
            if (this.city != null && this.city.Length < 1)
            {
                yield return new ValidationResult("Invalid value for city, length must be greater than 1.", new [] { "city" });
            }

            // countrySubdivision (string) maxLength
            if (this.countrySubdivision != null && this.countrySubdivision.Length > 12)
            {
                yield return new ValidationResult("Invalid value for countrySubdivision, length must be less than 12.", new [] { "countrySubdivision" });
            }

            // countrySubdivision (string) minLength
            if (this.countrySubdivision != null && this.countrySubdivision.Length < 1)
            {
                yield return new ValidationResult("Invalid value for countrySubdivision, length must be greater than 1.", new [] { "countrySubdivision" });
            }

            // postalCode (string) maxLength
            if (this.postalCode != null && this.postalCode.Length > 16)
            {
                yield return new ValidationResult("Invalid value for postalCode, length must be less than 16.", new [] { "postalCode" });
            }

            // postalCode (string) minLength
            if (this.postalCode != null && this.postalCode.Length < 1)
            {
                yield return new ValidationResult("Invalid value for postalCode, length must be greater than 1.", new [] { "postalCode" });
            }

            // country (string) maxLength
            if (this.country != null && this.country.Length > 3)
            {
                yield return new ValidationResult("Invalid value for country, length must be less than 3.", new [] { "country" });
            }

            // country (string) minLength
            if (this.country != null && this.country.Length < 3)
            {
                yield return new ValidationResult("Invalid value for country, length must be greater than 3.", new [] { "country" });
            }

            yield break;
        }
    }

}
