# Alterian.AUTH.Model.UpdateLoginExRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ExternalAuthentication** | **bool** | Should this login be exteral authenticated | [optional] 
**LoginId** | **Guid** | Id of the login | [optional] 
**Name** | **string** | Name of the login | [optional] 
**NewPassword** | **string** | If you want to reset the password, provide it here.  If ExternalAuth is true, this property is ignored. | [optional] 
**Settings** | [**List&lt;SettingValue&gt;**](SettingValue.md) | Settings to apply to the login | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

