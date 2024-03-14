# Alterian.AUTH.Api.PasswordsApi

All URIs are relative to *http://localhost/auth/api.svc/jsonsdk*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ChangePassword**](PasswordsApi.md#changepassword) | **POST** /ChangePassword | Changes a login&#39;s password |
| [**ExpirePassword**](PasswordsApi.md#expirepassword) | **POST** /ExpirePassword | Flags a login has having an expired password.  This forces the login to change their password upon their next attempt to log in. |
| [**GetPasswordComplexityRules**](PasswordsApi.md#getpasswordcomplexityrules) | **POST** /GetPasswordComplexityRules | Returns back the password complexity rules for use in a GUI.  These rules are also applied on the backend. |

<a id="changepassword"></a>
# **ChangePassword**
> LogoutDefaultResponse ChangePassword (ChangePasswordRequest changePasswordRequest)

Changes a login's password

Changes a login's password

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.AUTH.Api;
using Alterian.AUTH.Client;
using Alterian.AUTH.Model;

namespace Example
{
    public class ChangePasswordExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/auth/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new PasswordsApi(config);
            var changePasswordRequest = new ChangePasswordRequest(); // ChangePasswordRequest | Changes a login's password

            try
            {
                // Changes a login's password
                LogoutDefaultResponse result = apiInstance.ChangePassword(changePasswordRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PasswordsApi.ChangePassword: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ChangePasswordWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Changes a login's password
    ApiResponse<LogoutDefaultResponse> response = apiInstance.ChangePasswordWithHttpInfo(changePasswordRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PasswordsApi.ChangePasswordWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **changePasswordRequest** | [**ChangePasswordRequest**](ChangePasswordRequest.md) | Changes a login&#39;s password |  |

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

<a id="expirepassword"></a>
# **ExpirePassword**
> LogoutDefaultResponse ExpirePassword (ExpirePasswordRequest expirePasswordRequest)

Flags a login has having an expired password.  This forces the login to change their password upon their next attempt to log in.

Flags a login has having an expired password.  This forces the login to change their password upon their next attempt to log in.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.AUTH.Api;
using Alterian.AUTH.Client;
using Alterian.AUTH.Model;

namespace Example
{
    public class ExpirePasswordExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/auth/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new PasswordsApi(config);
            var expirePasswordRequest = new ExpirePasswordRequest(); // ExpirePasswordRequest | Flags a login has having an expired password.  This forces the login to change their password upon their next attempt to log in.

            try
            {
                // Flags a login has having an expired password.  This forces the login to change their password upon their next attempt to log in.
                LogoutDefaultResponse result = apiInstance.ExpirePassword(expirePasswordRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PasswordsApi.ExpirePassword: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ExpirePasswordWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Flags a login has having an expired password.  This forces the login to change their password upon their next attempt to log in.
    ApiResponse<LogoutDefaultResponse> response = apiInstance.ExpirePasswordWithHttpInfo(expirePasswordRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PasswordsApi.ExpirePasswordWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **expirePasswordRequest** | [**ExpirePasswordRequest**](ExpirePasswordRequest.md) | Flags a login has having an expired password.  This forces the login to change their password upon their next attempt to log in. |  |

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

<a id="getpasswordcomplexityrules"></a>
# **GetPasswordComplexityRules**
> GetPasswordComplexityRulesDefaultResponse GetPasswordComplexityRules ()

Returns back the password complexity rules for use in a GUI.  These rules are also applied on the backend.

Returns back the password complexity rules for use in a GUI.  These rules are also applied on the backend.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.AUTH.Api;
using Alterian.AUTH.Client;
using Alterian.AUTH.Model;

namespace Example
{
    public class GetPasswordComplexityRulesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/auth/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new PasswordsApi(config);

            try
            {
                // Returns back the password complexity rules for use in a GUI.  These rules are also applied on the backend.
                GetPasswordComplexityRulesDefaultResponse result = apiInstance.GetPasswordComplexityRules();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PasswordsApi.GetPasswordComplexityRules: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPasswordComplexityRulesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns back the password complexity rules for use in a GUI.  These rules are also applied on the backend.
    ApiResponse<GetPasswordComplexityRulesDefaultResponse> response = apiInstance.GetPasswordComplexityRulesWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PasswordsApi.GetPasswordComplexityRulesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**GetPasswordComplexityRulesDefaultResponse**](GetPasswordComplexityRulesDefaultResponse.md)

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

