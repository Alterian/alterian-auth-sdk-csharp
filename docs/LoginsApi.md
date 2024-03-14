# Alterian.AUTH.Api.LoginsApi

All URIs are relative to *http://localhost/auth/api.svc/jsonsdk*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddLogin**](LoginsApi.md#addlogin) | **POST** /AddLogin | Add a login into the system |
| [**DisableLogin**](LoginsApi.md#disablelogin) | **POST** /DisableLogin | Flag a login as disabled |
| [**EnableLogin**](LoginsApi.md#enablelogin) | **POST** /EnableLogin | Flag a login as enabled.  If a login has been expired due to inactivity, this will enable it to be logged into again |
| [**GetCurrentLogin**](LoginsApi.md#getcurrentlogin) | **POST** /GetCurrentLogin | Returns back info on the current login |
| [**GetLogin**](LoginsApi.md#getlogin) | **POST** /GetLogin | Return back info on a single login |
| [**GetLogins**](LoginsApi.md#getlogins) | **POST** /GetLogins | Query the login list by setting values, optionally including or excluding logins.  If you leave the settings value empty, you can query just by login id |
| [**RenameLogin**](LoginsApi.md#renamelogin) | **POST** /RenameLogin | Renames a login |
| [**UpdateLogin**](LoginsApi.md#updatelogin) | **POST** /UpdateLogin | Update a login |
| [**UpdateLoginEx**](LoginsApi.md#updateloginex) | **POST** /UpdateLoginEx | Updates pieces of a login |

<a id="addlogin"></a>
# **AddLogin**
> AddLoginDefaultResponse AddLogin (AddLoginRequest addLoginRequest)

Add a login into the system

Add a login into the system

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.AUTH.Api;
using Alterian.AUTH.Client;
using Alterian.AUTH.Model;

namespace Example
{
    public class AddLoginExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/auth/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new LoginsApi(config);
            var addLoginRequest = new AddLoginRequest(); // AddLoginRequest | Add a login into the system

            try
            {
                // Add a login into the system
                AddLoginDefaultResponse result = apiInstance.AddLogin(addLoginRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LoginsApi.AddLogin: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddLoginWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add a login into the system
    ApiResponse<AddLoginDefaultResponse> response = apiInstance.AddLoginWithHttpInfo(addLoginRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LoginsApi.AddLoginWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **addLoginRequest** | [**AddLoginRequest**](AddLoginRequest.md) | Add a login into the system |  |

### Return type

[**AddLoginDefaultResponse**](AddLoginDefaultResponse.md)

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

<a id="disablelogin"></a>
# **DisableLogin**
> LogoutDefaultResponse DisableLogin (DisableLoginRequest disableLoginRequest)

Flag a login as disabled

Flag a login as disabled

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.AUTH.Api;
using Alterian.AUTH.Client;
using Alterian.AUTH.Model;

namespace Example
{
    public class DisableLoginExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/auth/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new LoginsApi(config);
            var disableLoginRequest = new DisableLoginRequest(); // DisableLoginRequest | Flag a login as disabled

            try
            {
                // Flag a login as disabled
                LogoutDefaultResponse result = apiInstance.DisableLogin(disableLoginRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LoginsApi.DisableLogin: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DisableLoginWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Flag a login as disabled
    ApiResponse<LogoutDefaultResponse> response = apiInstance.DisableLoginWithHttpInfo(disableLoginRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LoginsApi.DisableLoginWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **disableLoginRequest** | [**DisableLoginRequest**](DisableLoginRequest.md) | Flag a login as disabled |  |

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

<a id="enablelogin"></a>
# **EnableLogin**
> LogoutDefaultResponse EnableLogin (EnableLoginRequest enableLoginRequest)

Flag a login as enabled.  If a login has been expired due to inactivity, this will enable it to be logged into again

Flag a login as enabled.  If a login has been expired due to inactivity, this will enable it to be logged into again

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.AUTH.Api;
using Alterian.AUTH.Client;
using Alterian.AUTH.Model;

namespace Example
{
    public class EnableLoginExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/auth/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new LoginsApi(config);
            var enableLoginRequest = new EnableLoginRequest(); // EnableLoginRequest | Flag a login as enabled.  If a login has been expired due to inactivity, this will enable it to be logged into again

            try
            {
                // Flag a login as enabled.  If a login has been expired due to inactivity, this will enable it to be logged into again
                LogoutDefaultResponse result = apiInstance.EnableLogin(enableLoginRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LoginsApi.EnableLogin: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EnableLoginWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Flag a login as enabled.  If a login has been expired due to inactivity, this will enable it to be logged into again
    ApiResponse<LogoutDefaultResponse> response = apiInstance.EnableLoginWithHttpInfo(enableLoginRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LoginsApi.EnableLoginWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **enableLoginRequest** | [**EnableLoginRequest**](EnableLoginRequest.md) | Flag a login as enabled.  If a login has been expired due to inactivity, this will enable it to be logged into again |  |

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

<a id="getcurrentlogin"></a>
# **GetCurrentLogin**
> GetCurrentLoginDefaultResponse GetCurrentLogin ()

Returns back info on the current login

Returns back info on the current login

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.AUTH.Api;
using Alterian.AUTH.Client;
using Alterian.AUTH.Model;

namespace Example
{
    public class GetCurrentLoginExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/auth/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new LoginsApi(config);

            try
            {
                // Returns back info on the current login
                GetCurrentLoginDefaultResponse result = apiInstance.GetCurrentLogin();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LoginsApi.GetCurrentLogin: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCurrentLoginWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns back info on the current login
    ApiResponse<GetCurrentLoginDefaultResponse> response = apiInstance.GetCurrentLoginWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LoginsApi.GetCurrentLoginWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**GetCurrentLoginDefaultResponse**](GetCurrentLoginDefaultResponse.md)

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

<a id="getlogin"></a>
# **GetLogin**
> GetCurrentLoginDefaultResponse GetLogin (GetLoginRequest getLoginRequest)

Return back info on a single login

Return back info on a single login

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.AUTH.Api;
using Alterian.AUTH.Client;
using Alterian.AUTH.Model;

namespace Example
{
    public class GetLoginExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/auth/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new LoginsApi(config);
            var getLoginRequest = new GetLoginRequest(); // GetLoginRequest | Return back info on a single login

            try
            {
                // Return back info on a single login
                GetCurrentLoginDefaultResponse result = apiInstance.GetLogin(getLoginRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LoginsApi.GetLogin: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetLoginWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Return back info on a single login
    ApiResponse<GetCurrentLoginDefaultResponse> response = apiInstance.GetLoginWithHttpInfo(getLoginRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LoginsApi.GetLoginWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getLoginRequest** | [**GetLoginRequest**](GetLoginRequest.md) | Return back info on a single login |  |

### Return type

[**GetCurrentLoginDefaultResponse**](GetCurrentLoginDefaultResponse.md)

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

<a id="getlogins"></a>
# **GetLogins**
> GetLoginsDefaultResponse GetLogins (GetLoginsRequest getLoginsRequest)

Query the login list by setting values, optionally including or excluding logins.  If you leave the settings value empty, you can query just by login id

Query the login list by setting values, optionally including or excluding logins.  If you leave the settings value empty, you can query just by login id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.AUTH.Api;
using Alterian.AUTH.Client;
using Alterian.AUTH.Model;

namespace Example
{
    public class GetLoginsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/auth/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new LoginsApi(config);
            var getLoginsRequest = new GetLoginsRequest(); // GetLoginsRequest | Query the login list by setting values, optionally including or excluding logins.  If you leave the settings value empty, you can query just by login id

            try
            {
                // Query the login list by setting values, optionally including or excluding logins.  If you leave the settings value empty, you can query just by login id
                GetLoginsDefaultResponse result = apiInstance.GetLogins(getLoginsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LoginsApi.GetLogins: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetLoginsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Query the login list by setting values, optionally including or excluding logins.  If you leave the settings value empty, you can query just by login id
    ApiResponse<GetLoginsDefaultResponse> response = apiInstance.GetLoginsWithHttpInfo(getLoginsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LoginsApi.GetLoginsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getLoginsRequest** | [**GetLoginsRequest**](GetLoginsRequest.md) | Query the login list by setting values, optionally including or excluding logins.  If you leave the settings value empty, you can query just by login id |  |

### Return type

[**GetLoginsDefaultResponse**](GetLoginsDefaultResponse.md)

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

<a id="renamelogin"></a>
# **RenameLogin**
> LogoutDefaultResponse RenameLogin (RenameLoginRequest renameLoginRequest)

Renames a login

Renames a login

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.AUTH.Api;
using Alterian.AUTH.Client;
using Alterian.AUTH.Model;

namespace Example
{
    public class RenameLoginExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/auth/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new LoginsApi(config);
            var renameLoginRequest = new RenameLoginRequest(); // RenameLoginRequest | Renames a login

            try
            {
                // Renames a login
                LogoutDefaultResponse result = apiInstance.RenameLogin(renameLoginRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LoginsApi.RenameLogin: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RenameLoginWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Renames a login
    ApiResponse<LogoutDefaultResponse> response = apiInstance.RenameLoginWithHttpInfo(renameLoginRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LoginsApi.RenameLoginWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **renameLoginRequest** | [**RenameLoginRequest**](RenameLoginRequest.md) | Renames a login |  |

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

<a id="updatelogin"></a>
# **UpdateLogin**
> LogoutDefaultResponse UpdateLogin (AddLoginRequest addLoginRequest)

Update a login

Update a login

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.AUTH.Api;
using Alterian.AUTH.Client;
using Alterian.AUTH.Model;

namespace Example
{
    public class UpdateLoginExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/auth/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new LoginsApi(config);
            var addLoginRequest = new AddLoginRequest(); // AddLoginRequest | Update a login

            try
            {
                // Update a login
                LogoutDefaultResponse result = apiInstance.UpdateLogin(addLoginRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LoginsApi.UpdateLogin: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateLoginWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update a login
    ApiResponse<LogoutDefaultResponse> response = apiInstance.UpdateLoginWithHttpInfo(addLoginRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LoginsApi.UpdateLoginWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **addLoginRequest** | [**AddLoginRequest**](AddLoginRequest.md) | Update a login |  |

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

<a id="updateloginex"></a>
# **UpdateLoginEx**
> LogoutDefaultResponse UpdateLoginEx (UpdateLoginExRequest updateLoginExRequest)

Updates pieces of a login

Updates pieces of a login

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.AUTH.Api;
using Alterian.AUTH.Client;
using Alterian.AUTH.Model;

namespace Example
{
    public class UpdateLoginExExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/auth/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new LoginsApi(config);
            var updateLoginExRequest = new UpdateLoginExRequest(); // UpdateLoginExRequest | Updates pieces of a login

            try
            {
                // Updates pieces of a login
                LogoutDefaultResponse result = apiInstance.UpdateLoginEx(updateLoginExRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LoginsApi.UpdateLoginEx: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateLoginExWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates pieces of a login
    ApiResponse<LogoutDefaultResponse> response = apiInstance.UpdateLoginExWithHttpInfo(updateLoginExRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LoginsApi.UpdateLoginExWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **updateLoginExRequest** | [**UpdateLoginExRequest**](UpdateLoginExRequest.md) | Updates pieces of a login |  |

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

