# Alterian.AUTH.Api.MetadataApi

All URIs are relative to *http://localhost/auth/api.svc/jsonsdk*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetAPIMetadata**](MetadataApi.md#getapimetadata) | **POST** /GetAPIMetadata | Returns back a list of @see(APIMetadata) objects from the system. This allows the caller to discover all the methods and class types of this API, including validation rules. |

<a id="getapimetadata"></a>
# **GetAPIMetadata**
> GetAPIMetadataDefaultResponse GetAPIMetadata (GetAPIMetadataRequest getAPIMetadataRequest)

Returns back a list of @see(APIMetadata) objects from the system. This allows the caller to discover all the methods and class types of this API, including validation rules.

Returns back a list of @see(APIMetadata) objects from the system. This allows the caller to discover all the methods and class types of this API, including validation rules.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.AUTH.Api;
using Alterian.AUTH.Client;
using Alterian.AUTH.Model;

namespace Example
{
    public class GetAPIMetadataExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/auth/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new MetadataApi(config);
            var getAPIMetadataRequest = new GetAPIMetadataRequest(); // GetAPIMetadataRequest | Returns back a list of @see(APIMetadata) objects from the system. This allows the caller to discover all the methods and class types of this API, including validation rules.

            try
            {
                // Returns back a list of @see(APIMetadata) objects from the system. This allows the caller to discover all the methods and class types of this API, including validation rules.
                GetAPIMetadataDefaultResponse result = apiInstance.GetAPIMetadata(getAPIMetadataRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MetadataApi.GetAPIMetadata: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAPIMetadataWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns back a list of @see(APIMetadata) objects from the system. This allows the caller to discover all the methods and class types of this API, including validation rules.
    ApiResponse<GetAPIMetadataDefaultResponse> response = apiInstance.GetAPIMetadataWithHttpInfo(getAPIMetadataRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MetadataApi.GetAPIMetadataWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getAPIMetadataRequest** | [**GetAPIMetadataRequest**](GetAPIMetadataRequest.md) | Returns back a list of @see(APIMetadata) objects from the system. This allows the caller to discover all the methods and class types of this API, including validation rules. |  |

### Return type

[**GetAPIMetadataDefaultResponse**](GetAPIMetadataDefaultResponse.md)

### Authorization

[TokenAuth](../README.md#TokenAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **0** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

