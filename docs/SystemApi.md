# Fermyon.Nomad.Api.SystemApi

All URIs are relative to *https://127.0.0.1:4646/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**PutSystemGC**](SystemApi.md#putsystemgc) | **PUT** /system/gc |  |
| [**PutSystemReconcileSummaries**](SystemApi.md#putsystemreconcilesummaries) | **PUT** /system/reconcile/summaries |  |

<a id="putsystemgc"></a>
# **PutSystemGC**
> void PutSystemGC (string? region = null, string? varNamespace = null, string? xNomadToken = null, string? idempotencyToken = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fermyon.Nomad.Api;
using Fermyon.Nomad.Client;
using Fermyon.Nomad.Model;

namespace Example
{
    public class PutSystemGCExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://127.0.0.1:4646/v1";
            // Configure API key authorization: X-Nomad-Token
            config.AddApiKey("X-Nomad-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Nomad-Token", "Bearer");

            var apiInstance = new SystemApi(config);
            var region = "region_example";  // string? | Filters results based on the specified region. (optional) 
            var varNamespace = "varNamespace_example";  // string? | Filters results based on the specified namespace. (optional) 
            var xNomadToken = "xNomadToken_example";  // string? | A Nomad ACL token. (optional) 
            var idempotencyToken = "idempotencyToken_example";  // string? | Can be used to ensure operations are only run once. (optional) 

            try
            {
                apiInstance.PutSystemGC(region, varNamespace, xNomadToken, idempotencyToken);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SystemApi.PutSystemGC: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PutSystemGCWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.PutSystemGCWithHttpInfo(region, varNamespace, xNomadToken, idempotencyToken);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SystemApi.PutSystemGCWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **region** | **string?** | Filters results based on the specified region. | [optional]  |
| **varNamespace** | **string?** | Filters results based on the specified namespace. | [optional]  |
| **xNomadToken** | **string?** | A Nomad ACL token. | [optional]  |
| **idempotencyToken** | **string?** | Can be used to ensure operations are only run once. | [optional]  |

### Return type

void (empty response body)

### Authorization

[X-Nomad-Token](../README.md#X-Nomad-Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |
| **400** | Bad request |  -  |
| **403** | Forbidden |  -  |
| **405** | Method not allowed |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="putsystemreconcilesummaries"></a>
# **PutSystemReconcileSummaries**
> void PutSystemReconcileSummaries (string? region = null, string? varNamespace = null, string? xNomadToken = null, string? idempotencyToken = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fermyon.Nomad.Api;
using Fermyon.Nomad.Client;
using Fermyon.Nomad.Model;

namespace Example
{
    public class PutSystemReconcileSummariesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://127.0.0.1:4646/v1";
            // Configure API key authorization: X-Nomad-Token
            config.AddApiKey("X-Nomad-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Nomad-Token", "Bearer");

            var apiInstance = new SystemApi(config);
            var region = "region_example";  // string? | Filters results based on the specified region. (optional) 
            var varNamespace = "varNamespace_example";  // string? | Filters results based on the specified namespace. (optional) 
            var xNomadToken = "xNomadToken_example";  // string? | A Nomad ACL token. (optional) 
            var idempotencyToken = "idempotencyToken_example";  // string? | Can be used to ensure operations are only run once. (optional) 

            try
            {
                apiInstance.PutSystemReconcileSummaries(region, varNamespace, xNomadToken, idempotencyToken);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SystemApi.PutSystemReconcileSummaries: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PutSystemReconcileSummariesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.PutSystemReconcileSummariesWithHttpInfo(region, varNamespace, xNomadToken, idempotencyToken);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SystemApi.PutSystemReconcileSummariesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **region** | **string?** | Filters results based on the specified region. | [optional]  |
| **varNamespace** | **string?** | Filters results based on the specified namespace. | [optional]  |
| **xNomadToken** | **string?** | A Nomad ACL token. | [optional]  |
| **idempotencyToken** | **string?** | Can be used to ensure operations are only run once. | [optional]  |

### Return type

void (empty response body)

### Authorization

[X-Nomad-Token](../README.md#X-Nomad-Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |
| **400** | Bad request |  -  |
| **403** | Forbidden |  -  |
| **405** | Method not allowed |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

