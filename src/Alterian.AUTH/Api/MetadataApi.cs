/*
 * Authentication API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 6.35.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using Alterian.AUTH.Client;
using Alterian.AUTH.Model;

namespace Alterian.AUTH.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IMetadataApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Returns back a list of @see(APIMetadata) objects from the system. This allows the caller to discover all the methods and class types of this API, including validation rules.
        /// </summary>
        /// <remarks>
        /// Returns back a list of @see(APIMetadata) objects from the system. This allows the caller to discover all the methods and class types of this API, including validation rules.
        /// </remarks>
        /// <exception cref="Alterian.AUTH.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="getAPIMetadataRequest">Returns back a list of @see(APIMetadata) objects from the system. This allows the caller to discover all the methods and class types of this API, including validation rules.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>GetAPIMetadataDefaultResponse</returns>
        GetAPIMetadataDefaultResponse GetAPIMetadata(GetAPIMetadataRequest getAPIMetadataRequest, int operationIndex = 0);

        /// <summary>
        /// Returns back a list of @see(APIMetadata) objects from the system. This allows the caller to discover all the methods and class types of this API, including validation rules.
        /// </summary>
        /// <remarks>
        /// Returns back a list of @see(APIMetadata) objects from the system. This allows the caller to discover all the methods and class types of this API, including validation rules.
        /// </remarks>
        /// <exception cref="Alterian.AUTH.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="getAPIMetadataRequest">Returns back a list of @see(APIMetadata) objects from the system. This allows the caller to discover all the methods and class types of this API, including validation rules.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of GetAPIMetadataDefaultResponse</returns>
        ApiResponse<GetAPIMetadataDefaultResponse> GetAPIMetadataWithHttpInfo(GetAPIMetadataRequest getAPIMetadataRequest, int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IMetadataApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Returns back a list of @see(APIMetadata) objects from the system. This allows the caller to discover all the methods and class types of this API, including validation rules.
        /// </summary>
        /// <remarks>
        /// Returns back a list of @see(APIMetadata) objects from the system. This allows the caller to discover all the methods and class types of this API, including validation rules.
        /// </remarks>
        /// <exception cref="Alterian.AUTH.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="getAPIMetadataRequest">Returns back a list of @see(APIMetadata) objects from the system. This allows the caller to discover all the methods and class types of this API, including validation rules.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of GetAPIMetadataDefaultResponse</returns>
        System.Threading.Tasks.Task<GetAPIMetadataDefaultResponse> GetAPIMetadataAsync(GetAPIMetadataRequest getAPIMetadataRequest, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Returns back a list of @see(APIMetadata) objects from the system. This allows the caller to discover all the methods and class types of this API, including validation rules.
        /// </summary>
        /// <remarks>
        /// Returns back a list of @see(APIMetadata) objects from the system. This allows the caller to discover all the methods and class types of this API, including validation rules.
        /// </remarks>
        /// <exception cref="Alterian.AUTH.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="getAPIMetadataRequest">Returns back a list of @see(APIMetadata) objects from the system. This allows the caller to discover all the methods and class types of this API, including validation rules.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (GetAPIMetadataDefaultResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<GetAPIMetadataDefaultResponse>> GetAPIMetadataWithHttpInfoAsync(GetAPIMetadataRequest getAPIMetadataRequest, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IMetadataApi : IMetadataApiSync, IMetadataApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class MetadataApi : IMetadataApi
    {
        private Alterian.AUTH.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataApi"/> class.
        /// </summary>
        /// <returns></returns>
        public MetadataApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataApi"/> class.
        /// </summary>
        /// <returns></returns>
        public MetadataApi(string basePath)
        {
            this.Configuration = Alterian.AUTH.Client.Configuration.MergeConfigurations(
                Alterian.AUTH.Client.GlobalConfiguration.Instance,
                new Alterian.AUTH.Client.Configuration { BasePath = basePath }
            );
            this.Client = new Alterian.AUTH.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Alterian.AUTH.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = Alterian.AUTH.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public MetadataApi(Alterian.AUTH.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = Alterian.AUTH.Client.Configuration.MergeConfigurations(
                Alterian.AUTH.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new Alterian.AUTH.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Alterian.AUTH.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = Alterian.AUTH.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public MetadataApi(Alterian.AUTH.Client.ISynchronousClient client, Alterian.AUTH.Client.IAsynchronousClient asyncClient, Alterian.AUTH.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = Alterian.AUTH.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public Alterian.AUTH.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public Alterian.AUTH.Client.ISynchronousClient Client { get; set; }

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
        public Alterian.AUTH.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Alterian.AUTH.Client.ExceptionFactory ExceptionFactory
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
        /// Returns back a list of @see(APIMetadata) objects from the system. This allows the caller to discover all the methods and class types of this API, including validation rules. Returns back a list of @see(APIMetadata) objects from the system. This allows the caller to discover all the methods and class types of this API, including validation rules.
        /// </summary>
        /// <exception cref="Alterian.AUTH.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="getAPIMetadataRequest">Returns back a list of @see(APIMetadata) objects from the system. This allows the caller to discover all the methods and class types of this API, including validation rules.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>GetAPIMetadataDefaultResponse</returns>
        public GetAPIMetadataDefaultResponse GetAPIMetadata(GetAPIMetadataRequest getAPIMetadataRequest, int operationIndex = 0)
        {
            Alterian.AUTH.Client.ApiResponse<GetAPIMetadataDefaultResponse> localVarResponse = GetAPIMetadataWithHttpInfo(getAPIMetadataRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Returns back a list of @see(APIMetadata) objects from the system. This allows the caller to discover all the methods and class types of this API, including validation rules. Returns back a list of @see(APIMetadata) objects from the system. This allows the caller to discover all the methods and class types of this API, including validation rules.
        /// </summary>
        /// <exception cref="Alterian.AUTH.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="getAPIMetadataRequest">Returns back a list of @see(APIMetadata) objects from the system. This allows the caller to discover all the methods and class types of this API, including validation rules.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of GetAPIMetadataDefaultResponse</returns>
        public Alterian.AUTH.Client.ApiResponse<GetAPIMetadataDefaultResponse> GetAPIMetadataWithHttpInfo(GetAPIMetadataRequest getAPIMetadataRequest, int operationIndex = 0)
        {
            // verify the required parameter 'getAPIMetadataRequest' is set
            if (getAPIMetadataRequest == null)
            {
                throw new Alterian.AUTH.Client.ApiException(400, "Missing required parameter 'getAPIMetadataRequest' when calling MetadataApi->GetAPIMetadata");
            }

            Alterian.AUTH.Client.RequestOptions localVarRequestOptions = new Alterian.AUTH.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Alterian.AUTH.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Alterian.AUTH.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.Data = getAPIMetadataRequest;

            localVarRequestOptions.Operation = "MetadataApi.GetAPIMetadata";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (TokenAuth) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("X-Api-Key")))
            {
                localVarRequestOptions.HeaderParameters.Add("X-Api-Key", this.Configuration.GetApiKeyWithPrefix("X-Api-Key"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<GetAPIMetadataDefaultResponse>("/GetAPIMetadata", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetAPIMetadata", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Returns back a list of @see(APIMetadata) objects from the system. This allows the caller to discover all the methods and class types of this API, including validation rules. Returns back a list of @see(APIMetadata) objects from the system. This allows the caller to discover all the methods and class types of this API, including validation rules.
        /// </summary>
        /// <exception cref="Alterian.AUTH.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="getAPIMetadataRequest">Returns back a list of @see(APIMetadata) objects from the system. This allows the caller to discover all the methods and class types of this API, including validation rules.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of GetAPIMetadataDefaultResponse</returns>
        public async System.Threading.Tasks.Task<GetAPIMetadataDefaultResponse> GetAPIMetadataAsync(GetAPIMetadataRequest getAPIMetadataRequest, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Alterian.AUTH.Client.ApiResponse<GetAPIMetadataDefaultResponse> localVarResponse = await GetAPIMetadataWithHttpInfoAsync(getAPIMetadataRequest, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Returns back a list of @see(APIMetadata) objects from the system. This allows the caller to discover all the methods and class types of this API, including validation rules. Returns back a list of @see(APIMetadata) objects from the system. This allows the caller to discover all the methods and class types of this API, including validation rules.
        /// </summary>
        /// <exception cref="Alterian.AUTH.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="getAPIMetadataRequest">Returns back a list of @see(APIMetadata) objects from the system. This allows the caller to discover all the methods and class types of this API, including validation rules.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (GetAPIMetadataDefaultResponse)</returns>
        public async System.Threading.Tasks.Task<Alterian.AUTH.Client.ApiResponse<GetAPIMetadataDefaultResponse>> GetAPIMetadataWithHttpInfoAsync(GetAPIMetadataRequest getAPIMetadataRequest, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'getAPIMetadataRequest' is set
            if (getAPIMetadataRequest == null)
            {
                throw new Alterian.AUTH.Client.ApiException(400, "Missing required parameter 'getAPIMetadataRequest' when calling MetadataApi->GetAPIMetadata");
            }


            Alterian.AUTH.Client.RequestOptions localVarRequestOptions = new Alterian.AUTH.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Alterian.AUTH.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Alterian.AUTH.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.Data = getAPIMetadataRequest;

            localVarRequestOptions.Operation = "MetadataApi.GetAPIMetadata";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (TokenAuth) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("X-Api-Key")))
            {
                localVarRequestOptions.HeaderParameters.Add("X-Api-Key", this.Configuration.GetApiKeyWithPrefix("X-Api-Key"));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<GetAPIMetadataDefaultResponse>("/GetAPIMetadata", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetAPIMetadata", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}