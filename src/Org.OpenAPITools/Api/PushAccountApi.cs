/*
 * Token Connect API
 *
 * The MDES APIs are designed as RPC style stateless web services where each API endpoint represents an operation to be performed. All request and response payloads are sent in the JSON (JavaScript Object Notation) data-interchange format. Each endpoint in the API specifies the HTTP Method used to access it. All strings in request and response objects are to be UTF-8 encoded. All request and response parameters are case sensitive. 
 *
 * The version of the OpenAPI document: 2.0.8
 * Contact: apisupport@mastercard.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Org.OpenAPITools.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPushAccountApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Push a Card or a Financial Account to a given Token Requestor
        /// </summary>
        /// <remarks>
        /// Used to push a Card or a Financial Account to a given Token Requestor. If the Token Requestor participates in MDES Token Connect program and if the funding account has been enabled in MDES for this Token Requestor, MDES returns the Token Requestor&#39;s URI(s) as well as a pushAccountReceipt. The Issuer can then call out one of the Token Requestor&#39;s URI, with the push receipt as parameter.&lt;br/&gt; &lt;br/&gt; This endpoint requires the usage of Mastercard client encryption librairies.  - For that, refer to [Token Connect API Security](https://developer.mastercard.com/mdes-token-connect/documentation/api-basics/#api-security) and [How to Consume the MDES Token Connect API?](https://developer.mastercard.com/mdes-token-connect/documentation/api-basics/#how-to-consume-the-mdes-token-connect-api) - Requests are expected to contain the following fields: &#x60;encryptedData&#x60;, &#x60;publicKeyFingerprint&#x60;, &#x60;encryptedKey&#x60;,&#x60;oaepHashingAlgorithm&#x60; and &#x60;iv&#x60;           - Examples of encrypted payloads can also be found in [JSON Samples](https://developer.mastercard.com/mdes-token-connect/documentation/code-and-formats/#json-samples). 
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="maj">Major parameter to be added to each path </param>
        /// <param name="pushAccountRequestData">A Push Account request is used to trigger the push of a Card or   Financial Account to a target Token Requestor </param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>PushAccountResponseData</returns>
        [Obsolete]
        PushAccountResponseData PushAccount(string maj, PushAccountRequestData pushAccountRequestData, int operationIndex = 0);

        /// <summary>
        /// Push a Card or a Financial Account to a given Token Requestor
        /// </summary>
        /// <remarks>
        /// Used to push a Card or a Financial Account to a given Token Requestor. If the Token Requestor participates in MDES Token Connect program and if the funding account has been enabled in MDES for this Token Requestor, MDES returns the Token Requestor&#39;s URI(s) as well as a pushAccountReceipt. The Issuer can then call out one of the Token Requestor&#39;s URI, with the push receipt as parameter.&lt;br/&gt; &lt;br/&gt; This endpoint requires the usage of Mastercard client encryption librairies.  - For that, refer to [Token Connect API Security](https://developer.mastercard.com/mdes-token-connect/documentation/api-basics/#api-security) and [How to Consume the MDES Token Connect API?](https://developer.mastercard.com/mdes-token-connect/documentation/api-basics/#how-to-consume-the-mdes-token-connect-api) - Requests are expected to contain the following fields: &#x60;encryptedData&#x60;, &#x60;publicKeyFingerprint&#x60;, &#x60;encryptedKey&#x60;,&#x60;oaepHashingAlgorithm&#x60; and &#x60;iv&#x60;           - Examples of encrypted payloads can also be found in [JSON Samples](https://developer.mastercard.com/mdes-token-connect/documentation/code-and-formats/#json-samples). 
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="maj">Major parameter to be added to each path </param>
        /// <param name="pushAccountRequestData">A Push Account request is used to trigger the push of a Card or   Financial Account to a target Token Requestor </param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of PushAccountResponseData</returns>
        [Obsolete]
        ApiResponse<PushAccountResponseData> PushAccountWithHttpInfo(string maj, PushAccountRequestData pushAccountRequestData, int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPushAccountApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Push a Card or a Financial Account to a given Token Requestor
        /// </summary>
        /// <remarks>
        /// Used to push a Card or a Financial Account to a given Token Requestor. If the Token Requestor participates in MDES Token Connect program and if the funding account has been enabled in MDES for this Token Requestor, MDES returns the Token Requestor&#39;s URI(s) as well as a pushAccountReceipt. The Issuer can then call out one of the Token Requestor&#39;s URI, with the push receipt as parameter.&lt;br/&gt; &lt;br/&gt; This endpoint requires the usage of Mastercard client encryption librairies.  - For that, refer to [Token Connect API Security](https://developer.mastercard.com/mdes-token-connect/documentation/api-basics/#api-security) and [How to Consume the MDES Token Connect API?](https://developer.mastercard.com/mdes-token-connect/documentation/api-basics/#how-to-consume-the-mdes-token-connect-api) - Requests are expected to contain the following fields: &#x60;encryptedData&#x60;, &#x60;publicKeyFingerprint&#x60;, &#x60;encryptedKey&#x60;,&#x60;oaepHashingAlgorithm&#x60; and &#x60;iv&#x60;           - Examples of encrypted payloads can also be found in [JSON Samples](https://developer.mastercard.com/mdes-token-connect/documentation/code-and-formats/#json-samples). 
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="maj">Major parameter to be added to each path </param>
        /// <param name="pushAccountRequestData">A Push Account request is used to trigger the push of a Card or   Financial Account to a target Token Requestor </param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PushAccountResponseData</returns>
        [Obsolete]
        System.Threading.Tasks.Task<PushAccountResponseData> PushAccountAsync(string maj, PushAccountRequestData pushAccountRequestData, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken));

        /// <summary>
        /// Push a Card or a Financial Account to a given Token Requestor
        /// </summary>
        /// <remarks>
        /// Used to push a Card or a Financial Account to a given Token Requestor. If the Token Requestor participates in MDES Token Connect program and if the funding account has been enabled in MDES for this Token Requestor, MDES returns the Token Requestor&#39;s URI(s) as well as a pushAccountReceipt. The Issuer can then call out one of the Token Requestor&#39;s URI, with the push receipt as parameter.&lt;br/&gt; &lt;br/&gt; This endpoint requires the usage of Mastercard client encryption librairies.  - For that, refer to [Token Connect API Security](https://developer.mastercard.com/mdes-token-connect/documentation/api-basics/#api-security) and [How to Consume the MDES Token Connect API?](https://developer.mastercard.com/mdes-token-connect/documentation/api-basics/#how-to-consume-the-mdes-token-connect-api) - Requests are expected to contain the following fields: &#x60;encryptedData&#x60;, &#x60;publicKeyFingerprint&#x60;, &#x60;encryptedKey&#x60;,&#x60;oaepHashingAlgorithm&#x60; and &#x60;iv&#x60;           - Examples of encrypted payloads can also be found in [JSON Samples](https://developer.mastercard.com/mdes-token-connect/documentation/code-and-formats/#json-samples). 
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="maj">Major parameter to be added to each path </param>
        /// <param name="pushAccountRequestData">A Push Account request is used to trigger the push of a Card or   Financial Account to a target Token Requestor </param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PushAccountResponseData)</returns>
        [Obsolete]
        System.Threading.Tasks.Task<ApiResponse<PushAccountResponseData>> PushAccountWithHttpInfoAsync(string maj, PushAccountRequestData pushAccountRequestData, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPushAccountApi : IPushAccountApiSync, IPushAccountApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class PushAccountApi : IPushAccountApi
    {
        private Org.OpenAPITools.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="PushAccountApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PushAccountApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PushAccountApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PushAccountApi(string basePath)
        {
            this.Configuration = Org.OpenAPITools.Client.Configuration.MergeConfigurations(
                Org.OpenAPITools.Client.GlobalConfiguration.Instance,
                new Org.OpenAPITools.Client.Configuration { BasePath = basePath }
            );
            this.Client = new Org.OpenAPITools.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Org.OpenAPITools.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = Org.OpenAPITools.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PushAccountApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public PushAccountApi(Org.OpenAPITools.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = Org.OpenAPITools.Client.Configuration.MergeConfigurations(
                Org.OpenAPITools.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new Org.OpenAPITools.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Org.OpenAPITools.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = Org.OpenAPITools.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PushAccountApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public PushAccountApi(Org.OpenAPITools.Client.ISynchronousClient client, Org.OpenAPITools.Client.IAsynchronousClient asyncClient, Org.OpenAPITools.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = Org.OpenAPITools.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public Org.OpenAPITools.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public Org.OpenAPITools.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Org.OpenAPITools.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Org.OpenAPITools.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Push a Card or a Financial Account to a given Token Requestor Used to push a Card or a Financial Account to a given Token Requestor. If the Token Requestor participates in MDES Token Connect program and if the funding account has been enabled in MDES for this Token Requestor, MDES returns the Token Requestor&#39;s URI(s) as well as a pushAccountReceipt. The Issuer can then call out one of the Token Requestor&#39;s URI, with the push receipt as parameter.&lt;br/&gt; &lt;br/&gt; This endpoint requires the usage of Mastercard client encryption librairies.  - For that, refer to [Token Connect API Security](https://developer.mastercard.com/mdes-token-connect/documentation/api-basics/#api-security) and [How to Consume the MDES Token Connect API?](https://developer.mastercard.com/mdes-token-connect/documentation/api-basics/#how-to-consume-the-mdes-token-connect-api) - Requests are expected to contain the following fields: &#x60;encryptedData&#x60;, &#x60;publicKeyFingerprint&#x60;, &#x60;encryptedKey&#x60;,&#x60;oaepHashingAlgorithm&#x60; and &#x60;iv&#x60;           - Examples of encrypted payloads can also be found in [JSON Samples](https://developer.mastercard.com/mdes-token-connect/documentation/code-and-formats/#json-samples). 
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="maj">Major parameter to be added to each path </param>
        /// <param name="pushAccountRequestData">A Push Account request is used to trigger the push of a Card or   Financial Account to a target Token Requestor </param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>PushAccountResponseData</returns>
        [Obsolete]
        public PushAccountResponseData PushAccount(string maj, PushAccountRequestData pushAccountRequestData, int operationIndex = 0)
        {
            Org.OpenAPITools.Client.ApiResponse<PushAccountResponseData> localVarResponse = PushAccountWithHttpInfo(maj, pushAccountRequestData);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Push a Card or a Financial Account to a given Token Requestor Used to push a Card or a Financial Account to a given Token Requestor. If the Token Requestor participates in MDES Token Connect program and if the funding account has been enabled in MDES for this Token Requestor, MDES returns the Token Requestor&#39;s URI(s) as well as a pushAccountReceipt. The Issuer can then call out one of the Token Requestor&#39;s URI, with the push receipt as parameter.&lt;br/&gt; &lt;br/&gt; This endpoint requires the usage of Mastercard client encryption librairies.  - For that, refer to [Token Connect API Security](https://developer.mastercard.com/mdes-token-connect/documentation/api-basics/#api-security) and [How to Consume the MDES Token Connect API?](https://developer.mastercard.com/mdes-token-connect/documentation/api-basics/#how-to-consume-the-mdes-token-connect-api) - Requests are expected to contain the following fields: &#x60;encryptedData&#x60;, &#x60;publicKeyFingerprint&#x60;, &#x60;encryptedKey&#x60;,&#x60;oaepHashingAlgorithm&#x60; and &#x60;iv&#x60;           - Examples of encrypted payloads can also be found in [JSON Samples](https://developer.mastercard.com/mdes-token-connect/documentation/code-and-formats/#json-samples). 
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="maj">Major parameter to be added to each path </param>
        /// <param name="pushAccountRequestData">A Push Account request is used to trigger the push of a Card or   Financial Account to a target Token Requestor </param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of PushAccountResponseData</returns>
        [Obsolete]
        public Org.OpenAPITools.Client.ApiResponse<PushAccountResponseData> PushAccountWithHttpInfo(string maj, PushAccountRequestData pushAccountRequestData, int operationIndex = 0)
        {
            // verify the required parameter 'maj' is set
            if (maj == null)
            {
                throw new Org.OpenAPITools.Client.ApiException(400, "Missing required parameter 'maj' when calling PushAccountApi->PushAccount");
            }

            // verify the required parameter 'pushAccountRequestData' is set
            if (pushAccountRequestData == null)
            {
                throw new Org.OpenAPITools.Client.ApiException(400, "Missing required parameter 'pushAccountRequestData' when calling PushAccountApi->PushAccount");
            }

            Org.OpenAPITools.Client.RequestOptions localVarRequestOptions = new Org.OpenAPITools.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Org.OpenAPITools.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Org.OpenAPITools.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("maj", Org.OpenAPITools.Client.ClientUtils.ParameterToString(maj)); // path parameter
            localVarRequestOptions.Data = pushAccountRequestData;

            localVarRequestOptions.Operation = "PushAccountApi.PushAccount";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Post<PushAccountResponseData>("/connect/{maj}/pushAccount", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PushAccount", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Push a Card or a Financial Account to a given Token Requestor Used to push a Card or a Financial Account to a given Token Requestor. If the Token Requestor participates in MDES Token Connect program and if the funding account has been enabled in MDES for this Token Requestor, MDES returns the Token Requestor&#39;s URI(s) as well as a pushAccountReceipt. The Issuer can then call out one of the Token Requestor&#39;s URI, with the push receipt as parameter.&lt;br/&gt; &lt;br/&gt; This endpoint requires the usage of Mastercard client encryption librairies.  - For that, refer to [Token Connect API Security](https://developer.mastercard.com/mdes-token-connect/documentation/api-basics/#api-security) and [How to Consume the MDES Token Connect API?](https://developer.mastercard.com/mdes-token-connect/documentation/api-basics/#how-to-consume-the-mdes-token-connect-api) - Requests are expected to contain the following fields: &#x60;encryptedData&#x60;, &#x60;publicKeyFingerprint&#x60;, &#x60;encryptedKey&#x60;,&#x60;oaepHashingAlgorithm&#x60; and &#x60;iv&#x60;           - Examples of encrypted payloads can also be found in [JSON Samples](https://developer.mastercard.com/mdes-token-connect/documentation/code-and-formats/#json-samples). 
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="maj">Major parameter to be added to each path </param>
        /// <param name="pushAccountRequestData">A Push Account request is used to trigger the push of a Card or   Financial Account to a target Token Requestor </param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PushAccountResponseData</returns>
        [Obsolete]
        public async System.Threading.Tasks.Task<PushAccountResponseData> PushAccountAsync(string maj, PushAccountRequestData pushAccountRequestData, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
        {
            Org.OpenAPITools.Client.ApiResponse<PushAccountResponseData> localVarResponse = await PushAccountWithHttpInfoAsync(maj, pushAccountRequestData, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Push a Card or a Financial Account to a given Token Requestor Used to push a Card or a Financial Account to a given Token Requestor. If the Token Requestor participates in MDES Token Connect program and if the funding account has been enabled in MDES for this Token Requestor, MDES returns the Token Requestor&#39;s URI(s) as well as a pushAccountReceipt. The Issuer can then call out one of the Token Requestor&#39;s URI, with the push receipt as parameter.&lt;br/&gt; &lt;br/&gt; This endpoint requires the usage of Mastercard client encryption librairies.  - For that, refer to [Token Connect API Security](https://developer.mastercard.com/mdes-token-connect/documentation/api-basics/#api-security) and [How to Consume the MDES Token Connect API?](https://developer.mastercard.com/mdes-token-connect/documentation/api-basics/#how-to-consume-the-mdes-token-connect-api) - Requests are expected to contain the following fields: &#x60;encryptedData&#x60;, &#x60;publicKeyFingerprint&#x60;, &#x60;encryptedKey&#x60;,&#x60;oaepHashingAlgorithm&#x60; and &#x60;iv&#x60;           - Examples of encrypted payloads can also be found in [JSON Samples](https://developer.mastercard.com/mdes-token-connect/documentation/code-and-formats/#json-samples). 
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="maj">Major parameter to be added to each path </param>
        /// <param name="pushAccountRequestData">A Push Account request is used to trigger the push of a Card or   Financial Account to a target Token Requestor </param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PushAccountResponseData)</returns>
        [Obsolete]
        public async System.Threading.Tasks.Task<Org.OpenAPITools.Client.ApiResponse<PushAccountResponseData>> PushAccountWithHttpInfoAsync(string maj, PushAccountRequestData pushAccountRequestData, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
        {
            // verify the required parameter 'maj' is set
            if (maj == null)
            {
                throw new Org.OpenAPITools.Client.ApiException(400, "Missing required parameter 'maj' when calling PushAccountApi->PushAccount");
            }

            // verify the required parameter 'pushAccountRequestData' is set
            if (pushAccountRequestData == null)
            {
                throw new Org.OpenAPITools.Client.ApiException(400, "Missing required parameter 'pushAccountRequestData' when calling PushAccountApi->PushAccount");
            }


            Org.OpenAPITools.Client.RequestOptions localVarRequestOptions = new Org.OpenAPITools.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Org.OpenAPITools.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Org.OpenAPITools.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("maj", Org.OpenAPITools.Client.ClientUtils.ParameterToString(maj)); // path parameter
            localVarRequestOptions.Data = pushAccountRequestData;

            localVarRequestOptions.Operation = "PushAccountApi.PushAccount";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<PushAccountResponseData>("/connect/{maj}/pushAccount", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PushAccount", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
