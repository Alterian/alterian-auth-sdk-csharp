# Alterian.AUTH.Api.AuthenticationApi

All URIs are relative to *http://localhost/auth/api.svc/jsonsdk*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApplicationLogin**](AuthenticationApi.md#applicationlogin) | **POST** /ApplicationLogin | this method requests the auth server give you a token for a particular \&quot;application\&quot; |
| [**FormsAuthentication**](AuthenticationApi.md#formsauthentication) | **POST** /FormsAuthentication | Provide a username and SHA1 encoded password to log into the system.  It is always recommended that this method be called via a secured method.              Should be followed by a call to @see(ApplicationLogin) |
| [**GetIdentityUrl**](AuthenticationApi.md#getidentityurl) | **POST** /GetIdentityUrl |  |
| [**GetSiteDetails**](AuthenticationApi.md#getsitedetails) | **POST** /GetSiteDetails | Returns the details for a particular application.  This is the same information as returned when you call @see(ApplicationLogin) but you will not receive an access token from this method. |
| [**Logout**](AuthenticationApi.md#logout) | **POST** /Logout | Logs the requested token out of the authentication system and out of any application for which a call has been made to @see(ApplicationLogin) |
| [**NTLMAuthentication**](AuthenticationApi.md#ntlmauthentication) | **POST** /NTLMAuthentication | If you have configured NTLM authentication properly, you can use this to get an authentication token.  Please note you must have configured IIS and everything correctly for this method to function. |
| [**OpenIdAuthentication**](AuthenticationApi.md#openidauthentication) | **GET** /OpenIdAuthentication | Use an Open Id Connect token to connect.  Your system must be configured to allow this; please review the documentation. |
| [**SAMLAuthentication**](AuthenticationApi.md#samlauthentication) | **POST** /SAMLAuthentication | Provided a valid SAML [Base64 encoded] token, this will return back an auth server token and application information. |

<a id="applicationlogin"></a>
# **ApplicationLogin**
> ApplicationLoginDefaultResponse ApplicationLogin (ApplicationLoginRequest applicationLoginRequest)

this method requests the auth server give you a token for a particular \"application\"

this method requests the auth server give you a token for a particular \"application\"

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.AUTH.Api;
using Alterian.AUTH.Client;
using Alterian.AUTH.Model;

namespace Example
{
    public class ApplicationLoginExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/auth/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new AuthenticationApi(config);
            var applicationLoginRequest = new ApplicationLoginRequest(); // ApplicationLoginRequest | this method requests the auth server give you a token for a particular \"application\"

            try
            {
                // this method requests the auth server give you a token for a particular \"application\"
                ApplicationLoginDefaultResponse result = apiInstance.ApplicationLogin(applicationLoginRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthenticationApi.ApplicationLogin: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApplicationLoginWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // this method requests the auth server give you a token for a particular \"application\"
    ApiResponse<ApplicationLoginDefaultResponse> response = apiInstance.ApplicationLoginWithHttpInfo(applicationLoginRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthenticationApi.ApplicationLoginWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **applicationLoginRequest** | [**ApplicationLoginRequest**](ApplicationLoginRequest.md) | this method requests the auth server give you a token for a particular \&quot;application\&quot; |  |

### Return type

[**ApplicationLoginDefaultResponse**](ApplicationLoginDefaultResponse.md)

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

<a id="formsauthentication"></a>
# **FormsAuthentication**
> FormsAuthenticationDefaultResponse FormsAuthentication (FormsAuthenticationRequest formsAuthenticationRequest)

Provide a username and SHA1 encoded password to log into the system.  It is always recommended that this method be called via a secured method.              Should be followed by a call to @see(ApplicationLogin)

Provide a username and SHA1 encoded password to log into the system.  It is always recommended that this method be called via a secured method.              Should be followed by a call to @see(ApplicationLogin)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.AUTH.Api;
using Alterian.AUTH.Client;
using Alterian.AUTH.Model;

namespace Example
{
    public class FormsAuthenticationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/auth/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new AuthenticationApi(config);
            var formsAuthenticationRequest = new FormsAuthenticationRequest(); // FormsAuthenticationRequest | Provide a username and SHA1 encoded password to log into the system.  It is always recommended that this method be called via a secured method.              Should be followed by a call to @see(ApplicationLogin)

            try
            {
                // Provide a username and SHA1 encoded password to log into the system.  It is always recommended that this method be called via a secured method.              Should be followed by a call to @see(ApplicationLogin)
                FormsAuthenticationDefaultResponse result = apiInstance.FormsAuthentication(formsAuthenticationRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthenticationApi.FormsAuthentication: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FormsAuthenticationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Provide a username and SHA1 encoded password to log into the system.  It is always recommended that this method be called via a secured method.              Should be followed by a call to @see(ApplicationLogin)
    ApiResponse<FormsAuthenticationDefaultResponse> response = apiInstance.FormsAuthenticationWithHttpInfo(formsAuthenticationRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthenticationApi.FormsAuthenticationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **formsAuthenticationRequest** | [**FormsAuthenticationRequest**](FormsAuthenticationRequest.md) | Provide a username and SHA1 encoded password to log into the system.  It is always recommended that this method be called via a secured method.              Should be followed by a call to @see(ApplicationLogin) |  |

### Return type

[**FormsAuthenticationDefaultResponse**](FormsAuthenticationDefaultResponse.md)

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

<a id="getidentityurl"></a>
# **GetIdentityUrl**
> GetIdentityUrlDefaultResponse GetIdentityUrl (GetIdentityUrlRequest getIdentityUrlRequest)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.AUTH.Api;
using Alterian.AUTH.Client;
using Alterian.AUTH.Model;

namespace Example
{
    public class GetIdentityUrlExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/auth/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new AuthenticationApi(config);
            var getIdentityUrlRequest = new GetIdentityUrlRequest(); // GetIdentityUrlRequest | 

            try
            {
                GetIdentityUrlDefaultResponse result = apiInstance.GetIdentityUrl(getIdentityUrlRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthenticationApi.GetIdentityUrl: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetIdentityUrlWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GetIdentityUrlDefaultResponse> response = apiInstance.GetIdentityUrlWithHttpInfo(getIdentityUrlRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthenticationApi.GetIdentityUrlWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getIdentityUrlRequest** | [**GetIdentityUrlRequest**](GetIdentityUrlRequest.md) |  |  |

### Return type

[**GetIdentityUrlDefaultResponse**](GetIdentityUrlDefaultResponse.md)

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

<a id="getsitedetails"></a>
# **GetSiteDetails**
> ApplicationLoginDefaultResponse GetSiteDetails (GetSiteDetailsRequest getSiteDetailsRequest)

Returns the details for a particular application.  This is the same information as returned when you call @see(ApplicationLogin) but you will not receive an access token from this method.

Returns the details for a particular application.  This is the same information as returned when you call @see(ApplicationLogin) but you will not receive an access token from this method.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.AUTH.Api;
using Alterian.AUTH.Client;
using Alterian.AUTH.Model;

namespace Example
{
    public class GetSiteDetailsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/auth/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new AuthenticationApi(config);
            var getSiteDetailsRequest = new GetSiteDetailsRequest(); // GetSiteDetailsRequest | Returns the details for a particular application.  This is the same information as returned when you call @see(ApplicationLogin) but you will not receive an access token from this method.

            try
            {
                // Returns the details for a particular application.  This is the same information as returned when you call @see(ApplicationLogin) but you will not receive an access token from this method.
                ApplicationLoginDefaultResponse result = apiInstance.GetSiteDetails(getSiteDetailsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthenticationApi.GetSiteDetails: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSiteDetailsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns the details for a particular application.  This is the same information as returned when you call @see(ApplicationLogin) but you will not receive an access token from this method.
    ApiResponse<ApplicationLoginDefaultResponse> response = apiInstance.GetSiteDetailsWithHttpInfo(getSiteDetailsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthenticationApi.GetSiteDetailsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getSiteDetailsRequest** | [**GetSiteDetailsRequest**](GetSiteDetailsRequest.md) | Returns the details for a particular application.  This is the same information as returned when you call @see(ApplicationLogin) but you will not receive an access token from this method. |  |

### Return type

[**ApplicationLoginDefaultResponse**](ApplicationLoginDefaultResponse.md)

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

<a id="logout"></a>
# **Logout**
> LogoutDefaultResponse Logout ()

Logs the requested token out of the authentication system and out of any application for which a call has been made to @see(ApplicationLogin)

Logs the requested token out of the authentication system and out of any application for which a call has been made to @see(ApplicationLogin)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.AUTH.Api;
using Alterian.AUTH.Client;
using Alterian.AUTH.Model;

namespace Example
{
    public class LogoutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/auth/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new AuthenticationApi(config);

            try
            {
                // Logs the requested token out of the authentication system and out of any application for which a call has been made to @see(ApplicationLogin)
                LogoutDefaultResponse result = apiInstance.Logout();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthenticationApi.Logout: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LogoutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Logs the requested token out of the authentication system and out of any application for which a call has been made to @see(ApplicationLogin)
    ApiResponse<LogoutDefaultResponse> response = apiInstance.LogoutWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthenticationApi.LogoutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**LogoutDefaultResponse**](LogoutDefaultResponse.md)

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

<a id="ntlmauthentication"></a>
# **NTLMAuthentication**
> FormsAuthenticationDefaultResponse NTLMAuthentication ()

If you have configured NTLM authentication properly, you can use this to get an authentication token.  Please note you must have configured IIS and everything correctly for this method to function.

If you have configured NTLM authentication properly, you can use this to get an authentication token.  Please note you must have configured IIS and everything correctly for this method to function.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.AUTH.Api;
using Alterian.AUTH.Client;
using Alterian.AUTH.Model;

namespace Example
{
    public class NTLMAuthenticationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/auth/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new AuthenticationApi(config);

            try
            {
                // If you have configured NTLM authentication properly, you can use this to get an authentication token.  Please note you must have configured IIS and everything correctly for this method to function.
                FormsAuthenticationDefaultResponse result = apiInstance.NTLMAuthentication();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthenticationApi.NTLMAuthentication: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NTLMAuthenticationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // If you have configured NTLM authentication properly, you can use this to get an authentication token.  Please note you must have configured IIS and everything correctly for this method to function.
    ApiResponse<FormsAuthenticationDefaultResponse> response = apiInstance.NTLMAuthenticationWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthenticationApi.NTLMAuthenticationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**FormsAuthenticationDefaultResponse**](FormsAuthenticationDefaultResponse.md)

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

<a id="openidauthentication"></a>
# **OpenIdAuthentication**
> Object OpenIdAuthentication (string? code = null, string? state = null)

Use an Open Id Connect token to connect.  Your system must be configured to allow this; please review the documentation.

Use an Open Id Connect token to connect.  Your system must be configured to allow this; please review the documentation.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.AUTH.Api;
using Alterian.AUTH.Client;
using Alterian.AUTH.Model;

namespace Example
{
    public class OpenIdAuthenticationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/auth/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new AuthenticationApi(config);
            var code = "code_example";  // string? |  (optional) 
            var state = "state_example";  // string? |  (optional) 

            try
            {
                // Use an Open Id Connect token to connect.  Your system must be configured to allow this; please review the documentation.
                Object result = apiInstance.OpenIdAuthentication(code, state);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthenticationApi.OpenIdAuthentication: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OpenIdAuthenticationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Use an Open Id Connect token to connect.  Your system must be configured to allow this; please review the documentation.
    ApiResponse<Object> response = apiInstance.OpenIdAuthenticationWithHttpInfo(code, state);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthenticationApi.OpenIdAuthenticationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **code** | **string?** |  | [optional]  |
| **state** | **string?** |  | [optional]  |

### Return type

**Object**

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

<a id="samlauthentication"></a>
# **SAMLAuthentication**
> FormsAuthenticationDefaultResponse SAMLAuthentication (SAMLAuthenticationRequest sAMLAuthenticationRequest)

Provided a valid SAML [Base64 encoded] token, this will return back an auth server token and application information.

Provided a valid SAML [Base64 encoded] token, this will return back an auth server token and application information.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Alterian.AUTH.Api;
using Alterian.AUTH.Client;
using Alterian.AUTH.Model;

namespace Example
{
    public class SAMLAuthenticationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/auth/api.svc/jsonsdk";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new AuthenticationApi(config);
            var sAMLAuthenticationRequest = new SAMLAuthenticationRequest(); // SAMLAuthenticationRequest | Provided a valid SAML [Base64 encoded] token, this will return back an auth server token and application information.

            try
            {
                // Provided a valid SAML [Base64 encoded] token, this will return back an auth server token and application information.
                FormsAuthenticationDefaultResponse result = apiInstance.SAMLAuthentication(sAMLAuthenticationRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthenticationApi.SAMLAuthentication: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SAMLAuthenticationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Provided a valid SAML [Base64 encoded] token, this will return back an auth server token and application information.
    ApiResponse<FormsAuthenticationDefaultResponse> response = apiInstance.SAMLAuthenticationWithHttpInfo(sAMLAuthenticationRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthenticationApi.SAMLAuthenticationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sAMLAuthenticationRequest** | [**SAMLAuthenticationRequest**](SAMLAuthenticationRequest.md) | Provided a valid SAML [Base64 encoded] token, this will return back an auth server token and application information. |  |

### Return type

[**FormsAuthenticationDefaultResponse**](FormsAuthenticationDefaultResponse.md)

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

