/*
 * Mastercard Digital Enablement Service Issuer Outbound API
 *
 * The MDES Issuer Outbound Pre-Digitization API supports the pre-digitization web services provided by the Digitization Service. The web services are used to inform Issuers of MDES services being requested by, or on-behalf of, their account holders. Issuers may provide information in their responses to guide or inform the Account holder’s experience through the Token Reqestor.
 *
 * The version of the OpenAPI document: 2.0.21 (Document version)
 * Contact: apisupport@mastercard.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;


using System.Reflection;
using Newtonsoft.Json;

namespace Acme.App.MastercardApi.Client.Test.Model
{
    /// <summary>
    ///  Class for testing FinancialAccountDataSchema
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class FinancialAccountDataSchemaTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for FinancialAccountDataSchema
        //private FinancialAccountDataSchema instance;

        public FinancialAccountDataSchemaTests()
        {
            // TODO uncomment below to create an instance of FinancialAccountDataSchema
            //instance = new FinancialAccountDataSchema();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of FinancialAccountDataSchema
        /// </summary>
        [Fact]
        public void FinancialAccountDataSchemaInstanceTest()
        {
            // TODO uncomment below to test "IsType" FinancialAccountDataSchema
            //Assert.IsType<FinancialAccountDataSchema>(instance);
        }

        /// <summary>
        /// Test the property 'financialAccountId'
        /// </summary>
        [Fact]
        public void financialAccountIdTest()
        {
            // TODO unit test for the property 'financialAccountId'
        }

        /// <summary>
        /// Test the property 'interbankCardAssociationId'
        /// </summary>
        [Fact]
        public void interbankCardAssociationIdTest()
        {
            // TODO unit test for the property 'interbankCardAssociationId'
        }

        /// <summary>
        /// Test the property 'countryCode'
        /// </summary>
        [Fact]
        public void countryCodeTest()
        {
            // TODO unit test for the property 'countryCode'
        }
    }
}
