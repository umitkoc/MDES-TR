# Org.OpenAPITools.Model.PushMultipleAccountsRequestData

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**requestId** | **string** | Unique identifier for the request.  __Max Length:__ 64  | 
**pushFundingAccounts** | [**EncryptedPayloadForMultiplePush**](EncryptedPayloadForMultiplePush.md) |  | 
**tokenRequestorId** | **string** | Identifies the Token Requestor __Length:__ 11  | 
**signatureData** | [**PushAccountSignatureData**](PushAccountSignatureData.md) |  | [optional] 
**requestIssuerInitiatedDigitizationData** | **bool** | Boolean value to indicate to return Issuer Initiated Digitization Data or not. A default of false should be assumed if this parameter is not supplied. &lt;br&gt; Must be one of: * true: Issuer Initiated Digitization Data is requested in the response. * false: Issuer Initiated Digitization Data is not requested in the response.  | [optional] 
**pushAccountReceiptsValidityPeriod** | **decimal** | Push Account Receipt validity period for given request. Validity period in minutes. If an issuer is pushing more than one accounts then provided value will be applicable to all pushAccountReceipts.   &lt;ul&gt; &lt;li&gt;Default value 15 minutes&lt;/li&gt; &lt;li&gt; Value must be greater than 4 minutes &lt;/li&gt; &lt;li&gt; Value must be lesser or equal to 15 minutes  &lt;/li&gt; &lt;/ul&gt; __Min Length:__ 1 __Max Length:__ 2              | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

