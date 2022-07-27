# Fermyon.Nomad.Api.ClientsApi

All URIs are relative to *https://127.0.0.1:4646/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetAllocationLogs**](ClientsApi.md#getallocationlogs) | **GET** /client/fs/logs/{allocID} |  |

<a name="getallocationlogs"></a>
# **GetAllocationLogs**
> AllocationLogs GetAllocationLogs (string task, string type, string allocID, bool? follow = null, int? offset = null, string? origin = null, bool? plain = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fermyon.Nomad.Api;
using Fermyon.Nomad.Client;
using Fermyon.Nomad.Model;

namespace Example
{
    public class GetAllocationLogsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://127.0.0.1:4646/v1";
            // Configure API key authorization: X-Nomad-Token
            config.AddApiKey("X-Nomad-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Nomad-Token", "Bearer");

            var apiInstance = new ClientsApi(config);
            var task = "task_example";  // string | Specifies the allocation ID to query. This is specified as part of the URL. Note, this must be the full allocation ID, not the short 8-character one. This is specified as part of the path.
            var type = "type_example";  // string | Specifies the stream to stream.
            var allocID = "allocID_example";  // string | Allocation ID.
            var follow = true;  // bool? | Specifies whether to tail the logs. (optional) 
            var offset = 56;  // int? | Specifies the offset to start streaming from. (optional) 
            var origin = "origin_example";  // string? | Specifies either \"start\" or \"end\" and applies the offset relative to either the start or end of the logs respectively. Defaults to \"start\" (optional) 
            var plain = true;  // bool? | Return just the plain text without framing. This can be useful when viewing logs in a browser (optional) 

            try
            {
                AllocationLogs result = apiInstance.GetAllocationLogs(task, type, allocID, follow, offset, origin, plain);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClientsApi.GetAllocationLogs: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAllocationLogsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AllocationLogs> response = apiInstance.GetAllocationLogsWithHttpInfo(task, type, allocID, follow, offset, origin, plain);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ClientsApi.GetAllocationLogsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **task** | **string** | Specifies the allocation ID to query. This is specified as part of the URL. Note, this must be the full allocation ID, not the short 8-character one. This is specified as part of the path. |  |
| **type** | **string** | Specifies the stream to stream. |  |
| **allocID** | **string** | Allocation ID. |  |
| **follow** | **bool?** | Specifies whether to tail the logs. | [optional]  |
| **offset** | **int?** | Specifies the offset to start streaming from. | [optional]  |
| **origin** | **string?** | Specifies either \&quot;start\&quot; or \&quot;end\&quot; and applies the offset relative to either the start or end of the logs respectively. Defaults to \&quot;start\&quot; | [optional]  |
| **plain** | **bool?** | Return just the plain text without framing. This can be useful when viewing logs in a browser | [optional]  |

### Return type

[**AllocationLogs**](AllocationLogs.md)

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

