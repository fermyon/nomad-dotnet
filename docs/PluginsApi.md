# Fermyon.Nomad.Api.PluginsApi

All URIs are relative to *https://127.0.0.1:4646/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetPluginCSI**](PluginsApi.md#getplugincsi) | **GET** /plugin/csi/{pluginID} |  |
| [**GetPlugins**](PluginsApi.md#getplugins) | **GET** /plugins |  |

<a id="getplugincsi"></a>
# **GetPluginCSI**
> List&lt;CSIPlugin&gt; GetPluginCSI (string pluginID, string? region = null, string? varNamespace = null, int? index = null, string? wait = null, string? stale = null, string? prefix = null, string? xNomadToken = null, int? perPage = null, string? nextToken = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fermyon.Nomad.Api;
using Fermyon.Nomad.Client;
using Fermyon.Nomad.Model;

namespace Example
{
    public class GetPluginCSIExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://127.0.0.1:4646/v1";
            // Configure API key authorization: X-Nomad-Token
            config.AddApiKey("X-Nomad-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Nomad-Token", "Bearer");

            var apiInstance = new PluginsApi(config);
            var pluginID = "pluginID_example";  // string | The CSI plugin identifier.
            var region = "region_example";  // string? | Filters results based on the specified region. (optional) 
            var varNamespace = "varNamespace_example";  // string? | Filters results based on the specified namespace. (optional) 
            var index = 56;  // int? | If set, wait until query exceeds given index. Must be provided with WaitParam. (optional) 
            var wait = "wait_example";  // string? | Provided with IndexParam to wait for change. (optional) 
            var stale = "stale_example";  // string? | If present, results will include stale reads. (optional) 
            var prefix = "prefix_example";  // string? | Constrains results to jobs that start with the defined prefix (optional) 
            var xNomadToken = "xNomadToken_example";  // string? | A Nomad ACL token. (optional) 
            var perPage = 56;  // int? | Maximum number of results to return. (optional) 
            var nextToken = "nextToken_example";  // string? | Indicates where to start paging for queries that support pagination. (optional) 

            try
            {
                List<CSIPlugin> result = apiInstance.GetPluginCSI(pluginID, region, varNamespace, index, wait, stale, prefix, xNomadToken, perPage, nextToken);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PluginsApi.GetPluginCSI: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPluginCSIWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<CSIPlugin>> response = apiInstance.GetPluginCSIWithHttpInfo(pluginID, region, varNamespace, index, wait, stale, prefix, xNomadToken, perPage, nextToken);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PluginsApi.GetPluginCSIWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pluginID** | **string** | The CSI plugin identifier. |  |
| **region** | **string?** | Filters results based on the specified region. | [optional]  |
| **varNamespace** | **string?** | Filters results based on the specified namespace. | [optional]  |
| **index** | **int?** | If set, wait until query exceeds given index. Must be provided with WaitParam. | [optional]  |
| **wait** | **string?** | Provided with IndexParam to wait for change. | [optional]  |
| **stale** | **string?** | If present, results will include stale reads. | [optional]  |
| **prefix** | **string?** | Constrains results to jobs that start with the defined prefix | [optional]  |
| **xNomadToken** | **string?** | A Nomad ACL token. | [optional]  |
| **perPage** | **int?** | Maximum number of results to return. | [optional]  |
| **nextToken** | **string?** | Indicates where to start paging for queries that support pagination. | [optional]  |

### Return type

[**List&lt;CSIPlugin&gt;**](CSIPlugin.md)

### Authorization

[X-Nomad-Token](../README.md#X-Nomad-Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  * X-Nomad-Index - A unique identifier representing the current state of the requested resource. On a new Nomad cluster the value of this index starts at 1. <br>  * X-Nomad-KnownLeader - Boolean indicating if there is a known cluster leader. <br>  * X-Nomad-LastContact - The time in milliseconds that a server was last contacted by the leader node. <br>  |
| **400** | Bad request |  -  |
| **403** | Forbidden |  -  |
| **405** | Method not allowed |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getplugins"></a>
# **GetPlugins**
> List&lt;CSIPluginListStub&gt; GetPlugins (string? region = null, string? varNamespace = null, int? index = null, string? wait = null, string? stale = null, string? prefix = null, string? xNomadToken = null, int? perPage = null, string? nextToken = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fermyon.Nomad.Api;
using Fermyon.Nomad.Client;
using Fermyon.Nomad.Model;

namespace Example
{
    public class GetPluginsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://127.0.0.1:4646/v1";
            // Configure API key authorization: X-Nomad-Token
            config.AddApiKey("X-Nomad-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Nomad-Token", "Bearer");

            var apiInstance = new PluginsApi(config);
            var region = "region_example";  // string? | Filters results based on the specified region. (optional) 
            var varNamespace = "varNamespace_example";  // string? | Filters results based on the specified namespace. (optional) 
            var index = 56;  // int? | If set, wait until query exceeds given index. Must be provided with WaitParam. (optional) 
            var wait = "wait_example";  // string? | Provided with IndexParam to wait for change. (optional) 
            var stale = "stale_example";  // string? | If present, results will include stale reads. (optional) 
            var prefix = "prefix_example";  // string? | Constrains results to jobs that start with the defined prefix (optional) 
            var xNomadToken = "xNomadToken_example";  // string? | A Nomad ACL token. (optional) 
            var perPage = 56;  // int? | Maximum number of results to return. (optional) 
            var nextToken = "nextToken_example";  // string? | Indicates where to start paging for queries that support pagination. (optional) 

            try
            {
                List<CSIPluginListStub> result = apiInstance.GetPlugins(region, varNamespace, index, wait, stale, prefix, xNomadToken, perPage, nextToken);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PluginsApi.GetPlugins: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPluginsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<CSIPluginListStub>> response = apiInstance.GetPluginsWithHttpInfo(region, varNamespace, index, wait, stale, prefix, xNomadToken, perPage, nextToken);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PluginsApi.GetPluginsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **region** | **string?** | Filters results based on the specified region. | [optional]  |
| **varNamespace** | **string?** | Filters results based on the specified namespace. | [optional]  |
| **index** | **int?** | If set, wait until query exceeds given index. Must be provided with WaitParam. | [optional]  |
| **wait** | **string?** | Provided with IndexParam to wait for change. | [optional]  |
| **stale** | **string?** | If present, results will include stale reads. | [optional]  |
| **prefix** | **string?** | Constrains results to jobs that start with the defined prefix | [optional]  |
| **xNomadToken** | **string?** | A Nomad ACL token. | [optional]  |
| **perPage** | **int?** | Maximum number of results to return. | [optional]  |
| **nextToken** | **string?** | Indicates where to start paging for queries that support pagination. | [optional]  |

### Return type

[**List&lt;CSIPluginListStub&gt;**](CSIPluginListStub.md)

### Authorization

[X-Nomad-Token](../README.md#X-Nomad-Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |
| **400** | Bad request |  -  |
| **403** | Forbidden |  -  |
| **405** | Method not allowed |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

