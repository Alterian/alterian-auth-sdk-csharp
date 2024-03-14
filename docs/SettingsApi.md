# Alterian.AUTH.Api.SettingsApi

All URIs are relative to *http://localhost/auth/api.svc/jsonsdk*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddSetting**](SettingsApi.md#addsetting) | **POST** /AddSetting | Adds in a setting which can then be mapped to an issuer for the purposes of claims authentication. |
| [**DeleteSetting**](SettingsApi.md#deletesetting) | **POST** /DeleteSetting | Deletes a setting |
| [**GetSetting**](SettingsApi.md#getsetting) | **POST** /GetSetting | Read a setting |
| [**GetSettings**](SettingsApi.md#getsettings) | **POST** /GetSettings | Reads a list of settings |
| [**GetSettingsValues**](SettingsApi.md#getsettingsvalues) | **POST** /GetSettingsValues | Reads settings and their values |
| [**SetEMServiceURL**](SettingsApi.md#setemserviceurl) | **POST** /SetEMServiceURL | Updates the EM service URL |
| [**UpdateSetting**](SettingsApi.md#updatesetting) | **POST** /UpdateSetting | Updates a setting |

<a id="addsetting"></a>
# **AddSetting**
> AddCertificateDefaultResponse AddSetting (AddSettingRequest addSettingRequest)

Adds in a setting which can then be mapped to an issuer for the purposes of claims authentication.

Adds in a setting which can then be mapped to an issuer for the purposes of claims authentication.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.AUTH.Api;
using Alterian.AUTH.Client;
using Alterian.AUTH.Model;

namespace Example
{
    public class AddSettingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/auth/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new SettingsApi(config);
            var addSettingRequest = new AddSettingRequest(); // AddSettingRequest | Adds in a setting which can then be mapped to an issuer for the purposes of claims authentication.

            try
            {
                // Adds in a setting which can then be mapped to an issuer for the purposes of claims authentication.
                AddCertificateDefaultResponse result = apiInstance.AddSetting(addSettingRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsApi.AddSetting: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddSettingWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Adds in a setting which can then be mapped to an issuer for the purposes of claims authentication.
    ApiResponse<AddCertificateDefaultResponse> response = apiInstance.AddSettingWithHttpInfo(addSettingRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SettingsApi.AddSettingWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **addSettingRequest** | [**AddSettingRequest**](AddSettingRequest.md) | Adds in a setting which can then be mapped to an issuer for the purposes of claims authentication. |  |

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

<a id="deletesetting"></a>
# **DeleteSetting**
> LogoutDefaultResponse DeleteSetting (DeleteSettingRequest deleteSettingRequest)

Deletes a setting

Deletes a setting

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.AUTH.Api;
using Alterian.AUTH.Client;
using Alterian.AUTH.Model;

namespace Example
{
    public class DeleteSettingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/auth/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new SettingsApi(config);
            var deleteSettingRequest = new DeleteSettingRequest(); // DeleteSettingRequest | Deletes a setting

            try
            {
                // Deletes a setting
                LogoutDefaultResponse result = apiInstance.DeleteSetting(deleteSettingRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsApi.DeleteSetting: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteSettingWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes a setting
    ApiResponse<LogoutDefaultResponse> response = apiInstance.DeleteSettingWithHttpInfo(deleteSettingRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SettingsApi.DeleteSettingWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **deleteSettingRequest** | [**DeleteSettingRequest**](DeleteSettingRequest.md) | Deletes a setting |  |

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

<a id="getsetting"></a>
# **GetSetting**
> GetSettingDefaultResponse GetSetting (GetSettingRequest getSettingRequest)

Read a setting

Read a setting

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.AUTH.Api;
using Alterian.AUTH.Client;
using Alterian.AUTH.Model;

namespace Example
{
    public class GetSettingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/auth/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new SettingsApi(config);
            var getSettingRequest = new GetSettingRequest(); // GetSettingRequest | Read a setting

            try
            {
                // Read a setting
                GetSettingDefaultResponse result = apiInstance.GetSetting(getSettingRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsApi.GetSetting: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSettingWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Read a setting
    ApiResponse<GetSettingDefaultResponse> response = apiInstance.GetSettingWithHttpInfo(getSettingRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SettingsApi.GetSettingWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getSettingRequest** | [**GetSettingRequest**](GetSettingRequest.md) | Read a setting |  |

### Return type

[**GetSettingDefaultResponse**](GetSettingDefaultResponse.md)

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

<a id="getsettings"></a>
# **GetSettings**
> GetSettingsDefaultResponse GetSettings (GetSettingsRequest getSettingsRequest)

Reads a list of settings

Reads a list of settings

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.AUTH.Api;
using Alterian.AUTH.Client;
using Alterian.AUTH.Model;

namespace Example
{
    public class GetSettingsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/auth/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new SettingsApi(config);
            var getSettingsRequest = new GetSettingsRequest(); // GetSettingsRequest | Reads a list of settings

            try
            {
                // Reads a list of settings
                GetSettingsDefaultResponse result = apiInstance.GetSettings(getSettingsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsApi.GetSettings: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSettingsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reads a list of settings
    ApiResponse<GetSettingsDefaultResponse> response = apiInstance.GetSettingsWithHttpInfo(getSettingsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SettingsApi.GetSettingsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getSettingsRequest** | [**GetSettingsRequest**](GetSettingsRequest.md) | Reads a list of settings |  |

### Return type

[**GetSettingsDefaultResponse**](GetSettingsDefaultResponse.md)

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

<a id="getsettingsvalues"></a>
# **GetSettingsValues**
> GetSettingsDefaultResponse GetSettingsValues (GetSettingsValuesRequest getSettingsValuesRequest)

Reads settings and their values

Reads settings and their values

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.AUTH.Api;
using Alterian.AUTH.Client;
using Alterian.AUTH.Model;

namespace Example
{
    public class GetSettingsValuesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/auth/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new SettingsApi(config);
            var getSettingsValuesRequest = new GetSettingsValuesRequest(); // GetSettingsValuesRequest | Reads settings and their values

            try
            {
                // Reads settings and their values
                GetSettingsDefaultResponse result = apiInstance.GetSettingsValues(getSettingsValuesRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsApi.GetSettingsValues: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSettingsValuesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reads settings and their values
    ApiResponse<GetSettingsDefaultResponse> response = apiInstance.GetSettingsValuesWithHttpInfo(getSettingsValuesRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SettingsApi.GetSettingsValuesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getSettingsValuesRequest** | [**GetSettingsValuesRequest**](GetSettingsValuesRequest.md) | Reads settings and their values |  |

### Return type

[**GetSettingsDefaultResponse**](GetSettingsDefaultResponse.md)

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

<a id="setemserviceurl"></a>
# **SetEMServiceURL**
> LogoutDefaultResponse SetEMServiceURL (SetEMServiceURLRequest setEMServiceURLRequest)

Updates the EM service URL

Updates the EM service URL

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.AUTH.Api;
using Alterian.AUTH.Client;
using Alterian.AUTH.Model;

namespace Example
{
    public class SetEMServiceURLExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/auth/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new SettingsApi(config);
            var setEMServiceURLRequest = new SetEMServiceURLRequest(); // SetEMServiceURLRequest | Updates the EM service URL

            try
            {
                // Updates the EM service URL
                LogoutDefaultResponse result = apiInstance.SetEMServiceURL(setEMServiceURLRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsApi.SetEMServiceURL: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SetEMServiceURLWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates the EM service URL
    ApiResponse<LogoutDefaultResponse> response = apiInstance.SetEMServiceURLWithHttpInfo(setEMServiceURLRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SettingsApi.SetEMServiceURLWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **setEMServiceURLRequest** | [**SetEMServiceURLRequest**](SetEMServiceURLRequest.md) | Updates the EM service URL |  |

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

<a id="updatesetting"></a>
# **UpdateSetting**
> LogoutDefaultResponse UpdateSetting (AddSettingRequest addSettingRequest)

Updates a setting

Updates a setting

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.AUTH.Api;
using Alterian.AUTH.Client;
using Alterian.AUTH.Model;

namespace Example
{
    public class UpdateSettingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/auth/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new SettingsApi(config);
            var addSettingRequest = new AddSettingRequest(); // AddSettingRequest | Updates a setting

            try
            {
                // Updates a setting
                LogoutDefaultResponse result = apiInstance.UpdateSetting(addSettingRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsApi.UpdateSetting: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateSettingWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates a setting
    ApiResponse<LogoutDefaultResponse> response = apiInstance.UpdateSettingWithHttpInfo(addSettingRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SettingsApi.UpdateSettingWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **addSettingRequest** | [**AddSettingRequest**](AddSettingRequest.md) | Updates a setting |  |

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

