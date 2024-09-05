/*
 * Mastercard Digital Enablement Service Issuer Outbound API
 *
 * The MDES Issuer Outbound Pre-Digitization API supports the pre-digitization web services provided by the Digitization Service. The web services are used to inform Issuers of MDES services being requested by, or on-behalf of, their account holders. Issuers may provide information in their responses to guide or inform the Account holder’s experience through the Token Reqestor.
 *
 * The version of the OpenAPI document: 2.0.21 (Document version)
 * Contact: apisupport@mastercard.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;

namespace Org.OpenAPITools.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDeliverActivationCodeApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Used to deliver an Activation Code to authenticate the Account holder.
        /// </summary>
        /// <remarks>
        /// DeliverActivationCode is used to request an Activation Code be sent to authenticate the Account holder. MDES generates an Activation Code and delivers it, along with the chosen Activation Code Distribution Method, to the Issuer for transmission to the Account holder.  Alternately if the Issuer wishes to generate the Activation Code, MDES will deliver the chosen Activation Code Distribution Method to the Issuer and the Issuer will generate the Activation code and transmit it to the account holder. The Account holder will then enter the Activation Code into the Mobile Payment App. Once an Activation Code has been generated, it will be valid for a limited activation period, after which the code will expire. Once a code expires, the Issuer can request a new Activation Code via the Customer Service Portal/API, or remotely activate the token via the Customer Service Portal/API. The Account holder may request the Activation Code again with the same or a different Activation Code Distribution Method.  This will trigger another request as long as the activation period has not expired.  It will not cause the Activation Code to be regenerated nor extend the validity period of the Activation Code.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deliverActivationCodeRequestSchema">Contains the details of the request message.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>DeliverActivationCodeResponseSchema</returns>
        DeliverActivationCodeResponseSchema DeliverActivationCode(DeliverActivationCodeRequestSchema deliverActivationCodeRequestSchema, int operationIndex = 0);

        /// <summary>
        /// Used to deliver an Activation Code to authenticate the Account holder.
        /// </summary>
        /// <remarks>
        /// DeliverActivationCode is used to request an Activation Code be sent to authenticate the Account holder. MDES generates an Activation Code and delivers it, along with the chosen Activation Code Distribution Method, to the Issuer for transmission to the Account holder.  Alternately if the Issuer wishes to generate the Activation Code, MDES will deliver the chosen Activation Code Distribution Method to the Issuer and the Issuer will generate the Activation code and transmit it to the account holder. The Account holder will then enter the Activation Code into the Mobile Payment App. Once an Activation Code has been generated, it will be valid for a limited activation period, after which the code will expire. Once a code expires, the Issuer can request a new Activation Code via the Customer Service Portal/API, or remotely activate the token via the Customer Service Portal/API. The Account holder may request the Activation Code again with the same or a different Activation Code Distribution Method.  This will trigger another request as long as the activation period has not expired.  It will not cause the Activation Code to be regenerated nor extend the validity period of the Activation Code.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deliverActivationCodeRequestSchema">Contains the details of the request message.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of DeliverActivationCodeResponseSchema</returns>
        ApiResponse<DeliverActivationCodeResponseSchema> DeliverActivationCodeWithHttpInfo(DeliverActivationCodeRequestSchema deliverActivationCodeRequestSchema, int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDeliverActivationCodeApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Used to deliver an Activation Code to authenticate the Account holder.
        /// </summary>
        /// <remarks>
        /// DeliverActivationCode is used to request an Activation Code be sent to authenticate the Account holder. MDES generates an Activation Code and delivers it, along with the chosen Activation Code Distribution Method, to the Issuer for transmission to the Account holder.  Alternately if the Issuer wishes to generate the Activation Code, MDES will deliver the chosen Activation Code Distribution Method to the Issuer and the Issuer will generate the Activation code and transmit it to the account holder. The Account holder will then enter the Activation Code into the Mobile Payment App. Once an Activation Code has been generated, it will be valid for a limited activation period, after which the code will expire. Once a code expires, the Issuer can request a new Activation Code via the Customer Service Portal/API, or remotely activate the token via the Customer Service Portal/API. The Account holder may request the Activation Code again with the same or a different Activation Code Distribution Method.  This will trigger another request as long as the activation period has not expired.  It will not cause the Activation Code to be regenerated nor extend the validity period of the Activation Code.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deliverActivationCodeRequestSchema">Contains the details of the request message.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DeliverActivationCodeResponseSchema</returns>
        System.Threading.Tasks.Task<DeliverActivationCodeResponseSchema> DeliverActivationCodeAsync(DeliverActivationCodeRequestSchema deliverActivationCodeRequestSchema, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken));

        /// <summary>
        /// Used to deliver an Activation Code to authenticate the Account holder.
        /// </summary>
        /// <remarks>
        /// DeliverActivationCode is used to request an Activation Code be sent to authenticate the Account holder. MDES generates an Activation Code and delivers it, along with the chosen Activation Code Distribution Method, to the Issuer for transmission to the Account holder.  Alternately if the Issuer wishes to generate the Activation Code, MDES will deliver the chosen Activation Code Distribution Method to the Issuer and the Issuer will generate the Activation code and transmit it to the account holder. The Account holder will then enter the Activation Code into the Mobile Payment App. Once an Activation Code has been generated, it will be valid for a limited activation period, after which the code will expire. Once a code expires, the Issuer can request a new Activation Code via the Customer Service Portal/API, or remotely activate the token via the Customer Service Portal/API. The Account holder may request the Activation Code again with the same or a different Activation Code Distribution Method.  This will trigger another request as long as the activation period has not expired.  It will not cause the Activation Code to be regenerated nor extend the validity period of the Activation Code.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deliverActivationCodeRequestSchema">Contains the details of the request message.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DeliverActivationCodeResponseSchema)</returns>
        System.Threading.Tasks.Task<ApiResponse<DeliverActivationCodeResponseSchema>> DeliverActivationCodeWithHttpInfoAsync(DeliverActivationCodeRequestSchema deliverActivationCodeRequestSchema, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDeliverActivationCodeApi : IDeliverActivationCodeApiSync, IDeliverActivationCodeApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class DeliverActivationCodeApi : IDeliverActivationCodeApi
    {
        private Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="DeliverActivationCodeApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DeliverActivationCodeApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeliverActivationCodeApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DeliverActivationCodeApi(string basePath)
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
        /// Initializes a new instance of the <see cref="DeliverActivationCodeApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public DeliverActivationCodeApi(Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="DeliverActivationCodeApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public DeliverActivationCodeApi(Client.ISynchronousClient client, Client.IAsynchronousClient asyncClient,Client.IReadableConfiguration configuration)
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
        public Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public  Client.ISynchronousClient Client { get; set; }

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
        public Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public ExceptionFactory ExceptionFactory
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
        /// Used to deliver an Activation Code to authenticate the Account holder. DeliverActivationCode is used to request an Activation Code be sent to authenticate the Account holder. MDES generates an Activation Code and delivers it, along with the chosen Activation Code Distribution Method, to the Issuer for transmission to the Account holder.  Alternately if the Issuer wishes to generate the Activation Code, MDES will deliver the chosen Activation Code Distribution Method to the Issuer and the Issuer will generate the Activation code and transmit it to the account holder. The Account holder will then enter the Activation Code into the Mobile Payment App. Once an Activation Code has been generated, it will be valid for a limited activation period, after which the code will expire. Once a code expires, the Issuer can request a new Activation Code via the Customer Service Portal/API, or remotely activate the token via the Customer Service Portal/API. The Account holder may request the Activation Code again with the same or a different Activation Code Distribution Method.  This will trigger another request as long as the activation period has not expired.  It will not cause the Activation Code to be regenerated nor extend the validity period of the Activation Code.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deliverActivationCodeRequestSchema">Contains the details of the request message.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>DeliverActivationCodeResponseSchema</returns>
        public DeliverActivationCodeResponseSchema DeliverActivationCode(DeliverActivationCodeRequestSchema deliverActivationCodeRequestSchema, int operationIndex = 0)
        {
            Client.ApiResponse<DeliverActivationCodeResponseSchema> localVarResponse = DeliverActivationCodeWithHttpInfo(deliverActivationCodeRequestSchema);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Used to deliver an Activation Code to authenticate the Account holder. DeliverActivationCode is used to request an Activation Code be sent to authenticate the Account holder. MDES generates an Activation Code and delivers it, along with the chosen Activation Code Distribution Method, to the Issuer for transmission to the Account holder.  Alternately if the Issuer wishes to generate the Activation Code, MDES will deliver the chosen Activation Code Distribution Method to the Issuer and the Issuer will generate the Activation code and transmit it to the account holder. The Account holder will then enter the Activation Code into the Mobile Payment App. Once an Activation Code has been generated, it will be valid for a limited activation period, after which the code will expire. Once a code expires, the Issuer can request a new Activation Code via the Customer Service Portal/API, or remotely activate the token via the Customer Service Portal/API. The Account holder may request the Activation Code again with the same or a different Activation Code Distribution Method.  This will trigger another request as long as the activation period has not expired.  It will not cause the Activation Code to be regenerated nor extend the validity period of the Activation Code.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deliverActivationCodeRequestSchema">Contains the details of the request message.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of DeliverActivationCodeResponseSchema</returns>
        public Client.ApiResponse<DeliverActivationCodeResponseSchema> DeliverActivationCodeWithHttpInfo(DeliverActivationCodeRequestSchema deliverActivationCodeRequestSchema, int operationIndex = 0)
        {
            // verify the required parameter 'deliverActivationCodeRequestSchema' is set
            if (deliverActivationCodeRequestSchema == null)
            {
                throw new Client.ApiException(400, "Missing required parameter 'deliverActivationCodeRequestSchema' when calling DeliverActivationCodeApi->DeliverActivationCode");
            }

            Client.RequestOptions localVarRequestOptions = new Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType =   ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept =    ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.Data = deliverActivationCodeRequestSchema;

            localVarRequestOptions.Operation = "DeliverActivationCodeApi.DeliverActivationCode";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Post<DeliverActivationCodeResponseSchema>("/deliverActivationCode", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeliverActivationCode", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Used to deliver an Activation Code to authenticate the Account holder. DeliverActivationCode is used to request an Activation Code be sent to authenticate the Account holder. MDES generates an Activation Code and delivers it, along with the chosen Activation Code Distribution Method, to the Issuer for transmission to the Account holder.  Alternately if the Issuer wishes to generate the Activation Code, MDES will deliver the chosen Activation Code Distribution Method to the Issuer and the Issuer will generate the Activation code and transmit it to the account holder. The Account holder will then enter the Activation Code into the Mobile Payment App. Once an Activation Code has been generated, it will be valid for a limited activation period, after which the code will expire. Once a code expires, the Issuer can request a new Activation Code via the Customer Service Portal/API, or remotely activate the token via the Customer Service Portal/API. The Account holder may request the Activation Code again with the same or a different Activation Code Distribution Method.  This will trigger another request as long as the activation period has not expired.  It will not cause the Activation Code to be regenerated nor extend the validity period of the Activation Code.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deliverActivationCodeRequestSchema">Contains the details of the request message.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DeliverActivationCodeResponseSchema</returns>
        public async System.Threading.Tasks.Task<DeliverActivationCodeResponseSchema> DeliverActivationCodeAsync(DeliverActivationCodeRequestSchema deliverActivationCodeRequestSchema, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
        {
            Client.ApiResponse<DeliverActivationCodeResponseSchema> localVarResponse = await DeliverActivationCodeWithHttpInfoAsync(deliverActivationCodeRequestSchema, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Used to deliver an Activation Code to authenticate the Account holder. DeliverActivationCode is used to request an Activation Code be sent to authenticate the Account holder. MDES generates an Activation Code and delivers it, along with the chosen Activation Code Distribution Method, to the Issuer for transmission to the Account holder.  Alternately if the Issuer wishes to generate the Activation Code, MDES will deliver the chosen Activation Code Distribution Method to the Issuer and the Issuer will generate the Activation code and transmit it to the account holder. The Account holder will then enter the Activation Code into the Mobile Payment App. Once an Activation Code has been generated, it will be valid for a limited activation period, after which the code will expire. Once a code expires, the Issuer can request a new Activation Code via the Customer Service Portal/API, or remotely activate the token via the Customer Service Portal/API. The Account holder may request the Activation Code again with the same or a different Activation Code Distribution Method.  This will trigger another request as long as the activation period has not expired.  It will not cause the Activation Code to be regenerated nor extend the validity period of the Activation Code.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deliverActivationCodeRequestSchema">Contains the details of the request message.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DeliverActivationCodeResponseSchema)</returns>
        public async System.Threading.Tasks.Task<Client.ApiResponse<DeliverActivationCodeResponseSchema>> DeliverActivationCodeWithHttpInfoAsync(DeliverActivationCodeRequestSchema deliverActivationCodeRequestSchema, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
        {
            // verify the required parameter 'deliverActivationCodeRequestSchema' is set
            if (deliverActivationCodeRequestSchema == null)
            {
                throw new Client.ApiException(400, "Missing required parameter 'deliverActivationCodeRequestSchema' when calling DeliverActivationCodeApi->DeliverActivationCode");
            }


            Client.RequestOptions localVarRequestOptions = new Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.Data = deliverActivationCodeRequestSchema;

            localVarRequestOptions.Operation = "DeliverActivationCodeApi.DeliverActivationCode";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<DeliverActivationCodeResponseSchema>("/deliverActivationCode", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeliverActivationCode", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
