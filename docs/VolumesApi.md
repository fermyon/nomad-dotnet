# Fermyon.Nomad.Api.VolumesApi

All URIs are relative to *https://127.0.0.1:4646/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateVolume**](VolumesApi.md#createvolume) | **POST** /volume/csi/{volumeId}/{action} |  |
| [**DeleteSnapshot**](VolumesApi.md#deletesnapshot) | **DELETE** /volumes/snapshot |  |
| [**DeleteVolumeRegistration**](VolumesApi.md#deletevolumeregistration) | **DELETE** /volume/csi/{volumeId} |  |
| [**DetachOrDeleteVolume**](VolumesApi.md#detachordeletevolume) | **DELETE** /volume/csi/{volumeId}/{action} |  |
| [**GetExternalVolumes**](VolumesApi.md#getexternalvolumes) | **GET** /volumes/external |  |
| [**GetSnapshots**](VolumesApi.md#getsnapshots) | **GET** /volumes/snapshot |  |
| [**GetVolume**](VolumesApi.md#getvolume) | **GET** /volume/csi/{volumeId} |  |
| [**GetVolumes**](VolumesApi.md#getvolumes) | **GET** /volumes |  |
| [**PostSnapshot**](VolumesApi.md#postsnapshot) | **POST** /volumes/snapshot |  |
| [**PostVolume**](VolumesApi.md#postvolume) | **POST** /volumes |  |
| [**PostVolumeRegistration**](VolumesApi.md#postvolumeregistration) | **POST** /volume/csi/{volumeId} |  |

<a id="createvolume"></a>
# **CreateVolume**
> void CreateVolume (string volumeId, string action, CSIVolumeCreateRequest cSIVolumeCreateRequest, string? region = null, string? varNamespace = null, string? xNomadToken = null, string? idempotencyToken = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fermyon.Nomad.Api;
using Fermyon.Nomad.Client;
using Fermyon.Nomad.Model;

namespace Example
{
    public class CreateVolumeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://127.0.0.1:4646/v1";
            // Configure API key authorization: X-Nomad-Token
            config.AddApiKey("X-Nomad-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Nomad-Token", "Bearer");

            var apiInstance = new VolumesApi(config);
            var volumeId = "volumeId_example";  // string | Volume unique identifier.
            var action = "action_example";  // string | The action to perform on the Volume (create, detach, delete).
            var cSIVolumeCreateRequest = new CSIVolumeCreateRequest(); // CSIVolumeCreateRequest | 
            var region = "region_example";  // string? | Filters results based on the specified region. (optional) 
            var varNamespace = "varNamespace_example";  // string? | Filters results based on the specified namespace. (optional) 
            var xNomadToken = "xNomadToken_example";  // string? | A Nomad ACL token. (optional) 
            var idempotencyToken = "idempotencyToken_example";  // string? | Can be used to ensure operations are only run once. (optional) 

            try
            {
                apiInstance.CreateVolume(volumeId, action, cSIVolumeCreateRequest, region, varNamespace, xNomadToken, idempotencyToken);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VolumesApi.CreateVolume: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateVolumeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.CreateVolumeWithHttpInfo(volumeId, action, cSIVolumeCreateRequest, region, varNamespace, xNomadToken, idempotencyToken);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VolumesApi.CreateVolumeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **volumeId** | **string** | Volume unique identifier. |  |
| **action** | **string** | The action to perform on the Volume (create, detach, delete). |  |
| **cSIVolumeCreateRequest** | [**CSIVolumeCreateRequest**](CSIVolumeCreateRequest.md) |  |  |
| **region** | **string?** | Filters results based on the specified region. | [optional]  |
| **varNamespace** | **string?** | Filters results based on the specified namespace. | [optional]  |
| **xNomadToken** | **string?** | A Nomad ACL token. | [optional]  |
| **idempotencyToken** | **string?** | Can be used to ensure operations are only run once. | [optional]  |

### Return type

void (empty response body)

### Authorization

[X-Nomad-Token](../README.md#X-Nomad-Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  * X-Nomad-Index - A unique identifier representing the current state of the requested resource. On a new Nomad cluster the value of this index starts at 1. <br>  * X-Nomad-KnownLeader - Boolean indicating if there is a known cluster leader. <br>  * X-Nomad-LastContact - The time in milliseconds that a server was last contacted by the leader node. <br>  |
| **400** | Bad request |  -  |
| **403** | Forbidden |  -  |
| **405** | Method not allowed |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletesnapshot"></a>
# **DeleteSnapshot**
> void DeleteSnapshot (string? region = null, string? varNamespace = null, string? xNomadToken = null, string? idempotencyToken = null, string? pluginId = null, string? snapshotId = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fermyon.Nomad.Api;
using Fermyon.Nomad.Client;
using Fermyon.Nomad.Model;

namespace Example
{
    public class DeleteSnapshotExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://127.0.0.1:4646/v1";
            // Configure API key authorization: X-Nomad-Token
            config.AddApiKey("X-Nomad-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Nomad-Token", "Bearer");

            var apiInstance = new VolumesApi(config);
            var region = "region_example";  // string? | Filters results based on the specified region. (optional) 
            var varNamespace = "varNamespace_example";  // string? | Filters results based on the specified namespace. (optional) 
            var xNomadToken = "xNomadToken_example";  // string? | A Nomad ACL token. (optional) 
            var idempotencyToken = "idempotencyToken_example";  // string? | Can be used to ensure operations are only run once. (optional) 
            var pluginId = "pluginId_example";  // string? | Filters volume lists by plugin ID. (optional) 
            var snapshotId = "snapshotId_example";  // string? | The ID of the snapshot to target. (optional) 

            try
            {
                apiInstance.DeleteSnapshot(region, varNamespace, xNomadToken, idempotencyToken, pluginId, snapshotId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VolumesApi.DeleteSnapshot: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteSnapshotWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.DeleteSnapshotWithHttpInfo(region, varNamespace, xNomadToken, idempotencyToken, pluginId, snapshotId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VolumesApi.DeleteSnapshotWithHttpInfo: " + e.Message);
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
| **pluginId** | **string?** | Filters volume lists by plugin ID. | [optional]  |
| **snapshotId** | **string?** | The ID of the snapshot to target. | [optional]  |

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
| **200** |  |  * X-Nomad-Index - A unique identifier representing the current state of the requested resource. On a new Nomad cluster the value of this index starts at 1. <br>  |
| **400** | Bad request |  -  |
| **403** | Forbidden |  -  |
| **405** | Method not allowed |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletevolumeregistration"></a>
# **DeleteVolumeRegistration**
> void DeleteVolumeRegistration (string volumeId, string? region = null, string? varNamespace = null, string? xNomadToken = null, string? idempotencyToken = null, string? force = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fermyon.Nomad.Api;
using Fermyon.Nomad.Client;
using Fermyon.Nomad.Model;

namespace Example
{
    public class DeleteVolumeRegistrationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://127.0.0.1:4646/v1";
            // Configure API key authorization: X-Nomad-Token
            config.AddApiKey("X-Nomad-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Nomad-Token", "Bearer");

            var apiInstance = new VolumesApi(config);
            var volumeId = "volumeId_example";  // string | Volume unique identifier.
            var region = "region_example";  // string? | Filters results based on the specified region. (optional) 
            var varNamespace = "varNamespace_example";  // string? | Filters results based on the specified namespace. (optional) 
            var xNomadToken = "xNomadToken_example";  // string? | A Nomad ACL token. (optional) 
            var idempotencyToken = "idempotencyToken_example";  // string? | Can be used to ensure operations are only run once. (optional) 
            var force = "force_example";  // string? | Used to force the de-registration of a volume. (optional) 

            try
            {
                apiInstance.DeleteVolumeRegistration(volumeId, region, varNamespace, xNomadToken, idempotencyToken, force);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VolumesApi.DeleteVolumeRegistration: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteVolumeRegistrationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.DeleteVolumeRegistrationWithHttpInfo(volumeId, region, varNamespace, xNomadToken, idempotencyToken, force);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VolumesApi.DeleteVolumeRegistrationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **volumeId** | **string** | Volume unique identifier. |  |
| **region** | **string?** | Filters results based on the specified region. | [optional]  |
| **varNamespace** | **string?** | Filters results based on the specified namespace. | [optional]  |
| **xNomadToken** | **string?** | A Nomad ACL token. | [optional]  |
| **idempotencyToken** | **string?** | Can be used to ensure operations are only run once. | [optional]  |
| **force** | **string?** | Used to force the de-registration of a volume. | [optional]  |

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
| **200** |  |  * X-Nomad-Index - A unique identifier representing the current state of the requested resource. On a new Nomad cluster the value of this index starts at 1. <br>  |
| **400** | Bad request |  -  |
| **403** | Forbidden |  -  |
| **405** | Method not allowed |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="detachordeletevolume"></a>
# **DetachOrDeleteVolume**
> void DetachOrDeleteVolume (string volumeId, string action, string? region = null, string? varNamespace = null, string? xNomadToken = null, string? idempotencyToken = null, string? node = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fermyon.Nomad.Api;
using Fermyon.Nomad.Client;
using Fermyon.Nomad.Model;

namespace Example
{
    public class DetachOrDeleteVolumeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://127.0.0.1:4646/v1";
            // Configure API key authorization: X-Nomad-Token
            config.AddApiKey("X-Nomad-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Nomad-Token", "Bearer");

            var apiInstance = new VolumesApi(config);
            var volumeId = "volumeId_example";  // string | Volume unique identifier.
            var action = "action_example";  // string | The action to perform on the Volume (create, detach, delete).
            var region = "region_example";  // string? | Filters results based on the specified region. (optional) 
            var varNamespace = "varNamespace_example";  // string? | Filters results based on the specified namespace. (optional) 
            var xNomadToken = "xNomadToken_example";  // string? | A Nomad ACL token. (optional) 
            var idempotencyToken = "idempotencyToken_example";  // string? | Can be used to ensure operations are only run once. (optional) 
            var node = "node_example";  // string? | Specifies node to target volume operation for. (optional) 

            try
            {
                apiInstance.DetachOrDeleteVolume(volumeId, action, region, varNamespace, xNomadToken, idempotencyToken, node);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VolumesApi.DetachOrDeleteVolume: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DetachOrDeleteVolumeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.DetachOrDeleteVolumeWithHttpInfo(volumeId, action, region, varNamespace, xNomadToken, idempotencyToken, node);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VolumesApi.DetachOrDeleteVolumeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **volumeId** | **string** | Volume unique identifier. |  |
| **action** | **string** | The action to perform on the Volume (create, detach, delete). |  |
| **region** | **string?** | Filters results based on the specified region. | [optional]  |
| **varNamespace** | **string?** | Filters results based on the specified namespace. | [optional]  |
| **xNomadToken** | **string?** | A Nomad ACL token. | [optional]  |
| **idempotencyToken** | **string?** | Can be used to ensure operations are only run once. | [optional]  |
| **node** | **string?** | Specifies node to target volume operation for. | [optional]  |

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
| **200** |  |  * X-Nomad-Index - A unique identifier representing the current state of the requested resource. On a new Nomad cluster the value of this index starts at 1. <br>  * X-Nomad-KnownLeader - Boolean indicating if there is a known cluster leader. <br>  * X-Nomad-LastContact - The time in milliseconds that a server was last contacted by the leader node. <br>  |
| **400** | Bad request |  -  |
| **403** | Forbidden |  -  |
| **405** | Method not allowed |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getexternalvolumes"></a>
# **GetExternalVolumes**
> CSIVolumeListExternalResponse GetExternalVolumes (string? region = null, string? varNamespace = null, int? index = null, string? wait = null, string? stale = null, string? prefix = null, string? xNomadToken = null, int? perPage = null, string? nextToken = null, string? pluginId = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fermyon.Nomad.Api;
using Fermyon.Nomad.Client;
using Fermyon.Nomad.Model;

namespace Example
{
    public class GetExternalVolumesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://127.0.0.1:4646/v1";
            // Configure API key authorization: X-Nomad-Token
            config.AddApiKey("X-Nomad-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Nomad-Token", "Bearer");

            var apiInstance = new VolumesApi(config);
            var region = "region_example";  // string? | Filters results based on the specified region. (optional) 
            var varNamespace = "varNamespace_example";  // string? | Filters results based on the specified namespace. (optional) 
            var index = 56;  // int? | If set, wait until query exceeds given index. Must be provided with WaitParam. (optional) 
            var wait = "wait_example";  // string? | Provided with IndexParam to wait for change. (optional) 
            var stale = "stale_example";  // string? | If present, results will include stale reads. (optional) 
            var prefix = "prefix_example";  // string? | Constrains results to jobs that start with the defined prefix (optional) 
            var xNomadToken = "xNomadToken_example";  // string? | A Nomad ACL token. (optional) 
            var perPage = 56;  // int? | Maximum number of results to return. (optional) 
            var nextToken = "nextToken_example";  // string? | Indicates where to start paging for queries that support pagination. (optional) 
            var pluginId = "pluginId_example";  // string? | Filters volume lists by plugin ID. (optional) 

            try
            {
                CSIVolumeListExternalResponse result = apiInstance.GetExternalVolumes(region, varNamespace, index, wait, stale, prefix, xNomadToken, perPage, nextToken, pluginId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VolumesApi.GetExternalVolumes: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetExternalVolumesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<CSIVolumeListExternalResponse> response = apiInstance.GetExternalVolumesWithHttpInfo(region, varNamespace, index, wait, stale, prefix, xNomadToken, perPage, nextToken, pluginId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VolumesApi.GetExternalVolumesWithHttpInfo: " + e.Message);
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
| **pluginId** | **string?** | Filters volume lists by plugin ID. | [optional]  |

### Return type

[**CSIVolumeListExternalResponse**](CSIVolumeListExternalResponse.md)

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

<a id="getsnapshots"></a>
# **GetSnapshots**
> CSISnapshotListResponse GetSnapshots (string? region = null, string? varNamespace = null, int? index = null, string? wait = null, string? stale = null, string? prefix = null, string? xNomadToken = null, int? perPage = null, string? nextToken = null, string? pluginId = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fermyon.Nomad.Api;
using Fermyon.Nomad.Client;
using Fermyon.Nomad.Model;

namespace Example
{
    public class GetSnapshotsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://127.0.0.1:4646/v1";
            // Configure API key authorization: X-Nomad-Token
            config.AddApiKey("X-Nomad-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Nomad-Token", "Bearer");

            var apiInstance = new VolumesApi(config);
            var region = "region_example";  // string? | Filters results based on the specified region. (optional) 
            var varNamespace = "varNamespace_example";  // string? | Filters results based on the specified namespace. (optional) 
            var index = 56;  // int? | If set, wait until query exceeds given index. Must be provided with WaitParam. (optional) 
            var wait = "wait_example";  // string? | Provided with IndexParam to wait for change. (optional) 
            var stale = "stale_example";  // string? | If present, results will include stale reads. (optional) 
            var prefix = "prefix_example";  // string? | Constrains results to jobs that start with the defined prefix (optional) 
            var xNomadToken = "xNomadToken_example";  // string? | A Nomad ACL token. (optional) 
            var perPage = 56;  // int? | Maximum number of results to return. (optional) 
            var nextToken = "nextToken_example";  // string? | Indicates where to start paging for queries that support pagination. (optional) 
            var pluginId = "pluginId_example";  // string? | Filters volume lists by plugin ID. (optional) 

            try
            {
                CSISnapshotListResponse result = apiInstance.GetSnapshots(region, varNamespace, index, wait, stale, prefix, xNomadToken, perPage, nextToken, pluginId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VolumesApi.GetSnapshots: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSnapshotsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<CSISnapshotListResponse> response = apiInstance.GetSnapshotsWithHttpInfo(region, varNamespace, index, wait, stale, prefix, xNomadToken, perPage, nextToken, pluginId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VolumesApi.GetSnapshotsWithHttpInfo: " + e.Message);
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
| **pluginId** | **string?** | Filters volume lists by plugin ID. | [optional]  |

### Return type

[**CSISnapshotListResponse**](CSISnapshotListResponse.md)

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

<a id="getvolume"></a>
# **GetVolume**
> CSIVolume GetVolume (string volumeId, string? region = null, string? varNamespace = null, int? index = null, string? wait = null, string? stale = null, string? prefix = null, string? xNomadToken = null, int? perPage = null, string? nextToken = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fermyon.Nomad.Api;
using Fermyon.Nomad.Client;
using Fermyon.Nomad.Model;

namespace Example
{
    public class GetVolumeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://127.0.0.1:4646/v1";
            // Configure API key authorization: X-Nomad-Token
            config.AddApiKey("X-Nomad-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Nomad-Token", "Bearer");

            var apiInstance = new VolumesApi(config);
            var volumeId = "volumeId_example";  // string | Volume unique identifier.
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
                CSIVolume result = apiInstance.GetVolume(volumeId, region, varNamespace, index, wait, stale, prefix, xNomadToken, perPage, nextToken);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VolumesApi.GetVolume: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetVolumeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<CSIVolume> response = apiInstance.GetVolumeWithHttpInfo(volumeId, region, varNamespace, index, wait, stale, prefix, xNomadToken, perPage, nextToken);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VolumesApi.GetVolumeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **volumeId** | **string** | Volume unique identifier. |  |
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

[**CSIVolume**](CSIVolume.md)

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

<a id="getvolumes"></a>
# **GetVolumes**
> List&lt;CSIVolumeListStub&gt; GetVolumes (string? region = null, string? varNamespace = null, int? index = null, string? wait = null, string? stale = null, string? prefix = null, string? xNomadToken = null, int? perPage = null, string? nextToken = null, string? nodeId = null, string? pluginId = null, string? type = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fermyon.Nomad.Api;
using Fermyon.Nomad.Client;
using Fermyon.Nomad.Model;

namespace Example
{
    public class GetVolumesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://127.0.0.1:4646/v1";
            // Configure API key authorization: X-Nomad-Token
            config.AddApiKey("X-Nomad-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Nomad-Token", "Bearer");

            var apiInstance = new VolumesApi(config);
            var region = "region_example";  // string? | Filters results based on the specified region. (optional) 
            var varNamespace = "varNamespace_example";  // string? | Filters results based on the specified namespace. (optional) 
            var index = 56;  // int? | If set, wait until query exceeds given index. Must be provided with WaitParam. (optional) 
            var wait = "wait_example";  // string? | Provided with IndexParam to wait for change. (optional) 
            var stale = "stale_example";  // string? | If present, results will include stale reads. (optional) 
            var prefix = "prefix_example";  // string? | Constrains results to jobs that start with the defined prefix (optional) 
            var xNomadToken = "xNomadToken_example";  // string? | A Nomad ACL token. (optional) 
            var perPage = 56;  // int? | Maximum number of results to return. (optional) 
            var nextToken = "nextToken_example";  // string? | Indicates where to start paging for queries that support pagination. (optional) 
            var nodeId = "nodeId_example";  // string? | Filters volume lists by node ID. (optional) 
            var pluginId = "pluginId_example";  // string? | Filters volume lists by plugin ID. (optional) 
            var type = "type_example";  // string? | Filters volume lists to a specific type. (optional) 

            try
            {
                List<CSIVolumeListStub> result = apiInstance.GetVolumes(region, varNamespace, index, wait, stale, prefix, xNomadToken, perPage, nextToken, nodeId, pluginId, type);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VolumesApi.GetVolumes: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetVolumesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<CSIVolumeListStub>> response = apiInstance.GetVolumesWithHttpInfo(region, varNamespace, index, wait, stale, prefix, xNomadToken, perPage, nextToken, nodeId, pluginId, type);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VolumesApi.GetVolumesWithHttpInfo: " + e.Message);
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
| **nodeId** | **string?** | Filters volume lists by node ID. | [optional]  |
| **pluginId** | **string?** | Filters volume lists by plugin ID. | [optional]  |
| **type** | **string?** | Filters volume lists to a specific type. | [optional]  |

### Return type

[**List&lt;CSIVolumeListStub&gt;**](CSIVolumeListStub.md)

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

<a id="postsnapshot"></a>
# **PostSnapshot**
> CSISnapshotCreateResponse PostSnapshot (CSISnapshotCreateRequest cSISnapshotCreateRequest, string? region = null, string? varNamespace = null, string? xNomadToken = null, string? idempotencyToken = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fermyon.Nomad.Api;
using Fermyon.Nomad.Client;
using Fermyon.Nomad.Model;

namespace Example
{
    public class PostSnapshotExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://127.0.0.1:4646/v1";
            // Configure API key authorization: X-Nomad-Token
            config.AddApiKey("X-Nomad-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Nomad-Token", "Bearer");

            var apiInstance = new VolumesApi(config);
            var cSISnapshotCreateRequest = new CSISnapshotCreateRequest(); // CSISnapshotCreateRequest | 
            var region = "region_example";  // string? | Filters results based on the specified region. (optional) 
            var varNamespace = "varNamespace_example";  // string? | Filters results based on the specified namespace. (optional) 
            var xNomadToken = "xNomadToken_example";  // string? | A Nomad ACL token. (optional) 
            var idempotencyToken = "idempotencyToken_example";  // string? | Can be used to ensure operations are only run once. (optional) 

            try
            {
                CSISnapshotCreateResponse result = apiInstance.PostSnapshot(cSISnapshotCreateRequest, region, varNamespace, xNomadToken, idempotencyToken);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VolumesApi.PostSnapshot: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostSnapshotWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<CSISnapshotCreateResponse> response = apiInstance.PostSnapshotWithHttpInfo(cSISnapshotCreateRequest, region, varNamespace, xNomadToken, idempotencyToken);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VolumesApi.PostSnapshotWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **cSISnapshotCreateRequest** | [**CSISnapshotCreateRequest**](CSISnapshotCreateRequest.md) |  |  |
| **region** | **string?** | Filters results based on the specified region. | [optional]  |
| **varNamespace** | **string?** | Filters results based on the specified namespace. | [optional]  |
| **xNomadToken** | **string?** | A Nomad ACL token. | [optional]  |
| **idempotencyToken** | **string?** | Can be used to ensure operations are only run once. | [optional]  |

### Return type

[**CSISnapshotCreateResponse**](CSISnapshotCreateResponse.md)

### Authorization

[X-Nomad-Token](../README.md#X-Nomad-Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  * X-Nomad-Index - A unique identifier representing the current state of the requested resource. On a new Nomad cluster the value of this index starts at 1. <br>  |
| **400** | Bad request |  -  |
| **403** | Forbidden |  -  |
| **405** | Method not allowed |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="postvolume"></a>
# **PostVolume**
> void PostVolume (CSIVolumeRegisterRequest cSIVolumeRegisterRequest, string? region = null, string? varNamespace = null, string? xNomadToken = null, string? idempotencyToken = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fermyon.Nomad.Api;
using Fermyon.Nomad.Client;
using Fermyon.Nomad.Model;

namespace Example
{
    public class PostVolumeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://127.0.0.1:4646/v1";
            // Configure API key authorization: X-Nomad-Token
            config.AddApiKey("X-Nomad-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Nomad-Token", "Bearer");

            var apiInstance = new VolumesApi(config);
            var cSIVolumeRegisterRequest = new CSIVolumeRegisterRequest(); // CSIVolumeRegisterRequest | 
            var region = "region_example";  // string? | Filters results based on the specified region. (optional) 
            var varNamespace = "varNamespace_example";  // string? | Filters results based on the specified namespace. (optional) 
            var xNomadToken = "xNomadToken_example";  // string? | A Nomad ACL token. (optional) 
            var idempotencyToken = "idempotencyToken_example";  // string? | Can be used to ensure operations are only run once. (optional) 

            try
            {
                apiInstance.PostVolume(cSIVolumeRegisterRequest, region, varNamespace, xNomadToken, idempotencyToken);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VolumesApi.PostVolume: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostVolumeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.PostVolumeWithHttpInfo(cSIVolumeRegisterRequest, region, varNamespace, xNomadToken, idempotencyToken);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VolumesApi.PostVolumeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **cSIVolumeRegisterRequest** | [**CSIVolumeRegisterRequest**](CSIVolumeRegisterRequest.md) |  |  |
| **region** | **string?** | Filters results based on the specified region. | [optional]  |
| **varNamespace** | **string?** | Filters results based on the specified namespace. | [optional]  |
| **xNomadToken** | **string?** | A Nomad ACL token. | [optional]  |
| **idempotencyToken** | **string?** | Can be used to ensure operations are only run once. | [optional]  |

### Return type

void (empty response body)

### Authorization

[X-Nomad-Token](../README.md#X-Nomad-Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  * X-Nomad-Index - A unique identifier representing the current state of the requested resource. On a new Nomad cluster the value of this index starts at 1. <br>  * X-Nomad-KnownLeader - Boolean indicating if there is a known cluster leader. <br>  * X-Nomad-LastContact - The time in milliseconds that a server was last contacted by the leader node. <br>  |
| **400** | Bad request |  -  |
| **403** | Forbidden |  -  |
| **405** | Method not allowed |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="postvolumeregistration"></a>
# **PostVolumeRegistration**
> void PostVolumeRegistration (string volumeId, CSIVolumeRegisterRequest cSIVolumeRegisterRequest, string? region = null, string? varNamespace = null, string? xNomadToken = null, string? idempotencyToken = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fermyon.Nomad.Api;
using Fermyon.Nomad.Client;
using Fermyon.Nomad.Model;

namespace Example
{
    public class PostVolumeRegistrationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://127.0.0.1:4646/v1";
            // Configure API key authorization: X-Nomad-Token
            config.AddApiKey("X-Nomad-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Nomad-Token", "Bearer");

            var apiInstance = new VolumesApi(config);
            var volumeId = "volumeId_example";  // string | Volume unique identifier.
            var cSIVolumeRegisterRequest = new CSIVolumeRegisterRequest(); // CSIVolumeRegisterRequest | 
            var region = "region_example";  // string? | Filters results based on the specified region. (optional) 
            var varNamespace = "varNamespace_example";  // string? | Filters results based on the specified namespace. (optional) 
            var xNomadToken = "xNomadToken_example";  // string? | A Nomad ACL token. (optional) 
            var idempotencyToken = "idempotencyToken_example";  // string? | Can be used to ensure operations are only run once. (optional) 

            try
            {
                apiInstance.PostVolumeRegistration(volumeId, cSIVolumeRegisterRequest, region, varNamespace, xNomadToken, idempotencyToken);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VolumesApi.PostVolumeRegistration: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostVolumeRegistrationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.PostVolumeRegistrationWithHttpInfo(volumeId, cSIVolumeRegisterRequest, region, varNamespace, xNomadToken, idempotencyToken);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VolumesApi.PostVolumeRegistrationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **volumeId** | **string** | Volume unique identifier. |  |
| **cSIVolumeRegisterRequest** | [**CSIVolumeRegisterRequest**](CSIVolumeRegisterRequest.md) |  |  |
| **region** | **string?** | Filters results based on the specified region. | [optional]  |
| **varNamespace** | **string?** | Filters results based on the specified namespace. | [optional]  |
| **xNomadToken** | **string?** | A Nomad ACL token. | [optional]  |
| **idempotencyToken** | **string?** | Can be used to ensure operations are only run once. | [optional]  |

### Return type

void (empty response body)

### Authorization

[X-Nomad-Token](../README.md#X-Nomad-Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  * X-Nomad-Index - A unique identifier representing the current state of the requested resource. On a new Nomad cluster the value of this index starts at 1. <br>  |
| **400** | Bad request |  -  |
| **403** | Forbidden |  -  |
| **405** | Method not allowed |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

