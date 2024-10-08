/*
 * Authentication Facilitator API
 *
 * This API provides our Issuer partners with authentication codes they have to deliver to their cardholders.
 *
 * The version of the OpenAPI document: 1.2
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
    public interface IDeliverAuthenticationCodeApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// deliverAuthenticationCode is used to request an Authentication Code be sent to authenticate the Account holder. Upon an Authentication Service request, the Authentication Service generates an Authentication Code and delivers it to the Issuer for transmission to the Account holder. The Issuer can choose a default channel to transmit the code to the account holder. The account holder will then enter the Authentication Code into the Authentication Service client. Once an Authentication Code has been generated, it will be valid for a limited period after which the code will expire. Once a code expires, there is no means for an Issuer to request a new code. The account holder may request the Authentication Code again. This will trigger another Deliver Authentication Code request. If the current Authentication Code is still valid then the code will not be regenerated nor the validity period extended. If the Code has expired or too many attempts have failed validation then a new code will be generated.
        /// </summary>
        /// <remarks>
        /// The apiName is &#39;deliverAuthenticationCode&#39;. A Deliver Authentication Code message is used to notify an authentication code is to send to the account holder associated to the funding account information. 
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deliverAuthenticationCodeRequestSchema">Deliver Authentication Code request.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>DeliverAuthenticationCodeResponseSchema</returns>
        DeliverAuthenticationCodeResponseSchema DeliverAuthenticationCode(DeliverAuthenticationCodeRequestSchema deliverAuthenticationCodeRequestSchema, int operationIndex = 0);

        /// <summary>
        /// deliverAuthenticationCode is used to request an Authentication Code be sent to authenticate the Account holder. Upon an Authentication Service request, the Authentication Service generates an Authentication Code and delivers it to the Issuer for transmission to the Account holder. The Issuer can choose a default channel to transmit the code to the account holder. The account holder will then enter the Authentication Code into the Authentication Service client. Once an Authentication Code has been generated, it will be valid for a limited period after which the code will expire. Once a code expires, there is no means for an Issuer to request a new code. The account holder may request the Authentication Code again. This will trigger another Deliver Authentication Code request. If the current Authentication Code is still valid then the code will not be regenerated nor the validity period extended. If the Code has expired or too many attempts have failed validation then a new code will be generated.
        /// </summary>
        /// <remarks>
        /// The apiName is &#39;deliverAuthenticationCode&#39;. A Deliver Authentication Code message is used to notify an authentication code is to send to the account holder associated to the funding account information. 
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deliverAuthenticationCodeRequestSchema">Deliver Authentication Code request.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of DeliverAuthenticationCodeResponseSchema</returns>
        ApiResponse<DeliverAuthenticationCodeResponseSchema> DeliverAuthenticationCodeWithHttpInfo(DeliverAuthenticationCodeRequestSchema deliverAuthenticationCodeRequestSchema, int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDeliverAuthenticationCodeApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// deliverAuthenticationCode is used to request an Authentication Code be sent to authenticate the Account holder. Upon an Authentication Service request, the Authentication Service generates an Authentication Code and delivers it to the Issuer for transmission to the Account holder. The Issuer can choose a default channel to transmit the code to the account holder. The account holder will then enter the Authentication Code into the Authentication Service client. Once an Authentication Code has been generated, it will be valid for a limited period after which the code will expire. Once a code expires, there is no means for an Issuer to request a new code. The account holder may request the Authentication Code again. This will trigger another Deliver Authentication Code request. If the current Authentication Code is still valid then the code will not be regenerated nor the validity period extended. If the Code has expired or too many attempts have failed validation then a new code will be generated.
        /// </summary>
        /// <remarks>
        /// The apiName is &#39;deliverAuthenticationCode&#39;. A Deliver Authentication Code message is used to notify an authentication code is to send to the account holder associated to the funding account information. 
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deliverAuthenticationCodeRequestSchema">Deliver Authentication Code request.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DeliverAuthenticationCodeResponseSchema</returns>
        System.Threading.Tasks.Task<DeliverAuthenticationCodeResponseSchema> DeliverAuthenticationCodeAsync(DeliverAuthenticationCodeRequestSchema deliverAuthenticationCodeRequestSchema, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken));

        /// <summary>
        /// deliverAuthenticationCode is used to request an Authentication Code be sent to authenticate the Account holder. Upon an Authentication Service request, the Authentication Service generates an Authentication Code and delivers it to the Issuer for transmission to the Account holder. The Issuer can choose a default channel to transmit the code to the account holder. The account holder will then enter the Authentication Code into the Authentication Service client. Once an Authentication Code has been generated, it will be valid for a limited period after which the code will expire. Once a code expires, there is no means for an Issuer to request a new code. The account holder may request the Authentication Code again. This will trigger another Deliver Authentication Code request. If the current Authentication Code is still valid then the code will not be regenerated nor the validity period extended. If the Code has expired or too many attempts have failed validation then a new code will be generated.
        /// </summary>
        /// <remarks>
        /// The apiName is &#39;deliverAuthenticationCode&#39;. A Deliver Authentication Code message is used to notify an authentication code is to send to the account holder associated to the funding account information. 
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deliverAuthenticationCodeRequestSchema">Deliver Authentication Code request.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DeliverAuthenticationCodeResponseSchema)</returns>
        System.Threading.Tasks.Task<ApiResponse<DeliverAuthenticationCodeResponseSchema>> DeliverAuthenticationCodeWithHttpInfoAsync(DeliverAuthenticationCodeRequestSchema deliverAuthenticationCodeRequestSchema, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDeliverAuthenticationCodeApi : IDeliverAuthenticationCodeApiSync, IDeliverAuthenticationCodeApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class DeliverAuthenticationCodeApi : IDeliverAuthenticationCodeApi
    {
        private Org.OpenAPITools.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="DeliverAuthenticationCodeApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DeliverAuthenticationCodeApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeliverAuthenticationCodeApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DeliverAuthenticationCodeApi(string basePath)
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
        /// Initializes a new instance of the <see cref="DeliverAuthenticationCodeApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public DeliverAuthenticationCodeApi(Org.OpenAPITools.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="DeliverAuthenticationCodeApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public DeliverAuthenticationCodeApi(Org.OpenAPITools.Client.ISynchronousClient client, Org.OpenAPITools.Client.IAsynchronousClient asyncClient, Org.OpenAPITools.Client.IReadableConfiguration configuration)
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
        /// deliverAuthenticationCode is used to request an Authentication Code be sent to authenticate the Account holder. Upon an Authentication Service request, the Authentication Service generates an Authentication Code and delivers it to the Issuer for transmission to the Account holder. The Issuer can choose a default channel to transmit the code to the account holder. The account holder will then enter the Authentication Code into the Authentication Service client. Once an Authentication Code has been generated, it will be valid for a limited period after which the code will expire. Once a code expires, there is no means for an Issuer to request a new code. The account holder may request the Authentication Code again. This will trigger another Deliver Authentication Code request. If the current Authentication Code is still valid then the code will not be regenerated nor the validity period extended. If the Code has expired or too many attempts have failed validation then a new code will be generated. The apiName is &#39;deliverAuthenticationCode&#39;. A Deliver Authentication Code message is used to notify an authentication code is to send to the account holder associated to the funding account information. 
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deliverAuthenticationCodeRequestSchema">Deliver Authentication Code request.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>DeliverAuthenticationCodeResponseSchema</returns>
        public DeliverAuthenticationCodeResponseSchema DeliverAuthenticationCode(DeliverAuthenticationCodeRequestSchema deliverAuthenticationCodeRequestSchema, int operationIndex = 0)
        {
            Org.OpenAPITools.Client.ApiResponse<DeliverAuthenticationCodeResponseSchema> localVarResponse = DeliverAuthenticationCodeWithHttpInfo(deliverAuthenticationCodeRequestSchema);
            return localVarResponse.Data;
        }

        /// <summary>
        /// deliverAuthenticationCode is used to request an Authentication Code be sent to authenticate the Account holder. Upon an Authentication Service request, the Authentication Service generates an Authentication Code and delivers it to the Issuer for transmission to the Account holder. The Issuer can choose a default channel to transmit the code to the account holder. The account holder will then enter the Authentication Code into the Authentication Service client. Once an Authentication Code has been generated, it will be valid for a limited period after which the code will expire. Once a code expires, there is no means for an Issuer to request a new code. The account holder may request the Authentication Code again. This will trigger another Deliver Authentication Code request. If the current Authentication Code is still valid then the code will not be regenerated nor the validity period extended. If the Code has expired or too many attempts have failed validation then a new code will be generated. The apiName is &#39;deliverAuthenticationCode&#39;. A Deliver Authentication Code message is used to notify an authentication code is to send to the account holder associated to the funding account information. 
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deliverAuthenticationCodeRequestSchema">Deliver Authentication Code request.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of DeliverAuthenticationCodeResponseSchema</returns>
        public Org.OpenAPITools.Client.ApiResponse<DeliverAuthenticationCodeResponseSchema> DeliverAuthenticationCodeWithHttpInfo(DeliverAuthenticationCodeRequestSchema deliverAuthenticationCodeRequestSchema, int operationIndex = 0)
        {
            // verify the required parameter 'deliverAuthenticationCodeRequestSchema' is set
            if (deliverAuthenticationCodeRequestSchema == null)
            {
                throw new Org.OpenAPITools.Client.ApiException(400, "Missing required parameter 'deliverAuthenticationCodeRequestSchema' when calling DeliverAuthenticationCodeApi->DeliverAuthenticationCode");
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

            localVarRequestOptions.Data = deliverAuthenticationCodeRequestSchema;

            localVarRequestOptions.Operation = "DeliverAuthenticationCodeApi.DeliverAuthenticationCode";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Post<DeliverAuthenticationCodeResponseSchema>("/deliverAuthenticationCode", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeliverAuthenticationCode", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// deliverAuthenticationCode is used to request an Authentication Code be sent to authenticate the Account holder. Upon an Authentication Service request, the Authentication Service generates an Authentication Code and delivers it to the Issuer for transmission to the Account holder. The Issuer can choose a default channel to transmit the code to the account holder. The account holder will then enter the Authentication Code into the Authentication Service client. Once an Authentication Code has been generated, it will be valid for a limited period after which the code will expire. Once a code expires, there is no means for an Issuer to request a new code. The account holder may request the Authentication Code again. This will trigger another Deliver Authentication Code request. If the current Authentication Code is still valid then the code will not be regenerated nor the validity period extended. If the Code has expired or too many attempts have failed validation then a new code will be generated. The apiName is &#39;deliverAuthenticationCode&#39;. A Deliver Authentication Code message is used to notify an authentication code is to send to the account holder associated to the funding account information. 
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deliverAuthenticationCodeRequestSchema">Deliver Authentication Code request.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DeliverAuthenticationCodeResponseSchema</returns>
        public async System.Threading.Tasks.Task<DeliverAuthenticationCodeResponseSchema> DeliverAuthenticationCodeAsync(DeliverAuthenticationCodeRequestSchema deliverAuthenticationCodeRequestSchema, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
        {
            Org.OpenAPITools.Client.ApiResponse<DeliverAuthenticationCodeResponseSchema> localVarResponse = await DeliverAuthenticationCodeWithHttpInfoAsync(deliverAuthenticationCodeRequestSchema, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// deliverAuthenticationCode is used to request an Authentication Code be sent to authenticate the Account holder. Upon an Authentication Service request, the Authentication Service generates an Authentication Code and delivers it to the Issuer for transmission to the Account holder. The Issuer can choose a default channel to transmit the code to the account holder. The account holder will then enter the Authentication Code into the Authentication Service client. Once an Authentication Code has been generated, it will be valid for a limited period after which the code will expire. Once a code expires, there is no means for an Issuer to request a new code. The account holder may request the Authentication Code again. This will trigger another Deliver Authentication Code request. If the current Authentication Code is still valid then the code will not be regenerated nor the validity period extended. If the Code has expired or too many attempts have failed validation then a new code will be generated. The apiName is &#39;deliverAuthenticationCode&#39;. A Deliver Authentication Code message is used to notify an authentication code is to send to the account holder associated to the funding account information. 
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deliverAuthenticationCodeRequestSchema">Deliver Authentication Code request.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DeliverAuthenticationCodeResponseSchema)</returns>
        public async System.Threading.Tasks.Task<Org.OpenAPITools.Client.ApiResponse<DeliverAuthenticationCodeResponseSchema>> DeliverAuthenticationCodeWithHttpInfoAsync(DeliverAuthenticationCodeRequestSchema deliverAuthenticationCodeRequestSchema, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
        {
            // verify the required parameter 'deliverAuthenticationCodeRequestSchema' is set
            if (deliverAuthenticationCodeRequestSchema == null)
            {
                throw new Org.OpenAPITools.Client.ApiException(400, "Missing required parameter 'deliverAuthenticationCodeRequestSchema' when calling DeliverAuthenticationCodeApi->DeliverAuthenticationCode");
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

            localVarRequestOptions.Data = deliverAuthenticationCodeRequestSchema;

            localVarRequestOptions.Operation = "DeliverAuthenticationCodeApi.DeliverAuthenticationCode";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<DeliverAuthenticationCodeResponseSchema>("/deliverAuthenticationCode", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeliverAuthenticationCode", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
