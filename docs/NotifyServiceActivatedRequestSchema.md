# Acme.App.MastercardApi.Client.Model.NotifyServiceActivatedRequestSchema

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**requestId** | **string** | The id of the request submitted. Max length - 64 | 
**services** | **List&lt;string&gt;** | Array of services that are being requested for the account. Must be one of ; DIGITIZATION &#x3D; Provision the Funding Account to a device. Max length - Not applicable. Type - Array [String]. | 
**fundingAccountInfo** | [**FundingAccountInfoSchema2**](FundingAccountInfoSchema2.md) |  | 
**deviceInfo** | [**DeviceInfo**](DeviceInfo.md) |  | [optional] 
**correlationId** | **string** | Value linking pre-digitization messages generated during provisioning. | 
**tokenRequestorId** | **string** | The party that requested the digitization. Type - String (Numeric). | 
**walletId** | **string** | The identifier of the Wallet Provider who requested the digitization. Only present when the token is provided to a Wallet Provider. | [optional] 
**paymentAppInstanceId** | **string** | The identifier of the Payment App instance within a device that will be provisioned with a token. Only present when supplied by a Wallet Provider. Max length - 48. Type - String. | [optional] 
**tokenType** | **string** | The type of token requested for this digitization. Valid values are - EMBEDDED_SE &#x3D; Embedded Secure Element | CLOUD &#x3D; Mastercard Cloud-Based Payments | STATIC &#x3D; Static token. | 
**secureElementId** | **string** | The identifier of the Secure Element to be provisioned with the token. Present only when the token is provisioned to a Secure Element and when provided by the Wallet Provider. | [optional] 
**accountPanSuffix** | **string** | The last few digits (typically four) of the Account PAN being digitized. | 
**serviceRequestDateTime** | **string** | The date and time the service for the PAN was requested. Expressed in ISO 8601 extended format as one of the following - YYYY-MM-DDThh:mm:ss[ .sss ]Z, YYYY-MM-DDThh:mm:ss[ .sss ]±hh:mm . Where [ .sss ] is optional and can be 1 to 3 digits. | 
**termsAndConditionsAssetId** | **string** | The Terms and Conditions as presented to and accepted by the Account holder. | [optional] 
**termsAndConditionsAcceptedTimestamp** | **string** | The date and time the Terms and Conditions were accepted by the Account holder. Expressed in ISO 8601 extended format as one of the following - YYYY-MM-DDThh:mm:ss[ .sss ]Z, YYYY-MM-DDThh:mm:ss[ .sss ]±hh:mm . Where [ .sss ] is optional and can be 1 to 3 digits. | [optional] 
**productConfigurationId** | **string** | Freeform identifier for the product configuration as assigned by the Issuer. | [optional] 
**consumerLanguage** | **string** | Language preference selected by the consumer. Formatted as an ISO-639-1 two-letter language code. | [optional] 
**decision** | **string** | The authorization decision for the service request. Must be one of - APPROVED &#x3D; Service request was approved, REQUIRE_ADDITIONAL_AUTHENTICATION &#x3D; Service request requires additional authentication to be approved. One or more Activation Methods will be provided. | 
**decisionMadeBy** | **string** | The process that determined the final authorization decision for the request. Must be one of - * ELIGIBILITY_REQUEST &#x3D; The decision was made by the eligibility request to the Issuer * AUTHORIZATION_REQUEST &#x3D; The decision was made by the authorization request to the Issuer * RULES &#x3D; The decision was made by the rule engine. | [optional] 
**tokenActivatedDateTime** | **string** | Expressed in ISO 8601 extended format as one of the following - YYYY-MM-DDThh:mm:ss[ .sss ]Z, YYYY-MM-DDThh:mm:ss[ .sss ]±hh:mm, Where [ .sss ] is optional and can be 1 to 3 digits. | 
**numberOfActivationAttempts** | **int** | The number of times an Activation Code was received to activate the token. Max length - 1. Type - Number. | [optional] 
**numberOfActiveTokens** | **int** | The number of active tokens for the Funding Account. Valid values are 0 to 99. A value of 99 means there are 99 or more active tokens. Tokens that have been deleted from the wallet are excluded from the count. | [optional] 
**tokenAssuranceLevel** | **int** | The assurance level assigned to the token. Type - Number. | [optional] 
**consumerFacingEntityName** | **string** | Entity name that account holder recognizes as being where they store their PAN (wallets, merchants, commerce platforms…). | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

