# Acme.App.MastercardApi.Client.Model.WalletProviderDecisioningInfo
Contains information about the decision recommended by the Wallet Provider. Max length - Not applicable. Type - Map (DecisioningInfo).

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**recommendedDecision** | **string** | The decision recommended by the Wallet Provider. Must be one of; APPROVED &#x3D; Services request was approved, DECLINED &#x3D; Services request was declined, REQUIRE_ADDITIONAL_AUTHENTICATION &#x3D; Services request requires additional authentication to be approved. | [optional] 
**recommendationStandardVersion** | **string** | The standards version used by the Wallet Provider to determine the recommended decision. | [optional] 
**deviceScore** | **string** | Score given to the device by the Wallet Provider. Value between 1 and 5. | [optional] 
**accountScore** | **string** | Score given to the account by the Wallet Provider. Value between 1 and 5. | [optional] 
**phoneNumberScore** | **string** | Score given to the phone number by the Wallet Provider. Value between 1 and 5. | [optional] 
**accountLifeTime** | **string** | The lifetime of the account with the Token Requestor. | [optional] 
**recommendationReasons** | **List&lt;string&gt;** | Reasons provided to the Wallet Provider on how the recommended decision was reached.  Please refer to \&quot;Reason Codes\&quot; tab for all eligible values. Max length - Not applicable. Type - Array [String]. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

