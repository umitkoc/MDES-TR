# Org.OpenAPITools.Model.PushAccountSignatureData

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**callbackURL** | **string** | The URL encoded URL for the token requestor to use to pass control back to the Issuer.   This needs to be an absolute URL containing the scheme.   Both iOS and Android support custom schemes that allow the browser to open an application. __Max Length:__ 256         | [optional] 
**completeIssuerAppActivation** | **bool** | This is a Boolean value used to indicate the behavior of the token requestor if a provisioning request receives a decision of REQUIRE_ADDITIONAL_AUTHENTICATION and the cardholder chooses the CARDHOLDER_TO_USE_ISSUER_MOBILE_APP Authentication Method from the list of supplied methods.  A default of  should be assumed if this parameter is not supplied. This field should not be case sensitive. &lt;Add Table&gt;  | [optional] 
**completeWebsiteActivation** | **bool** | This is a Boolean value used to indicate the behavior of the token requestor if a provisioning request receives a decision of REQUIRE_ADDITIONAL_AUTHENTICATION and the cardholder chooses the CARDHOLDER_TO_VISIT_WEBSITE Authentication Method from the list of supplied methods.  A default of true should be assumed if this parameter is not supplied. This field should not be case sensitive &lt;Add Table&gt;  | [optional] 
**accountHolderDataSupplied** | **bool** | This is a Boolean value used to indicate if the cardholder information was stored in MDES along with the funding account information.   MDES will return the cardholder information to the token requestor in certain scenarios.  A default value of false should be assumed if this parameter is not supplied.  This field should not be case sensitive &lt;Add Table&gt;  | [optional] 
**locale** | **string** | Consumer preferred locale (language and country).  This information will be useful to the Token Requestor to offer the best consumer experience during digitization.  &lt;b&gt;Format&lt;/b&gt;: Two letter ISO 639-1 language in lowercase, with a underscore (”_”), followed by two letter ISO 3166-1 country code in uppercase.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

