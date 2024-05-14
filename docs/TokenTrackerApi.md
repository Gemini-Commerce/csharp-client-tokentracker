# tokentracker.Api.TokenTrackerApi

All URIs are relative to *https://token-tracker.api.gogemini.io*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**TokenTrackerAdjustTokenBalance**](TokenTrackerApi.md#tokentrackeradjusttokenbalance) | **POST** /v1/{tenantId}/adjust_token_balance | AdjustTokenBalance |
| [**TokenTrackerGetTokenBalance**](TokenTrackerApi.md#tokentrackergettokenbalance) | **POST** /v1/{tenantId}/get_token_balance | GetTokenBalance |
| [**TokenTrackerStripeWebhook**](TokenTrackerApi.md#tokentrackerstripewebhook) | **POST** /v1/stripe/webhook | StripeWebhook |

<a id="tokentrackeradjusttokenbalance"></a>
# **TokenTrackerAdjustTokenBalance**
> TokentrackerAdjustTokenBalanceResponse TokenTrackerAdjustTokenBalance (string tenantId, TokenTrackerAdjustTokenBalanceRequest body)

AdjustTokenBalance

Adjust token balance

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using tokentracker.Api;
using tokentracker.Client;
using tokentracker.Model;

namespace Example
{
    public class TokenTrackerAdjustTokenBalanceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://token-tracker.api.gogemini.io";
            // Configure OAuth2 access token for authorization: standardAuthorization
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TokenTrackerApi(config);
            var tenantId = "tenantId_example";  // string | 
            var body = new TokenTrackerAdjustTokenBalanceRequest(); // TokenTrackerAdjustTokenBalanceRequest | 

            try
            {
                // AdjustTokenBalance
                TokentrackerAdjustTokenBalanceResponse result = apiInstance.TokenTrackerAdjustTokenBalance(tenantId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TokenTrackerApi.TokenTrackerAdjustTokenBalance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TokenTrackerAdjustTokenBalanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // AdjustTokenBalance
    ApiResponse<TokentrackerAdjustTokenBalanceResponse> response = apiInstance.TokenTrackerAdjustTokenBalanceWithHttpInfo(tenantId, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TokenTrackerApi.TokenTrackerAdjustTokenBalanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tenantId** | **string** |  |  |
| **body** | [**TokenTrackerAdjustTokenBalanceRequest**](TokenTrackerAdjustTokenBalanceRequest.md) |  |  |

### Return type

[**TokentrackerAdjustTokenBalanceResponse**](TokentrackerAdjustTokenBalanceResponse.md)

### Authorization

[standardAuthorization](../README.md#standardAuthorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="tokentrackergettokenbalance"></a>
# **TokenTrackerGetTokenBalance**
> TokentrackerGetTokenBalanceResponse TokenTrackerGetTokenBalance (string tenantId, Object body)

GetTokenBalance

Get token balance

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using tokentracker.Api;
using tokentracker.Client;
using tokentracker.Model;

namespace Example
{
    public class TokenTrackerGetTokenBalanceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://token-tracker.api.gogemini.io";
            // Configure OAuth2 access token for authorization: standardAuthorization
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TokenTrackerApi(config);
            var tenantId = "tenantId_example";  // string | 
            var body = null;  // Object | 

            try
            {
                // GetTokenBalance
                TokentrackerGetTokenBalanceResponse result = apiInstance.TokenTrackerGetTokenBalance(tenantId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TokenTrackerApi.TokenTrackerGetTokenBalance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TokenTrackerGetTokenBalanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GetTokenBalance
    ApiResponse<TokentrackerGetTokenBalanceResponse> response = apiInstance.TokenTrackerGetTokenBalanceWithHttpInfo(tenantId, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TokenTrackerApi.TokenTrackerGetTokenBalanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tenantId** | **string** |  |  |
| **body** | **Object** |  |  |

### Return type

[**TokentrackerGetTokenBalanceResponse**](TokentrackerGetTokenBalanceResponse.md)

### Authorization

[standardAuthorization](../README.md#standardAuthorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="tokentrackerstripewebhook"></a>
# **TokenTrackerStripeWebhook**
> Object TokenTrackerStripeWebhook (TokentrackerStripeWebhookRequest body)

StripeWebhook

Stripe webhook

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using tokentracker.Api;
using tokentracker.Client;
using tokentracker.Model;

namespace Example
{
    public class TokenTrackerStripeWebhookExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://token-tracker.api.gogemini.io";
            // Configure OAuth2 access token for authorization: standardAuthorization
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TokenTrackerApi(config);
            var body = new TokentrackerStripeWebhookRequest(); // TokentrackerStripeWebhookRequest | 

            try
            {
                // StripeWebhook
                Object result = apiInstance.TokenTrackerStripeWebhook(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TokenTrackerApi.TokenTrackerStripeWebhook: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TokenTrackerStripeWebhookWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // StripeWebhook
    ApiResponse<Object> response = apiInstance.TokenTrackerStripeWebhookWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TokenTrackerApi.TokenTrackerStripeWebhookWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**TokentrackerStripeWebhookRequest**](TokentrackerStripeWebhookRequest.md) |  |  |

### Return type

**Object**

### Authorization

[standardAuthorization](../README.md#standardAuthorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

