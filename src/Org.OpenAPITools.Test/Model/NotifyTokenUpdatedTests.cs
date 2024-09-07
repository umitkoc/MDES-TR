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
    ///  Class for testing NotifyTokenUpdated
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class NotifyTokenUpdatedTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for NotifyTokenUpdated
        //private NotifyTokenUpdated instance;

        public NotifyTokenUpdatedTests()
        {
            // TODO uncomment below to create an instance of NotifyTokenUpdated
            //instance = new NotifyTokenUpdated();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of NotifyTokenUpdated
        /// </summary>
        [Fact]
        public void NotifyTokenUpdatedInstanceTest()
        {
            // TODO uncomment below to test "IsType" NotifyTokenUpdated
            //Assert.IsType<NotifyTokenUpdated>(instance);
        }

        /// <summary>
        /// Test the property 'ResponseHost'
        /// </summary>
        [Fact]
        public void ResponseHostTest()
        {
            // TODO unit test for the property 'ResponseHost'
        }

        /// <summary>
        /// Test the property 'RequestId'
        /// </summary>
        [Fact]
        public void RequestIdTest()
        {
            // TODO unit test for the property 'RequestId'
        }

        /// <summary>
        /// Test the property 'EncryptedPayload'
        /// </summary>
        [Fact]
        public void EncryptedPayloadTest()
        {
            // TODO unit test for the property 'EncryptedPayload'
        }

        /// <summary>
        /// Test the property 'RedigitizationRequired'
        /// </summary>
        [Fact]
        public void RedigitizationRequiredTest()
        {
            // TODO unit test for the property 'RedigitizationRequired'
        }
    }
}
