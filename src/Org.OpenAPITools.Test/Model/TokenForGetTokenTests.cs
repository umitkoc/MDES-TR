/*
 * Mastercard Digital Enablement API
 *
 * The Mastercard Digital Enablement API encompasses a set of APIs that are initiated by the Token Requestor for the purposes of creating and managing the life cycle of a token.      **Authentication**  <br><br>  Mastercard uses OAuth 1.0a with body hash extension for authenticating the API clients. This requires every request that you send to  Mastercard to be signed with an RSA private key. A private-public RSA key pair must be generated consisting of:  <br><br>  1. A private key for the OAuth signature for API requests. It is recommended to keep the private key in a password-protected or hardware keystore.  <br>  2. A public key is shared with Mastercard during the project setup process through either a certificate signing request (CSR) or the API Key Generator. Mastercard will use the public key to verify the OAuth signature that is provided on every API call.<br>   An OAUTH1.0a signer library is available on [GitHub](https://github.com/Mastercard/oauth1-signer-java)  <br><br>  **Encryption**  <br><br>  All communications between Issuer web service and the Mastercard gateway is encrypted using TLS.  <br><br>  **Additional Encryption of Sensitive Data**  <br><br>  In addition to the OAuth authentication, when using MDES Digital Enablement Service, any PCI sensitive and all account holder Personally Identifiable Information (PII) data must be encrypted. This requirement applies to the API fields containing encryptedData. Sensitive data is encrypted using a symmetric session (one-time-use) key. The symmetric session key is then wrapped with an RSA Public Key supplied by Mastercard during API setup phase (the Customer Encryption Key). <br>   Java Client Encryption Library available on [GitHub](https://github.com/Mastercard/client-encryption-java) 
 *
 * The version of the OpenAPI document: 1.3.3
 * Contact: apisupport@mastercard.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Org.OpenAPITools.Model;
using Org.OpenAPITools.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Test.Model
{
    /// <summary>
    ///  Class for testing TokenForGetToken
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class TokenForGetTokenTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for TokenForGetToken
        //private TokenForGetToken instance;

        public TokenForGetTokenTests()
        {
            // TODO uncomment below to create an instance of TokenForGetToken
            //instance = new TokenForGetToken();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of TokenForGetToken
        /// </summary>
        [Fact]
        public void TokenForGetTokenInstanceTest()
        {
            // TODO uncomment below to test "IsType" TokenForGetToken
            //Assert.IsType<TokenForGetToken>(instance);
        }

        /// <summary>
        /// Test the property 'TokenUniqueReference'
        /// </summary>
        [Fact]
        public void TokenUniqueReferenceTest()
        {
            // TODO unit test for the property 'TokenUniqueReference'
        }

        /// <summary>
        /// Test the property 'TokenRequestorId'
        /// </summary>
        [Fact]
        public void TokenRequestorIdTest()
        {
            // TODO unit test for the property 'TokenRequestorId'
        }

        /// <summary>
        /// Test the property 'Status'
        /// </summary>
        [Fact]
        public void StatusTest()
        {
            // TODO unit test for the property 'Status'
        }

        /// <summary>
        /// Test the property 'SuspendedBy'
        /// </summary>
        [Fact]
        public void SuspendedByTest()
        {
            // TODO unit test for the property 'SuspendedBy'
        }

        /// <summary>
        /// Test the property 'StatusTimestamp'
        /// </summary>
        [Fact]
        public void StatusTimestampTest()
        {
            // TODO unit test for the property 'StatusTimestamp'
        }

        /// <summary>
        /// Test the property 'ProductConfig'
        /// </summary>
        [Fact]
        public void ProductConfigTest()
        {
            // TODO unit test for the property 'ProductConfig'
        }

        /// <summary>
        /// Test the property 'TokenInfo'
        /// </summary>
        [Fact]
        public void TokenInfoTest()
        {
            // TODO unit test for the property 'TokenInfo'
        }
    }
}
