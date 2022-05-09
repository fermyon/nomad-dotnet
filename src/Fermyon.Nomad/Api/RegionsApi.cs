/*
 * Nomad
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.1.4
 * Contact: support@hashicorp.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using Fermyon.Nomad.Client;

namespace Fermyon.Nomad.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IRegionsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="Fermyon.Nomad.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>List&lt;string&gt;</returns>
        List<string> GetRegions(int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Fermyon.Nomad.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of List&lt;string&gt;</returns>
        ApiResponse<List<string>> GetRegionsWithHttpInfo(int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IRegionsApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Fermyon.Nomad.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;string&gt;</returns>
        System.Threading.Tasks.Task<List<string>> GetRegionsAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Fermyon.Nomad.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;string&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<string>>> GetRegionsWithHttpInfoAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IRegionsApi : IRegionsApiSync, IRegionsApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class RegionsApi : IRegionsApi
    {
        private Fermyon.Nomad.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="RegionsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public RegionsApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RegionsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public RegionsApi(string basePath)
        {
            this.Configuration = Fermyon.Nomad.Client.Configuration.MergeConfigurations(
                Fermyon.Nomad.Client.GlobalConfiguration.Instance,
                new Fermyon.Nomad.Client.Configuration { BasePath = basePath }
            );
            this.Client = new Fermyon.Nomad.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Fermyon.Nomad.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = Fermyon.Nomad.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RegionsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public RegionsApi(Fermyon.Nomad.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = Fermyon.Nomad.Client.Configuration.MergeConfigurations(
                Fermyon.Nomad.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new Fermyon.Nomad.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Fermyon.Nomad.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = Fermyon.Nomad.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RegionsApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public RegionsApi(Fermyon.Nomad.Client.ISynchronousClient client, Fermyon.Nomad.Client.IAsynchronousClient asyncClient, Fermyon.Nomad.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = Fermyon.Nomad.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public Fermyon.Nomad.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public Fermyon.Nomad.Client.ISynchronousClient Client { get; set; }

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
        public Fermyon.Nomad.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Fermyon.Nomad.Client.ExceptionFactory ExceptionFactory
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
        ///  
        /// </summary>
        /// <exception cref="Fermyon.Nomad.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>List&lt;string&gt;</returns>
        public List<string> GetRegions(int operationIndex = 0)
        {
            Fermyon.Nomad.Client.ApiResponse<List<string>> localVarResponse = GetRegionsWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Fermyon.Nomad.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of List&lt;string&gt;</returns>
        public Fermyon.Nomad.Client.ApiResponse<List<string>> GetRegionsWithHttpInfo(int operationIndex = 0)
        {
            Fermyon.Nomad.Client.RequestOptions localVarRequestOptions = new Fermyon.Nomad.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Fermyon.Nomad.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Fermyon.Nomad.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }


            localVarRequestOptions.Operation = "RegionsApi.GetRegions";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (X-Nomad-Token) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("X-Nomad-Token")))
            {
                localVarRequestOptions.HeaderParameters.Add("X-Nomad-Token", this.Configuration.GetApiKeyWithPrefix("X-Nomad-Token"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<List<string>>("/regions", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetRegions", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Fermyon.Nomad.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;string&gt;</returns>
        public async System.Threading.Tasks.Task<List<string>> GetRegionsAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Fermyon.Nomad.Client.ApiResponse<List<string>> localVarResponse = await GetRegionsWithHttpInfoAsync(operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Fermyon.Nomad.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;string&gt;)</returns>
        public async System.Threading.Tasks.Task<Fermyon.Nomad.Client.ApiResponse<List<string>>> GetRegionsWithHttpInfoAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            Fermyon.Nomad.Client.RequestOptions localVarRequestOptions = new Fermyon.Nomad.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Fermyon.Nomad.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Fermyon.Nomad.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }


            localVarRequestOptions.Operation = "RegionsApi.GetRegions";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (X-Nomad-Token) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("X-Nomad-Token")))
            {
                localVarRequestOptions.HeaderParameters.Add("X-Nomad-Token", this.Configuration.GetApiKeyWithPrefix("X-Nomad-Token"));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<List<string>>("/regions", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetRegions", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}