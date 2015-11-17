// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Hyak.Common;
using Microsoft.Azure.Management.Insights;
using Microsoft.Azure.Management.Insights.Models;
using Newtonsoft.Json.Linq;

namespace Microsoft.Azure.Management.Insights
{
    /// <summary>
    /// Operations for managing resources sku.
    /// </summary>
    internal partial class SkuOperations : IServiceOperations<InsightsManagementClient>, ISkuOperations
    {
        /// <summary>
        /// Initializes a new instance of the SkuOperations class.
        /// </summary>
        /// <param name='client'>
        /// Reference to the service client.
        /// </param>
        internal SkuOperations(InsightsManagementClient client)
        {
            this._client = client;
        }
        
        private InsightsManagementClient _client;
        
        /// <summary>
        /// Gets a reference to the
        /// Microsoft.Azure.Management.Insights.InsightsManagementClient.
        /// </summary>
        public InsightsManagementClient Client
        {
            get { return this._client; }
        }
        
        /// <param name='resourceId'>
        /// Required. The resource id.
        /// </param>
        /// <param name='apiVersion'>
        /// Required. The resource provider api version.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public async Task<SkuGetResponse> GetCurrentSkuAsync(string resourceId, string apiVersion, CancellationToken cancellationToken)
        {
            // Validate
            if (resourceId == null)
            {
                throw new ArgumentNullException("resourceId");
            }
            if (apiVersion == null)
            {
                throw new ArgumentNullException("apiVersion");
            }
            
            // Tracing
            bool shouldTrace = TracingAdapter.IsEnabled;
            string invocationId = null;
            if (shouldTrace)
            {
                invocationId = TracingAdapter.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("resourceId", resourceId);
                tracingParameters.Add("apiVersion", apiVersion);
                TracingAdapter.Enter(invocationId, this, "GetCurrentSkuAsync", tracingParameters);
            }
            
            // Construct URL
            string url = "";
            url = url + "/";
            url = url + Uri.EscapeDataString(resourceId);
            List<string> queryParameters = new List<string>();
            queryParameters.Add("api-version=" + Uri.EscapeDataString(apiVersion));
            if (queryParameters.Count > 0)
            {
                url = url + "?" + string.Join("&", queryParameters);
            }
            string baseUrl = this.Client.BaseUri.AbsoluteUri;
            // Trim '/' character from the end of baseUrl and beginning of url.
            if (baseUrl[baseUrl.Length - 1] == '/')
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            if (url[0] == '/')
            {
                url = url.Substring(1);
            }
            url = baseUrl + "/" + url;
            url = url.Replace(" ", "%20");
            
            // Create HTTP transport objects
            HttpRequestMessage httpRequest = null;
            try
            {
                httpRequest = new HttpRequestMessage();
                httpRequest.Method = HttpMethod.Get;
                httpRequest.RequestUri = new Uri(url);
                
                // Set Headers
                httpRequest.Headers.Add("Accept", "application/json");
                
                // Set Credentials
                cancellationToken.ThrowIfCancellationRequested();
                await this.Client.Credentials.ProcessHttpRequestAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                
                // Send Request
                HttpResponseMessage httpResponse = null;
                try
                {
                    if (shouldTrace)
                    {
                        TracingAdapter.SendRequest(invocationId, httpRequest);
                    }
                    cancellationToken.ThrowIfCancellationRequested();
                    httpResponse = await this.Client.HttpClient.SendAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                    if (shouldTrace)
                    {
                        TracingAdapter.ReceiveResponse(invocationId, httpResponse);
                    }
                    HttpStatusCode statusCode = httpResponse.StatusCode;
                    if (statusCode != HttpStatusCode.OK)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        CloudException ex = CloudException.Create(httpRequest, null, httpResponse, await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false));
                        if (shouldTrace)
                        {
                            TracingAdapter.Error(invocationId, ex);
                        }
                        throw ex;
                    }
                    
                    // Create Result
                    SkuGetResponse result = null;
                    // Deserialize Response
                    if (statusCode == HttpStatusCode.OK)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        string responseContent = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                        result = new SkuGetResponse();
                        JToken responseDoc = null;
                        if (string.IsNullOrEmpty(responseContent) == false)
                        {
                            responseDoc = JToken.Parse(responseContent);
                        }
                        
                        if (responseDoc != null && responseDoc.Type != JTokenType.Null)
                        {
                            JToken skuValue = responseDoc["sku"];
                            if (skuValue != null && skuValue.Type != JTokenType.Null)
                            {
                                CurrentSku skuInstance = new CurrentSku();
                                result.Sku = skuInstance;
                                
                                JToken nameValue = skuValue["name"];
                                if (nameValue != null && nameValue.Type != JTokenType.Null)
                                {
                                    string nameInstance = ((string)nameValue);
                                    skuInstance.Name = nameInstance;
                                }
                                
                                JToken tierValue = skuValue["tier"];
                                if (tierValue != null && tierValue.Type != JTokenType.Null)
                                {
                                    string tierInstance = ((string)tierValue);
                                    skuInstance.Tier = tierInstance;
                                }
                                
                                JToken sizeValue = skuValue["size"];
                                if (sizeValue != null && sizeValue.Type != JTokenType.Null)
                                {
                                    string sizeInstance = ((string)sizeValue);
                                    skuInstance.Size = sizeInstance;
                                }
                                
                                JToken familyValue = skuValue["family"];
                                if (familyValue != null && familyValue.Type != JTokenType.Null)
                                {
                                    string familyInstance = ((string)familyValue);
                                    skuInstance.Family = familyInstance;
                                }
                                
                                JToken capacityValue = skuValue["capacity"];
                                if (capacityValue != null && capacityValue.Type != JTokenType.Null)
                                {
                                    int capacityInstance = ((int)capacityValue);
                                    skuInstance.Capacity = capacityInstance;
                                }
                            }
                        }
                        
                    }
                    result.StatusCode = statusCode;
                    if (httpResponse.Headers.Contains("x-ms-request-id"))
                    {
                        result.RequestId = httpResponse.Headers.GetValues("x-ms-request-id").FirstOrDefault();
                    }
                    
