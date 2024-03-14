# Alterian.AUTH.Model.LoginInfo
Info for a particular login

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ID** | **Guid** | Id of the login | [optional] 
**Name** | **string** | The login name | [optional] 
**WindowsAuthentication** | **bool** | Does this login use external authentication? | [optional] 
**Settings** | [**List&lt;SettingValue&gt;**](SettingValue.md) | Settings for this login | [optional] 
**NewPassword** | **string** | If you want to update the password for a login, include a NewPassword.  You can use this in a call to @see(UpdateLogin) | [optional] 
**Enabled** | **bool** | Is this login flagged as disabled | [optional] 
**PasswordExpires** | **DateTime?** | If set, this is when the password for this login will expire.  Any changes to this will be compared to the password policy | [optional] 
**LastLogin** | **DateTime?** | Last time this login was used | [optional] 
**Created** | **DateTime** | When was this login created | [optional] 
**Modified** | **DateTime** | Last time this login was modified | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

