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
    ///  Class for testing RequestActivationMethodsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class RequestActivationMethodsApiTests : IDisposable
    {
        private RequestActivationMethodsApi instance;

        public RequestActivationMethodsApiTests()
        {
            instance = new RequestActivationMethodsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of RequestActivationMethodsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' RequestActivationMethodsApi
            //Assert.IsType<RequestActivationMethodsApi>(instance);
        }

        /// <summary>
        /// Test RequestForActivationMethods
        /// </summary>
        [Fact]
        public void RequestForActivationMethodsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //RequestActivationMethodsRequestSchema requestActivationMethodsRequestSchema = null;
            //var response = instance.RequestForActivationMethods(requestActivationMethodsRequestSchema);
            //Assert.IsType<RequestActivationMethodsResponseSchema>(response);
        }
    }
}
