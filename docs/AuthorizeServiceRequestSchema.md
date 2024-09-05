# Acme.App.MastercardApi.Client.Model.AuthorizeServiceRequestSchema

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**requestId** | **string** | The id of the request submitted. Max length - 64 | 
**services** | **List&lt;string&gt;** | Array of services that are being requested for the account. Must be one of ; DIGITIZATION &#x3D; Provision the Funding Account to a device. Max length - not applicable. Type - Array[String]. | 
**fundingAccountInfo** | [**FundingAccountInfoSchema1**](FundingAccountInfoSchema1.md) |  | 
**correlationId** | **string** | Value linking pre-digitization messages generated during provisioning. | 
**tokenRequestorId** | **string** | The party that requested the digitization. Type - String (Numeric). Conditional - Required if tokens are assigned by MDES. | [optional] 
**walletId** | **string** | The identifier of the Wallet Provider who requested the digitization. Only present when the token is provided to a Wallet Provider. | [optional] 
**paymentAppInstanceId** | **string** | The identifier of the Payment App instance within a device that will be provisioned with a token. Only present when supplied by a Wallet Provider. | [optional] 
**accountIdHash** | **string** | SHA-256 hash of the Account holder&#39;s account ID with the Payment App Provider. Typically expected to be an email address. Type - string (Alpha Numeric) Hex-encoded data (case-insensitive). | [optional] 
**mobileNumberSuffix** | **string** | The last few digits (typically four) of the device&#39;s mobile phone number. | [optional] 
**activeTokenCount** | **string** | The number of active tokens that already exist for the Funding Account based on the token type. Secure Element and Cloud tokens are counted together. Valid values are 0 to 99. A value of 99 means there are 99 or more active tokens. Tokens that have been deleted from the wallet are excluded from the count. Max length - 2. Type - String (Numeric). | [optional] 
**deviceInfo** | [**DeviceInfo**](DeviceInfo.md) |  | [optional] 
**walletProviderDecisioningInfo** | [**WalletProviderDecisioningInfo**](WalletProviderDecisioningInfo.md) |  | [optional] 
**tokenType** | **string** | The type of token requested for this digitization. Valid values are EMBEDDED_SE &#x3D; Embedded Secure Element | CLOUD &#x3D; Mastercard Cloud-Based Payments | STATIC &#x3D; Static token. | 
**consumerFacingEntityName** | **string** | Entity name that account holder recognizes as being where they store their PAN (wallets, merchants, commerce platforms…). | [optional] 
**chipDataValidationResult** | [**ChipDataValidationResult**](ChipDataValidationResult.md) |  | [optional] 
**panSequenceNumber** | **string** | The pan sequence number for the card.  Acceptable values are in the range 000 – 099. present only if chipdata is present in the encryption paylod. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

