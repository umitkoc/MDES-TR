# Org.OpenAPITools.Model.GetTaskStatusResults

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ResponseId** | **string** | Unique identifier for the response.  | [optional] 
**ResponseHost** | **string** | The host that originated the request. Future calls in the same conversation may be routed to this host.  | [optional] 
**Status** | **string** | The status of the specified task. Must be either &#39;PENDING&#39; (The Task has been recieved and is pending processing), &#39;IN_PROGRESS&#39; (The task is currently in progress), &#39;COMPLETED&#39; (The task was completed successfully) or &#39;FAILED&#39; The task was processed but failed to complete successfully.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

