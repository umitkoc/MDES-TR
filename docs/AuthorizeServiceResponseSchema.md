# Acme.App.MastercardApi.Client.Model.AuthorizeServiceResponseSchema

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**responseId** | **string** | The Id of the response returned. | 
**services** | **List&lt;string&gt;** | Array of services for the account that the authorization decision applies to. Must be a subset of the services in the request object. Services that are not approved for the account will be omitted. Possible values are; DIGITIZATION &#x3D; Provision the Funding Account to a device. Max length - Not applicable.  Type - Array[String]. Required. | [optional] 
**decision** | **string** | The authorization decision for the authorization of the requested services. Must be one of ; APPROVED &#x3D; Services request was approved, DECLINED &#x3D; Services request was declined, REQUIRE_ADDITIONAL_AUTHENTICATION &#x3D; Services request requires additional authentication to be approved. One or more ActivationMethods may be provided. | [optional] 
**activationMethods** | [**List&lt;ActivationMethod&gt;**](ActivationMethod.md) | The activation methods to be used for this digitization. Return empty array if no methods are to be returned. Max length - Not applicable. Type - Array [ActivationMethod]. Optional. | [optional] 
**panSequenceNumber** | **string** | The pan sequence number for the card. Acceptable values are in the range 000-099. | [optional] 
**issuerProductConfigId** | **string** | The unique Issuer identifier assigned to the product configuration in BPMS. It is provided for the Digitization service only. | [optional] 
**encryptedPayload** | [**EncryptedPayloadOut**](EncryptedPayloadOut.md) |  | [optional] 
**cvcResponse** | **string** | The result of the CVC2 validation performed against the value provided by the Account holder. Must be one of ; MATCH &#x3D; Valid CVC2, INVALID &#x3D; Invalid CVC2, NOT_PROCESSED &#x3D; CVC2 was not processed (issuer temporarily unavailable). | [optional] 
**avsResponse** | **string** | The result of the address validation performed against the values provided by the Account holder. Must be one of ; POSTAL_DOES_NOT_MATCH &#x3D; Address matches, postal code does not, ADDRESS_AND_POSTAL_DO_NOT_MATCH &#x3D; Neither address nor postal code matches, RETRY &#x3D; Retry, system unable to process, AVS_NOT_SUPPORTED &#x3D; AVS currently not supported, NO_DATA &#x3D; No data from issuer/Authorization Platform, ADDRESS_DOES_NOT_MATCH &#x3D; W - For U.S. addresses, nine-digit postal code matches, address does not; for address outside the U.S., postal code matches, address does not, ADDRESS_AND_POSTAL_MATCH &#x3D; X - For U.S. addresses, nine-digit postal code and address matches; for addresses outside the U.S., postal code and address match; US5_ADDRESS_AND_POSTAL_MATCH &#x3D; Y - For U.S. addresses, five-digit postal code and address matches, US5_ ADDRESS_DOES_NOT_MATCH &#x3D; Z - For U.S. addresses, five-digit postal code matches, address does not. | [optional] 
**tokenRequestorId** | **string** | The party that requested the digitization. Type - String (Numeric). Conditional - Required if tokens are assigned by external provider, not present otherwise. | [optional] 
**tcis** | **List&lt;string&gt;** | Terminal Capability Identifier. This parameter is defined as an array of strings designating the primary city or cities where the transit solution will operate. Max length - Not applicable. Type - Array [String]. Optional. | [optional] 
**auxTcis** | **List&lt;string&gt;** | auxiliary Terminal Capability Identifier. This parameter is defined as an array of strings designating an additional city or cities where the transit solution will operate. Max length - Not applicable. Type - Array [String]. Optional. | [optional] 
**chipDataValidationResponse** | **string** | The Issuer validated chipData validation result code. Must present if issuer is validating chip data. Must be one of ; VALID &#x3D; Chip data provided is valid, INVALID &#x3D; Chip data provided is not valid, NOT_PROCESSED &#x3D; Unable to process Chip data validation (issuer temporarily unavailable). | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

