/* 
 * The Blue Alliance API v3
 *
 * # Overview    Information and statistics about FIRST Robotics Competition teams and events.   # Authentication   All endpoints require an Auth Key to be passed in the header `X-TBA-Auth-Key`. If you do not have an auth key yet, you can obtain one from your [Account Page](/account).    A `User-Agent` header may need to be set to prevent a 403 Unauthorized error.
 *
 * OpenAPI spec version: 3.03.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using com.tweirtx.TBAV3.Client;
using com.tweirtx.TBAV3.Model;

namespace com.tweirtx.TBAV3.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ITBAApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Returns API status, and TBA status information.
        /// </remarks>
        /// <exception cref="com.tweirtx.TBAV3.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ifModifiedSince">Value of the &#x60;Last-Modified&#x60; header in the most recently cached response by the client. (optional)</param>
        /// <returns>APIStatus</returns>
        APIStatus GetStatus (string ifModifiedSince = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Returns API status, and TBA status information.
        /// </remarks>
        /// <exception cref="com.tweirtx.TBAV3.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ifModifiedSince">Value of the &#x60;Last-Modified&#x60; header in the most recently cached response by the client. (optional)</param>
        /// <returns>ApiResponse of APIStatus</returns>
        ApiResponse<APIStatus> GetStatusWithHttpInfo (string ifModifiedSince = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Returns API status, and TBA status information.
        /// </remarks>
        /// <exception cref="com.tweirtx.TBAV3.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ifModifiedSince">Value of the &#x60;Last-Modified&#x60; header in the most recently cached response by the client. (optional)</param>
        /// <returns>Task of APIStatus</returns>
        System.Threading.Tasks.Task<APIStatus> GetStatusAsync (string ifModifiedSince = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Returns API status, and TBA status information.
        /// </remarks>
        /// <exception cref="com.tweirtx.TBAV3.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ifModifiedSince">Value of the &#x60;Last-Modified&#x60; header in the most recently cached response by the client. (optional)</param>
        /// <returns>Task of ApiResponse (APIStatus)</returns>
        System.Threading.Tasks.Task<ApiResponse<APIStatus>> GetStatusAsyncWithHttpInfo (string ifModifiedSince = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class TBAApi : ITBAApi
    {
        private com.tweirtx.TBAV3.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="TBAApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TBAApi(String basePath)
        {
            this.Configuration = new Configuration { BasePath = basePath };

            ExceptionFactory = com.tweirtx.TBAV3.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TBAApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public TBAApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = com.tweirtx.TBAV3.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public com.tweirtx.TBAV3.Client.ExceptionFactory ExceptionFactory
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
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        ///  Returns API status, and TBA status information.
        /// </summary>
        /// <exception cref="com.tweirtx.TBAV3.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ifModifiedSince">Value of the &#x60;Last-Modified&#x60; header in the most recently cached response by the client. (optional)</param>
        /// <returns>APIStatus</returns>
        public APIStatus GetStatus (string ifModifiedSince = null)
        {
             ApiResponse<APIStatus> localVarResponse = GetStatusWithHttpInfo(ifModifiedSince);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  Returns API status, and TBA status information.
        /// </summary>
        /// <exception cref="com.tweirtx.TBAV3.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ifModifiedSince">Value of the &#x60;Last-Modified&#x60; header in the most recently cached response by the client. (optional)</param>
        /// <returns>ApiResponse of APIStatus</returns>
        public ApiResponse< APIStatus > GetStatusWithHttpInfo (string ifModifiedSince = null)
        {

            var localVarPath = "/status";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (ifModifiedSince != null) localVarHeaderParams.Add("If-Modified-Since", Configuration.ApiClient.ParameterToString(ifModifiedSince)); // header parameter

            // authentication (apiKey) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("X-TBA-Auth-Key")))
            {
                localVarHeaderParams["X-TBA-Auth-Key"] = Configuration.GetApiKeyWithPrefix("X-TBA-Auth-Key");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetStatus", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<APIStatus>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (APIStatus) Configuration.ApiClient.Deserialize(localVarResponse, typeof(APIStatus)));
        }

        /// <summary>
        ///  Returns API status, and TBA status information.
        /// </summary>
        /// <exception cref="com.tweirtx.TBAV3.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ifModifiedSince">Value of the &#x60;Last-Modified&#x60; header in the most recently cached response by the client. (optional)</param>
        /// <returns>Task of APIStatus</returns>
        public async System.Threading.Tasks.Task<APIStatus> GetStatusAsync (string ifModifiedSince = null)
        {
             ApiResponse<APIStatus> localVarResponse = await GetStatusAsyncWithHttpInfo(ifModifiedSince);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  Returns API status, and TBA status information.
        /// </summary>
        /// <exception cref="com.tweirtx.TBAV3.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ifModifiedSince">Value of the &#x60;Last-Modified&#x60; header in the most recently cached response by the client. (optional)</param>
        /// <returns>Task of ApiResponse (APIStatus)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<APIStatus>> GetStatusAsyncWithHttpInfo (string ifModifiedSince = null)
        {

            var localVarPath = "/status";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (ifModifiedSince != null) localVarHeaderParams.Add("If-Modified-Since", Configuration.ApiClient.ParameterToString(ifModifiedSince)); // header parameter

            // authentication (apiKey) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("X-TBA-Auth-Key")))
            {
                localVarHeaderParams["X-TBA-Auth-Key"] = Configuration.GetApiKeyWithPrefix("X-TBA-Auth-Key");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetStatus", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<APIStatus>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (APIStatus) Configuration.ApiClient.Deserialize(localVarResponse, typeof(APIStatus)));
        }

    }
}
