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
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;
using Org.OpenAPITools.Api;



// uncomment below to import models
//

namespace Acme.App.MastercardApi.Client.Test.Api
{
    /// <summary>
    ///  Class for testing AuthorizeServiceApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class AuthorizeServiceApiTests : IDisposable
    {
        private AuthorizeServiceApi instance;

        public AuthorizeServiceApiTests()
        {
            instance = new AuthorizeServiceApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of AuthorizeServiceApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' AuthorizeServiceApi
            //Assert.IsType<AuthorizeServiceApi>(instance);
        }

        /// <summary>
        /// Test AuthorizeService
        /// </summary>
        [Fact]
        public void AuthorizeServiceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //AuthorizeServiceRequestSchema authorizeServiceRequestSchema = null;
            //var response = instance.AuthorizeService(authorizeServiceRequestSchema);
            //Assert.IsType<AuthorizeServiceResponseSchema>(response);
        }
    }
}
