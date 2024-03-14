# Alterian.AUTH.Model.Setting

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ID** | **int** | Id of the setting | [optional] 
**Name** | **string** | Name of the setting, must be unique | [optional] 
**AppliesTo** | **SettingAppliesTo** |  | [optional] 
**IsSystem** | **bool** | Is this a system setting?  if so, any attempts to modify it will result in an AccessDenied error.  You can create a setting with IsSystem but, once created, you will not be able to change it [or delete it] | [optional] 
**Value** | **string** | This is only filled in with a call to @see(GetSettingsValues).  It is ignored when creating settings | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

