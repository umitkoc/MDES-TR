# Org.OpenAPITools.Model.PushMultipleAccountsData

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**pushAccountId** | **string** | The identifier for the account that is being pushed.  Should be unique within a PushMultipleAccounts request.  __Max Length:__ 36   | 
**pushAccountReceipt** | **string** | Receipt value to be passed to the Token Requestor. The pushAccountReceipt represents the pushed account details and expires after 15 minutes. __Conditional.__ Required unless error is returned. __Max Length:__ 64 characters. When valid, the receipt will consist of a 3-character prefix identifying the product associated to the funding account concatenated with a universally unique identifier, in the form prefix-UUID. The prefix is needed by some Token Requestors in preparation of performing a tokenization. Prefix values are:  * MCC: Mastercard Credit  * DMC: Mastercard Debit  * MSI: Maestro  * PVL: Private Label  | [optional] 
**issuerInitiatedDigitizationData** | **string** | Base64Encoded String of fundingAccountInfo object that issuer can pass to Token Requestor propritary communication. __Conditional.__ Present if requestIssuerInitiatedDigitizationData value is true in the request. _Max_Length: 256K  | [optional] 
**errors** | [**List&lt;Error&gt;**](Error.md) | Element encapsulating a collection of errors that occurred during a single request. __Conditional.__ Required if one or more errors occurred while performing the operation. Not present if the operation was successful.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

