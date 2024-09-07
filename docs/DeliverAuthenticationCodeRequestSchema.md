# Org.OpenAPITools.Model.DeliverAuthenticationCodeRequestSchema

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**requestId** | **string** | Unique identifier for the request message.&lt;br&gt;   __Max length - 64__ | 
**authenticationFlowId** | **string** | A unique id to identify the flow to authenticate an account holder. Value linking messages for a single authentication request.&lt;br&gt;  __Max length - 128__ | 
**authenticationCode** | **string** | The code to be distributed for the authentication.&lt;br&gt;  __Max length - 32__ | 
**expirationDateTime** | **string** | The date and time when the authentication code is no longer valid. Expressed in ISO 8601 extended format. Must be either * YYYY-MM-DDThh:mm:ss[.sss]Z * YYYY-MM-DDThh:mm:ss[.sss]±hh:mm where [.sss] is optional and can be 1 to 3 digits.&lt;br&gt;  __Max length - 29__  | 
**reasonCode** | **string** | The reason the account holder is being authenticated. The reason could impact the generation and validation of the code in a number of ways including but not limited to the time period of validity of the code and the number of attempts allowed to validate the code. New reason codes can be added at any time, and this should not result in a failure. Must be either   * &#39;PAYMENT_TRANSACTION&#39; (Account holder being authenticated in order to perform a payment transaction)  * &#39;OTHER&#39; (Account holder being authenticated for a reason not enumerated in this list) &lt;br&gt;  __Max length - 64__  | 
**fundingAccountInfo** | [**FundingAccountInfoSchema1**](FundingAccountInfoSchema1.md) |  | 
**tokenRequestorId** | **string** | The party that requested the digitization. &lt;br&gt; __Max length - 11(Exact)__ | 
**walletId** | **string** | The identifier of the Wallet Provider who requested the digitization. &lt;br&gt; __Max length - 3__ | [optional] 
**paymentAppInstanceId** | **string** | The identifier of the Payment App instance within a device that will be provisioned with a token. Only present when supplied by a Wallet Provider. &lt;br&gt; __Max length - 64__ | [optional] 
**paymentAppName** | **string** | Identifier for the Payment App, unique per app as assigned by Mastercard for this Payment App. &lt;br&gt; __Max length - 64__ | [optional] 
**consumerFacingEntityName** | **string** | The name of the token requestor to be displayed to the account holder. &lt;br&gt; __Max length - 100__ | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

