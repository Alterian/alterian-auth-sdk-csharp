# Alterian.AUTH.Api.CertificatesApi

All URIs are relative to *http://localhost/auth/api.svc/jsonsdk*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddCertificate**](CertificatesApi.md#addcertificate) | **POST** /AddCertificate | Adds a certificate for use with single sign on |
| [**DeleteCertificate**](CertificatesApi.md#deletecertificate) | **POST** /DeleteCertificate | Deletes the specified certificate |
| [**GetCertificate**](CertificatesApi.md#getcertificate) | **POST** /GetCertificate | Gets the specified certificate |
| [**GetCertificates**](CertificatesApi.md#getcertificates) | **POST** /GetCertificates | Gets a list of available certificates |
| [**UpdateCertificate**](CertificatesApi.md#updatecertificate) | **POST** /UpdateCertificate | Updates information associated with a certificate |

<a id="addcertificate"></a>
# **AddCertificate**
> AddCertificateDefaultResponse AddCertificate (AddCertificateRequest addCertificateRequest)

Adds a certificate for use with single sign on

Adds a certificate for use with single sign on

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.AUTH.Api;
using Alterian.AUTH.Client;
using Alterian.AUTH.Model;

namespace Example
{
    public class AddCertificateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/auth/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new CertificatesApi(config);
            var addCertificateRequest = new AddCertificateRequest(); // AddCertificateRequest | Adds a certificate for use with single sign on

            try
            {
                // Adds a certificate for use with single sign on
                AddCertificateDefaultResponse result = apiInstance.AddCertificate(addCertificateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CertificatesApi.AddCertificate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddCertificateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Adds a certificate for use with single sign on
    ApiResponse<AddCertificateDefaultResponse> response = apiInstance.AddCertificateWithHttpInfo(addCertificateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CertificatesApi.AddCertificateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **addCertificateRequest** | [**AddCertificateRequest**](AddCertificateRequest.md) | Adds a certificate for use with single sign on |  |

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

<a id="deletecertificate"></a>
# **DeleteCertificate**
> LogoutDefaultResponse DeleteCertificate (DeleteCertificateRequest deleteCertificateRequest)

Deletes the specified certificate

Deletes the specified certificate

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.AUTH.Api;
using Alterian.AUTH.Client;
using Alterian.AUTH.Model;

namespace Example
{
    public class DeleteCertificateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/auth/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new CertificatesApi(config);
            var deleteCertificateRequest = new DeleteCertificateRequest(); // DeleteCertificateRequest | Deletes the specified certificate

            try
            {
                // Deletes the specified certificate
                LogoutDefaultResponse result = apiInstance.DeleteCertificate(deleteCertificateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CertificatesApi.DeleteCertificate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteCertificateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes the specified certificate
    ApiResponse<LogoutDefaultResponse> response = apiInstance.DeleteCertificateWithHttpInfo(deleteCertificateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CertificatesApi.DeleteCertificateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **deleteCertificateRequest** | [**DeleteCertificateRequest**](DeleteCertificateRequest.md) | Deletes the specified certificate |  |

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

<a id="getcertificate"></a>
# **GetCertificate**
> GetCertificateDefaultResponse GetCertificate (GetCertificateRequest getCertificateRequest)

Gets the specified certificate

Gets the specified certificate

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.AUTH.Api;
using Alterian.AUTH.Client;
using Alterian.AUTH.Model;

namespace Example
{
    public class GetCertificateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/auth/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new CertificatesApi(config);
            var getCertificateRequest = new GetCertificateRequest(); // GetCertificateRequest | Gets the specified certificate

            try
            {
                // Gets the specified certificate
                GetCertificateDefaultResponse result = apiInstance.GetCertificate(getCertificateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CertificatesApi.GetCertificate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCertificateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets the specified certificate
    ApiResponse<GetCertificateDefaultResponse> response = apiInstance.GetCertificateWithHttpInfo(getCertificateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CertificatesApi.GetCertificateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getCertificateRequest** | [**GetCertificateRequest**](GetCertificateRequest.md) | Gets the specified certificate |  |

### Return type

[**GetCertificateDefaultResponse**](GetCertificateDefaultResponse.md)

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

<a id="getcertificates"></a>
# **GetCertificates**
> GetCertificatesDefaultResponse GetCertificates (GetCertificatesRequest getCertificatesRequest)

Gets a list of available certificates

Gets a list of available certificates

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.AUTH.Api;
using Alterian.AUTH.Client;
using Alterian.AUTH.Model;

namespace Example
{
    public class GetCertificatesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/auth/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new CertificatesApi(config);
            var getCertificatesRequest = new GetCertificatesRequest(); // GetCertificatesRequest | Gets a list of available certificates

            try
            {
                // Gets a list of available certificates
                GetCertificatesDefaultResponse result = apiInstance.GetCertificates(getCertificatesRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CertificatesApi.GetCertificates: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCertificatesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets a list of available certificates
    ApiResponse<GetCertificatesDefaultResponse> response = apiInstance.GetCertificatesWithHttpInfo(getCertificatesRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CertificatesApi.GetCertificatesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getCertificatesRequest** | [**GetCertificatesRequest**](GetCertificatesRequest.md) | Gets a list of available certificates |  |

### Return type

[**GetCertificatesDefaultResponse**](GetCertificatesDefaultResponse.md)

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

<a id="updatecertificate"></a>
# **UpdateCertificate**
> LogoutDefaultResponse UpdateCertificate (UpdateCertificateRequest updateCertificateRequest)

Updates information associated with a certificate

Updates information associated with a certificate

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.AUTH.Api;
using Alterian.AUTH.Client;
using Alterian.AUTH.Model;

namespace Example
{
    public class UpdateCertificateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/auth/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new CertificatesApi(config);
            var updateCertificateRequest = new UpdateCertificateRequest(); // UpdateCertificateRequest | Updates information associated with a certificate

            try
            {
                // Updates information associated with a certificate
                LogoutDefaultResponse result = apiInstance.UpdateCertificate(updateCertificateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CertificatesApi.UpdateCertificate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateCertificateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates information associated with a certificate
    ApiResponse<LogoutDefaultResponse> response = apiInstance.UpdateCertificateWithHttpInfo(updateCertificateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CertificatesApi.UpdateCertificateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **updateCertificateRequest** | [**UpdateCertificateRequest**](UpdateCertificateRequest.md) | Updates information associated with a certificate |  |

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

