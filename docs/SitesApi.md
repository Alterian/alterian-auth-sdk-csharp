# Alterian.AUTH.Api.SitesApi

All URIs are relative to *http://localhost/auth/api.svc/jsonsdk*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetHostNames**](SitesApi.md#gethostnames) | **POST** /GetHostNames | This is the name of the server that you have IMS running on |
| [**GetSite**](SitesApi.md#getsite) | **POST** /GetSite | Return back a specific @see(AuthSite) |
| [**GetSiteTypes**](SitesApi.md#getsitetypes) | **POST** /GetSiteTypes | Return back a list of site types for use with @see(GetSites) |
| [**GetSites**](SitesApi.md#getsites) | **POST** /GetSites | Return back a list of @see(AuthSite)s; useful for APIs which require an authentication site identifier |

<a id="gethostnames"></a>
# **GetHostNames**
> GetHostNamesDefaultResponse GetHostNames (GetCertificatesRequest getCertificatesRequest)

This is the name of the server that you have IMS running on

This is the name of the server that you have IMS running on

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.AUTH.Api;
using Alterian.AUTH.Client;
using Alterian.AUTH.Model;

namespace Example
{
    public class GetHostNamesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/auth/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new SitesApi(config);
            var getCertificatesRequest = new GetCertificatesRequest(); // GetCertificatesRequest | This is the name of the server that you have IMS running on

            try
            {
                // This is the name of the server that you have IMS running on
                GetHostNamesDefaultResponse result = apiInstance.GetHostNames(getCertificatesRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SitesApi.GetHostNames: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetHostNamesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // This is the name of the server that you have IMS running on
    ApiResponse<GetHostNamesDefaultResponse> response = apiInstance.GetHostNamesWithHttpInfo(getCertificatesRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SitesApi.GetHostNamesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getCertificatesRequest** | [**GetCertificatesRequest**](GetCertificatesRequest.md) | This is the name of the server that you have IMS running on |  |

### Return type

[**GetHostNamesDefaultResponse**](GetHostNamesDefaultResponse.md)

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

<a id="getsite"></a>
# **GetSite**
> GetSiteDefaultResponse GetSite (GetSiteRequest getSiteRequest)

Return back a specific @see(AuthSite)

Return back a specific @see(AuthSite)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.AUTH.Api;
using Alterian.AUTH.Client;
using Alterian.AUTH.Model;

namespace Example
{
    public class GetSiteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/auth/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new SitesApi(config);
            var getSiteRequest = new GetSiteRequest(); // GetSiteRequest | Return back a specific @see(AuthSite)

            try
            {
                // Return back a specific @see(AuthSite)
                GetSiteDefaultResponse result = apiInstance.GetSite(getSiteRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SitesApi.GetSite: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSiteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Return back a specific @see(AuthSite)
    ApiResponse<GetSiteDefaultResponse> response = apiInstance.GetSiteWithHttpInfo(getSiteRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SitesApi.GetSiteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getSiteRequest** | [**GetSiteRequest**](GetSiteRequest.md) | Return back a specific @see(AuthSite) |  |

### Return type

[**GetSiteDefaultResponse**](GetSiteDefaultResponse.md)

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

<a id="getsitetypes"></a>
# **GetSiteTypes**
> GetSiteTypesDefaultResponse GetSiteTypes ()

Return back a list of site types for use with @see(GetSites)

Return back a list of site types for use with @see(GetSites)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.AUTH.Api;
using Alterian.AUTH.Client;
using Alterian.AUTH.Model;

namespace Example
{
    public class GetSiteTypesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/auth/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new SitesApi(config);

            try
            {
                // Return back a list of site types for use with @see(GetSites)
                GetSiteTypesDefaultResponse result = apiInstance.GetSiteTypes();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SitesApi.GetSiteTypes: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSiteTypesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Return back a list of site types for use with @see(GetSites)
    ApiResponse<GetSiteTypesDefaultResponse> response = apiInstance.GetSiteTypesWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SitesApi.GetSiteTypesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**GetSiteTypesDefaultResponse**](GetSiteTypesDefaultResponse.md)

### Authorization

[TokenAuth](../README.md#TokenAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **0** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getsites"></a>
# **GetSites**
> GetSitesDefaultResponse GetSites (GetSitesRequest getSitesRequest)

Return back a list of @see(AuthSite)s; useful for APIs which require an authentication site identifier

Return back a list of @see(AuthSite)s; useful for APIs which require an authentication site identifier

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.AUTH.Api;
using Alterian.AUTH.Client;
using Alterian.AUTH.Model;

namespace Example
{
    public class GetSitesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/auth/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new SitesApi(config);
            var getSitesRequest = new GetSitesRequest(); // GetSitesRequest | Return back a list of @see(AuthSite)s; useful for APIs which require an authentication site identifier

            try
            {
                // Return back a list of @see(AuthSite)s; useful for APIs which require an authentication site identifier
                GetSitesDefaultResponse result = apiInstance.GetSites(getSitesRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SitesApi.GetSites: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSitesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Return back a list of @see(AuthSite)s; useful for APIs which require an authentication site identifier
    ApiResponse<GetSitesDefaultResponse> response = apiInstance.GetSitesWithHttpInfo(getSitesRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SitesApi.GetSitesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getSitesRequest** | [**GetSitesRequest**](GetSitesRequest.md) | Return back a list of @see(AuthSite)s; useful for APIs which require an authentication site identifier |  |

### Return type

[**GetSitesDefaultResponse**](GetSitesDefaultResponse.md)

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

