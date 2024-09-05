# Acme.App.MastercardApi.Client.Model.WalletAtcStatus
The ATCs statuses are reported by the wallet. Conditional – required if EventName is REPLENISH

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**unusedDiscarded** | **List&lt;string&gt;** | The ATCs reported by the wallet that are unused discarded. Max length - Not applicable. Type - Array[String]. | [optional] 
**usedForContactless** | **List&lt;string&gt;** | The ATCs reported by the wallet that are used for contactless transaction. Max length - Not applicable. Type - Array[String]. | [optional] 
**usedForDsrp** | **List&lt;string&gt;** | The ATCs reported by the wallet that are used for DSRP transaction. Max length - Not applicable. Type - Array[String] | [optional] 
**unusedActive** | **List&lt;string&gt;** | The ATCs reported by the wallet that are unused active. Max length - Not applicable. Type - Array[String] | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

