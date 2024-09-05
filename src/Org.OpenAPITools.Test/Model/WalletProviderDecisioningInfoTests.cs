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
    ///  Class for testing WalletProviderDecisioningInfo
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class WalletProviderDecisioningInfoTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for WalletProviderDecisioningInfo
        //private WalletProviderDecisioningInfo instance;

        public WalletProviderDecisioningInfoTests()
        {
            // TODO uncomment below to create an instance of WalletProviderDecisioningInfo
            //instance = new WalletProviderDecisioningInfo();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of WalletProviderDecisioningInfo
        /// </summary>
        [Fact]
        public void WalletProviderDecisioningInfoInstanceTest()
        {
            // TODO uncomment below to test "IsType" WalletProviderDecisioningInfo
            //Assert.IsType<WalletProviderDecisioningInfo>(instance);
        }

        /// <summary>
        /// Test the property 'recommendedDecision'
        /// </summary>
        [Fact]
        public void recommendedDecisionTest()
        {
            // TODO unit test for the property 'recommendedDecision'
        }

        /// <summary>
        /// Test the property 'recommendationStandardVersion'
        /// </summary>
        [Fact]
        public void recommendationStandardVersionTest()
        {
            // TODO unit test for the property 'recommendationStandardVersion'
        }

        /// <summary>
        /// Test the property 'deviceScore'
        /// </summary>
        [Fact]
        public void deviceScoreTest()
        {
            // TODO unit test for the property 'deviceScore'
        }

        /// <summary>
        /// Test the property 'accountScore'
        /// </summary>
        [Fact]
        public void accountScoreTest()
        {
            // TODO unit test for the property 'accountScore'
        }

        /// <summary>
        /// Test the property 'phoneNumberScore'
        /// </summary>
        [Fact]
        public void phoneNumberScoreTest()
        {
            // TODO unit test for the property 'phoneNumberScore'
        }

        /// <summary>
        /// Test the property 'accountLifeTime'
        /// </summary>
        [Fact]
        public void accountLifeTimeTest()
        {
            // TODO unit test for the property 'accountLifeTime'
        }

        /// <summary>
        /// Test the property 'recommendationReasons'
        /// </summary>
        [Fact]
        public void recommendationReasonsTest()
        {
            // TODO unit test for the property 'recommendationReasons'
        }
    }
}
