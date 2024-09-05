# Acme.App.MastercardApi.Client.Model.RequestActivationMethodsRequestSchema

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**requestId** | **string** | The id of the request submitted. Max length - 64 | 
**services** | **List&lt;string&gt;** | Array of services that are being requested for the account. Must be one of ; DIGITIZATION &#x3D; Provision the Funding Account to a device. Max length - Not applicable. Type - Array[String]. | 
**fundingAccountInfo** | [**FundingAccountInfoSchema1**](FundingAccountInfoSchema1.md) |  | 
**correlationId** | **string** | Value linking pre-digitization messages generated during provisioning. | 
**tokenRequestorId** | **string** | The party that requested the digitization. Type - String (Numeric). Conditional - Required if tokens are assigned by MDES. | [optional] 
**walletId** | **string** | The identifier of the Wallet Provider who requested the digitization. Only present when the token is provided to a Wallet Provider. | [optional] 
**paymentAppInstanceId** | **string** | The identifier of the payment App instance within a device that will be provisioned with a token. Only present when supplied by a Wallet Provider. | [optional] 
**accountIdHash** | **string** | SHA-256 hash of the Account holder&#39;s account ID with the Payment App Provider. Typically expected to be an email address. Type - String (Alpha-Numeric) Hex-encoded data (case-insensitive). | [optional] 
**mobileNumberSuffix** | **string** | The last few digits (typically four) of the device&#39;s mobile phone number. | [optional] 
**tokenType** | **string** | The type of token requested for this digitization. Valid values are EMBEDDED_SE &#x3D; Embedded Secure Element | CLOUD &#x3D; Mastercard Cloud-Based Payments | STATIC &#x3D; Static token. | 
**reasonCodes** | **List&lt;string&gt;** | The reason the account holder is being authenticated. New reason codes can be added at any time and should not result in a failure. Possible push methods are:   * ADD_CARD:  The account holder is being authenticated in order to verify account ownership at the time of adding a card in token requestor system (Token might be in active state)   * VERIFY_ACCOUNT:  The account holder is being authenticated in order to verify account ownership to use a service   * OTHER:  The account holder is being authenticated for a reason not enumerated in this list. Conditional - Only present for Conset Service  | [optional] 
**consumerFacingEntityName** | **string** | Entity name that account holder recognizes as being where they store their PAN (wallets, merchants, commerce platforms…). | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

