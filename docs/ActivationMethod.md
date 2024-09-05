# Acme.App.MastercardApi.Client.Model.ActivationMethod
The activation methods to be used for this digitization.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**type** | **string** | Specifies the activation method type.   Must be one of    * TEXT_TO_CARDHOLDER_NUMBER &#x3D; Text message to Account holder&#39;s mobile phone number. Value will be the Account holder&#39;s masked mobile phone number   * EMAIL_TO_CARDHOLDER_ADDRESS &#x3D; Email to Account holder&#39;s email address. Value will be the Account holder&#39;s masked email address   * CARDHOLDER_TO_CALL_AUTOMATED_NUMBER &#x3D; Account holder-initiated call to automated call center phone number. Value will be the phone number for the Account holder to call    * CARDHOLDER_TO_CALL_MANNED_NUMBER &#x3D; Account holder-initiated call to manned call center phone number. Value will be the phone number for the Account holder to call   * CARDHOLDER_TO_VISIT_WEBSITE &#x3D;  Account holder to visit a website. Value will be the website URL   * CARDHOLDER_TO_USE_MOBILE_APP &#x3D; Account holder to use a specific mobile app to activate token. Value will be replaced by a formatted string   * ISSUER_TO_CALL_CARDHOLDER_NUMBER &#x3D; Issuer-initiated voice call to Account holder&#39;s phone. Value will be the Account holder&#39;s masked voice call phone number.   | 
**value** | **string** | Specifies the activation method value (meaning varies depending on the activation method type). | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

