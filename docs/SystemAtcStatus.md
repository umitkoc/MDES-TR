# Acme.App.MastercardApi.Client.Model.SystemAtcStatus
The ATCs statuses as reported by authorization network. Conditional – required if EventName is REPLENISH

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**atcNotFound** | **List&lt;string&gt;** | The ATCs reported by the authorization network as not found. Max length - Not applicable. Type - Array[String]. | [optional] 
**atcAlreadyProcessed** | **List&lt;string&gt;** | The ATCs reported by the authorization network as processed for a transaction. Max length - Not applicable. Type - Array[String]. | [optional] 
**atcReportedUsedByWallet** | **List&lt;string&gt;** | The ATCs prviously reported by the wallet as processed or discarded. Max length - Not applicable. Type - Array[String] | [optional] 
**unusedActive** | **List&lt;string&gt;** | The ATCs reported by the wallet that are unused active. Max length - Not applicable. Type - Array[String] | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