                    if (shouldTrace)
                    {
                        TracingAdapter.Exit(invocationId, result);
                    }
                    return result;
                }
                finally
                {
                    if (httpResponse != null)
                    {
                        httpResponse.Dispose();
                    }
                }
            }
            finally
            {
                if (httpRequest != null)
                {
                    httpRequest.Dispose();
                }
            }
        }
        
        /// <param name='resourceId'>
        /// Required. The resource id.
        /// </param>
        /// <param name='apiVersion'>
        /// Required. The resource provider api version.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public async Task<SkuListResponse> ListSkuDefinitionsAsync(string resourceId, string apiVersion, CancellationToken cancellationToken)
        {
            // Validate
            if (resourceId == null)
            {
                throw new ArgumentNullException("resourceId");
            }
            if (apiVersion == null)
            {
                throw new ArgumentNullException("apiVersion");
            }
            
            // Tracing
            bool shouldTrace = TracingAdapter.IsEnabled;
            string invocationId = null;
            if (shouldTrace)
            {
                invocationId = TracingAdapter.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("resourceId", resourceId);
                tracingParameters.Add("apiVersion", apiVersion);
                TracingAdapter.Enter(invocationId, this, "ListSkuDefinitionsAsync", tracingParameters);
            }
            
            // Construct URL
            string url = "";
            url = url + "/";
            url = url + Uri.EscapeDataString(resourceId);
            url = url + "/skus";
            List<string> queryParameters = new List<string>();
            queryParameters.Add("api-version=" + Uri.EscapeDataString(apiVersion));
            if (queryParameters.Count > 0)
            {
                url = url + "?" + string.Join("&", queryParameters);
            }
            string baseUrl = this.Client.BaseUri.AbsoluteUri;
            // Trim '/' character from the end of baseUrl and beginning of url.
            if (baseUrl[baseUrl.Length - 1] == '/')
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            if (url[0] == '/')
            {
                url = url.Substring(1);
            }
            url = baseUrl + "/" + url;
            url = url.Replace(" ", "%20");
            
            // Create HTTP transport objects
            HttpRequestMessage httpRequest = null;
            try
            {
                httpRequest = new HttpRequestMessage();
                httpRequest.Method = HttpMethod.Get;
                httpRequest.RequestUri = new Uri(url);
                
                // Set Headers
                httpRequest.Headers.Add("Accept", "application/json");
                
                // Set Credentials
                cancellationToken.ThrowIfCancellationRequested();
                await this.Client.Credentials.ProcessHttpRequestAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                
                // Send Request
                HttpResponseMessage httpResponse = null;
                try
                {
                    if (shouldTrace)
                    {
                        TracingAdapter.SendRequest(invocationId, httpRequest);
                    }
                    cancellationToken.ThrowIfCancellationRequested();
                    httpResponse = await this.Client.HttpClient.SendAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                    if (shouldTrace)
                    {
                        TracingAdapter.ReceiveResponse(invocationId, httpResponse);
                    }
                    HttpStatusCode statusCode = httpResponse.StatusCode;
                    if (statusCode != HttpStatusCode.OK)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        CloudException ex = CloudException.Create(httpRequest, null, httpResponse, await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false));
                        if (shouldTrace)
                        {
                            TracingAdapter.Error(invocationId, ex);
                        }
                        throw ex;
                    }
                    
                    // Create Result
                    SkuListResponse result = null;
                    // Deserialize Response
                    if (statusCode == HttpStatusCode.OK)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        string responseContent = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                        result = new SkuListResponse();
                        JToken responseDoc = null;
                        if (string.IsNullOrEmpty(responseContent) == false)
                        {
                            responseDoc = JToken.Parse(responseContent);
                        }
                        
                        if (responseDoc != null && responseDoc.Type != JTokenType.Null)
                        {
                            JToken valueArray = responseDoc["value"];
                            if (valueArray != null && valueArray.Type != JTokenType.Null)
                            {
                                foreach (JToken valueValue in ((JArray)valueArray))
                                {
                                    SkuDefinition skuDefinitionInstance = new SkuDefinition();
                                    result.Value.Add(skuDefinitionInstance);
                                    
                                    JToken resourceTypeValue = valueValue["resourceType"];
                                    if (resourceTypeValue != null && resourceTypeValue.Type != JTokenType.Null)
                                    {
                                        string resourceTypeInstance = ((string)resourceTypeValue);
                                        skuDefinitionInstance.ResourceType = resourceTypeInstance;
                                    }
                                    
                                    JToken skuValue = valueValue["sku"];
                                    if (skuValue != null && skuValue.Type != JTokenType.Null)
                                    {
                                        Sku skuInstance = new Sku();
                                        skuDefinitionInstance.Sku = skuInstance;
                                        
                                        JToken nameValue = skuValue["name"];
                                        if (nameValue != null && nameValue.Type != JTokenType.Null)
                                        {
                                            string nameInstance = ((string)nameValue);
                                            skuInstance.Name = nameInstance;
                                        }
                                        
                                        JToken tierValue = skuValue["tier"];
                                        if (tierValue != null && tierValue.Type != JTokenType.Null)
                                        {
                                            string tierInstance = ((string)tierValue);
                                            skuInstance.Tier = tierInstance;
                                        }
                                        
                                        JToken sizeValue = skuValue["size"];
                                        if (sizeValue != null && sizeValue.Type != JTokenType.Null)
                                        {
                                            string sizeInstance = ((string)sizeValue);
                                            skuInstance.Size = sizeInstance;
                                        }
                                        
                                        JToken familyValue = skuValue["family"];
                                        if (familyValue != null && familyValue.Type != JTokenType.Null)
                                        {
                                            string familyInstance = ((string)familyValue);
                                            skuInstance.Family = familyInstance;
                                        }
                                    }
                                    
                                    JToken capacityValue = valueValue["capacity"];
                                    if (capacityValue != null && capacityValue.Type != JTokenType.Null)
                                    {
                                        Capacity capacityInstance = new Capacity();
                                        skuDefinitionInstance.Capacity = capacityInstance;
                                        
                                        JToken minimumValue = capacityValue["minimum"];
                                        if (minimumValue != null && minimumValue.Type != JTokenType.Null)
                                        {
                                            int minimumInstance = ((int)minimumValue);
                                            capacityInstance.Minimum = minimumInstance;
                                        }
                                        
                                        JToken maximumValue = capacityValue["maximum"];
                                        if (maximumValue != null && maximumValue.Type != JTokenType.Null)
                                        {
                                            int maximumInstance = ((int)maximumValue);
                                            capacityInstance.Maximum = maximumInstance;
                                        }
                                        
                                        JToken defaultValue = capacityValue["default"];
                                        if (defaultValue != null && defaultValue.Type != JTokenType.Null)
                                        {
                                            int defaultInstance = ((int)defaultValue);
                                            capacityInstance.Default = defaultInstance;
                                        }
                                        
                                        JToken scaleTypeValue = capacityValue["scaleType"];
                                        if (scaleTypeValue != null && scaleTypeValue.Type != JTokenType.Null)
                                        {
                                            SupportedScaleType scaleTypeInstance = ((SupportedScaleType)Enum.Parse(typeof(SupportedScaleType), ((string)scaleTypeValue), true));
                                            capacityInstance.ScaleType = scaleTypeInstance;
                                        }
                                    }
                                }
                            }
                        }
                        
                    }
                    result.StatusCode = statusCode;
                    if (httpResponse.Headers.Contains("x-ms-request-id"))
                    {
                        result.RequestId = httpResponse.Headers.GetValues("x-ms-request-id").FirstOrDefault();
                    }
                    
                    if (shouldTrace)
                    {
                        TracingAdapter.Exit(invocationId, result);
                    }
                    return result;
                }
                finally
                {
                    if (httpResponse != null)
                    {
                        httpResponse.Dispose();
                    }
                }
            }
            finally
            {
                if (httpRequest != null)
                {
                    httpRequest.Dispose();
                }
            }
        }
        
        /// <param name='resourceId'>
        /// Required.
        /// </param>
        /// <param name='parameters'>
        /// Required.
        /// </param>
        /// <param name='apiVersion'>
        /// Required. The resource provider api version.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public async Task<SkuUpdateResponse> UpdateCurrentSkuAsync(string resourceId, SkuUpdateParameters parameters, string apiVersion, CancellationToken cancellationToken)
        {
            // Validate
            if (resourceId == null)
            {
                throw new ArgumentNullException("resourceId");
            }
            if (parameters == null)
            {
                throw new ArgumentNullException("parameters");
            }
            if (apiVersion == null)
            {
                throw new ArgumentNullException("apiVersion");
            }
            
            // Tracing
            bool shouldTrace = TracingAdapter.IsEnabled;
            string invocationId = null;
            if (shouldTrace)
            {
                invocationId = TracingAdapter.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("resourceId", resourceId);
                tracingParameters.Add("parameters", parameters);
                tracingParameters.Add("apiVersion", apiVersion);
                TracingAdapter.Enter(invocationId, this, "UpdateCurrentSkuAsync", tracingParameters);
            }
            
            // Construct URL
            string url = "";
            url = url + "/";
            url = url + Uri.EscapeDataString(resourceId);
            List<string> queryParameters = new List<string>();
            queryParameters.Add("api-version=" + Uri.EscapeDataString(apiVersion));
            if (queryParameters.Count > 0)
            {
                url = url + "?" + string.Join("&", queryParameters);
            }
            string baseUrl = this.Client.BaseUri.AbsoluteUri;
            // Trim '/' character from the end of baseUrl and beginning of url.
            if (baseUrl[baseUrl.Length - 1] == '/')
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            if (url[0] == '/')
            {
                url = url.Substring(1);
            }
            url = baseUrl + "/" + url;
            url = url.Replace(" ", "%20");
            
            // Create HTTP transport objects
            HttpRequestMessage httpRequest = null;
            try
            {
                httpRequest = new HttpRequestMessage();
                httpRequest.Method = new HttpMethod("PATCH");
                httpRequest.RequestUri = new Uri(url);
                
                // Set Headers
                httpRequest.Headers.Add("Accept", "application/json");
                
                // Set Credentials
                cancellationToken.ThrowIfCancellationRequested();
                await this.Client.Credentials.ProcessHttpRequestAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                
                // Serialize Request
                string requestContent = null;
                JToken requestDoc = null;
                
                JObject skuUpdateParametersValue = new JObject();
                requestDoc = skuUpdateParametersValue;
                
                if (parameters.Sku != null)
                {
                    JObject skuValue = new JObject();
                    skuUpdateParametersValue["sku"] = skuValue;
                    
                    if (parameters.Sku.Name != null)
                    {
                        skuValue["name"] = parameters.Sku.Name;
                    }
                    
                    if (parameters.Sku.Tier != null)
                    {
                        skuValue["tier"] = parameters.Sku.Tier;
                    }
                    
                    if (parameters.Sku.Size != null)
                    {
                        skuValue["size"] = parameters.Sku.Size;
                    }
                    
                    if (parameters.Sku.Family != null)
                    {
                        skuValue["family"] = parameters.Sku.Family;
                    }
                    
                    skuValue["capacity"] = parameters.Sku.Capacity;
                }
                
                requestContent = requestDoc.ToString(Newtonsoft.Json.Formatting.Indented);
                httpRequest.Content = new StringContent(requestContent, Encoding.UTF8);
                httpRequest.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                
                // Send Request
                HttpResponseMessage httpResponse = null;
                try
                {
                    if (shouldTrace)
                    {
                        TracingAdapter.SendRequest(invocationId, httpRequest);
                    }
                    cancellationToken.ThrowIfCancellationRequested();
                    httpResponse = await this.Client.HttpClient.SendAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                    if (shouldTrace)
                    {
                        TracingAdapter.ReceiveResponse(invocationId, httpResponse);
                    }
                    HttpStatusCode statusCode = httpResponse.StatusCode;
                    if (statusCode != HttpStatusCode.OK && statusCode != HttpStatusCode.Accepted)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        CloudException ex = CloudException.Create(httpRequest, requestContent, httpResponse, await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false));
                        if (shouldTrace)
                        {
                            TracingAdapter.Error(invocationId, ex);
                        }
                        throw ex;
                    }
                    
                    // Create Result
                    SkuUpdateResponse result = null;
                    // Deserialize Response
                    if (statusCode == HttpStatusCode.OK || statusCode == HttpStatusCode.Accepted)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        string responseContent = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                        result = new SkuUpdateResponse();
                        JToken responseDoc = null;
                        if (string.IsNullOrEmpty(responseContent) == false)
                        {
                            responseDoc = JToken.Parse(responseContent);
                        }
                        
                        if (responseDoc != null && responseDoc.Type != JTokenType.Null)
                        {
                        }
                        
                    }
                    result.StatusCode = statusCode;
                    if (httpResponse.Headers.Contains("x-ms-request-id"))
                    {
                        result.RequestId = httpResponse.Headers.GetValues("x-ms-request-id").FirstOrDefault();
                    }
                    
                    if (shouldTrace)
                    {
                        TracingAdapter.Exit(invocationId, result);
                    }
                    return result;
                }
                finally
                {
                    if (httpResponse != null)
                    {
                        httpResponse.Dispose();
                    }
                }
            }
            finally
            {
                if (httpRequest != null)
                {
                    httpRequest.Dispose();
                }
            }
        }
    }
}
