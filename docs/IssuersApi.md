# Alterian.AUTH.Api.IssuersApi

All URIs are relative to *http://localhost/auth/api.svc/jsonsdk*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddIssuer**](IssuersApi.md#addissuer) | **POST** /AddIssuer | Adds an Issuer for a Certificate used with single sign on |
| [**DeleteIssuer**](IssuersApi.md#deleteissuer) | **POST** /DeleteIssuer | Deletes an @see(Issuer) for a Certificate used with single sign on |
| [**GetIssuer**](IssuersApi.md#getissuer) | **POST** /GetIssuer | Retrieves an Issuer for a Certificate used with single sign on |
| [**GetIssuers**](IssuersApi.md#getissuers) | **POST** /GetIssuers | Gets a list of available issuers |
| [**UpdateIssuer**](IssuersApi.md#updateissuer) | **POST** /UpdateIssuer | Updates information associated with a certificate&#39;s issuer |

<a id="addissuer"></a>
# **AddIssuer**
> AddCertificateDefaultResponse AddIssuer (AddIssuerRequest addIssuerRequest)

Adds an Issuer for a Certificate used with single sign on

Adds an Issuer for a Certificate used with single sign on

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.AUTH.Api;
using Alterian.AUTH.Client;
using Alterian.AUTH.Model;

namespace Example
{
    public class AddIssuerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/auth/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new IssuersApi(config);
            var addIssuerRequest = new AddIssuerRequest(); // AddIssuerRequest | Adds an Issuer for a Certificate used with single sign on

            try
            {
                // Adds an Issuer for a Certificate used with single sign on
                AddCertificateDefaultResponse result = apiInstance.AddIssuer(addIssuerRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssuersApi.AddIssuer: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddIssuerWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Adds an Issuer for a Certificate used with single sign on
    ApiResponse<AddCertificateDefaultResponse> response = apiInstance.AddIssuerWithHttpInfo(addIssuerRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssuersApi.AddIssuerWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **addIssuerRequest** | [**AddIssuerRequest**](AddIssuerRequest.md) | Adds an Issuer for a Certificate used with single sign on |  |

### Return type

[**AddCertificateDefaultResponse**](AddCertificateDefaultResponse.md)

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

<a id="deleteissuer"></a>
# **DeleteIssuer**
> LogoutDefaultResponse DeleteIssuer (DeleteIssuerRequest deleteIssuerRequest)

Deletes an @see(Issuer) for a Certificate used with single sign on

Deletes an @see(Issuer) for a Certificate used with single sign on

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.AUTH.Api;
using Alterian.AUTH.Client;
using Alterian.AUTH.Model;

namespace Example
{
    public class DeleteIssuerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/auth/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new IssuersApi(config);
            var deleteIssuerRequest = new DeleteIssuerRequest(); // DeleteIssuerRequest | Deletes an @see(Issuer) for a Certificate used with single sign on

            try
            {
                // Deletes an @see(Issuer) for a Certificate used with single sign on
                LogoutDefaultResponse result = apiInstance.DeleteIssuer(deleteIssuerRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssuersApi.DeleteIssuer: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteIssuerWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes an @see(Issuer) for a Certificate used with single sign on
    ApiResponse<LogoutDefaultResponse> response = apiInstance.DeleteIssuerWithHttpInfo(deleteIssuerRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssuersApi.DeleteIssuerWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **deleteIssuerRequest** | [**DeleteIssuerRequest**](DeleteIssuerRequest.md) | Deletes an @see(Issuer) for a Certificate used with single sign on |  |

### Return type

[**LogoutDefaultResponse**](LogoutDefaultResponse.md)

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

<a id="getissuer"></a>
# **GetIssuer**
> GetIssuerDefaultResponse GetIssuer (GetIssuerRequest getIssuerRequest)

Retrieves an Issuer for a Certificate used with single sign on

Retrieves an Issuer for a Certificate used with single sign on

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.AUTH.Api;
using Alterian.AUTH.Client;
using Alterian.AUTH.Model;

namespace Example
{
    public class GetIssuerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/auth/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new IssuersApi(config);
            var getIssuerRequest = new GetIssuerRequest(); // GetIssuerRequest | Retrieves an Issuer for a Certificate used with single sign on

            try
            {
                // Retrieves an Issuer for a Certificate used with single sign on
                GetIssuerDefaultResponse result = apiInstance.GetIssuer(getIssuerRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssuersApi.GetIssuer: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetIssuerWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves an Issuer for a Certificate used with single sign on
    ApiResponse<GetIssuerDefaultResponse> response = apiInstance.GetIssuerWithHttpInfo(getIssuerRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssuersApi.GetIssuerWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getIssuerRequest** | [**GetIssuerRequest**](GetIssuerRequest.md) | Retrieves an Issuer for a Certificate used with single sign on |  |

### Return type

[**GetIssuerDefaultResponse**](GetIssuerDefaultResponse.md)

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

<a id="getissuers"></a>
# **GetIssuers**
> GetIssuersDefaultResponse GetIssuers (GetCertificatesRequest getCertificatesRequest)

Gets a list of available issuers

Gets a list of available issuers

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.AUTH.Api;
using Alterian.AUTH.Client;
using Alterian.AUTH.Model;

namespace Example
{
    public class GetIssuersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/auth/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new IssuersApi(config);
            var getCertificatesRequest = new GetCertificatesRequest(); // GetCertificatesRequest | Gets a list of available issuers

            try
            {
                // Gets a list of available issuers
                GetIssuersDefaultResponse result = apiInstance.GetIssuers(getCertificatesRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssuersApi.GetIssuers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetIssuersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets a list of available issuers
    ApiResponse<GetIssuersDefaultResponse> response = apiInstance.GetIssuersWithHttpInfo(getCertificatesRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssuersApi.GetIssuersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getCertificatesRequest** | [**GetCertificatesRequest**](GetCertificatesRequest.md) | Gets a list of available issuers |  |

### Return type

[**GetIssuersDefaultResponse**](GetIssuersDefaultResponse.md)

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

<a id="updateissuer"></a>
# **UpdateIssuer**
> LogoutDefaultResponse UpdateIssuer (AddIssuerRequest addIssuerRequest)

Updates information associated with a certificate's issuer

Updates information associated with a certificate's issuer

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.AUTH.Api;
using Alterian.AUTH.Client;
using Alterian.AUTH.Model;

namespace Example
{
    public class UpdateIssuerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/auth/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new IssuersApi(config);
            var addIssuerRequest = new AddIssuerRequest(); // AddIssuerRequest | Updates information associated with a certificate's issuer

            try
            {
                // Updates information associated with a certificate's issuer
                LogoutDefaultResponse result = apiInstance.UpdateIssuer(addIssuerRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssuersApi.UpdateIssuer: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateIssuerWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates information associated with a certificate's issuer
    ApiResponse<LogoutDefaultResponse> response = apiInstance.UpdateIssuerWithHttpInfo(addIssuerRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssuersApi.UpdateIssuerWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **addIssuerRequest** | [**AddIssuerRequest**](AddIssuerRequest.md) | Updates information associated with a certificate&#39;s issuer |  |

### Return type

[**LogoutDefaultResponse**](LogoutDefaultResponse.md)

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

