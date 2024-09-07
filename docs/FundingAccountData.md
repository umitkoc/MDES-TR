# Org.OpenAPITools.Model.FundingAccountData

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CardAccountData** | [**CardAccountDataInbound**](CardAccountDataInbound.md) |  | [optional] 
**AccountHolderData** | [**AccountHolderData**](AccountHolderData.md) |  | [optional] 
**Source** | **string** | (**Required as minimum for Tokenization**) The source of the account. Must be one of   * ACCOUNT_ON_FILE   * ACCOUNT_ADDED_MANUALLY   * ACCOUNT_ADDED_VIA_APPLICATION   * EXISTING_TOKEN_CREDENTIAL&lt;br&gt;     - **NOTE** :Only applicable for certain cross-program enrollment use-cases of [Mastercard Checkout Solutions](https://developer.mastercard.com/mastercard-checkout-solutions/documentation/use-cases/card-on-file/). Please refer to relevant documentation for more info.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

