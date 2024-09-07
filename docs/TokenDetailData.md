# Org.OpenAPITools.Model.TokenDetailData

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TokenNumber** | **string** | The Token Primary Account Number of the card.  Conditional – required if tokenType &#x3D; STATIC or in Tokenize when Storage Technology is specified as \&quot;SERVER\&quot;  | [optional] 
**ExpiryMonth** | **string** | The month of the token expiration date. Conditional – required if tokenType &#x3D; STATIC or in Tokenize when Storage Technology is specified as \&quot;SERVER\&quot;  | [optional] 
**ExpiryYear** | **string** | The year of the token expiration date. Conditional – required if tokenType &#x3D; STATIC or in Tokenize when Storage Technology is specified as \&quot;SERVER\&quot;  | [optional] 
**DataValidUntilTimestamp** | **string** | The date/time after which this encrypted object is considered invalid. If present, all systems must reject this encrypted object after this time and treat it as invalid data. Must be expressed in ISO 8601 extended format as one of the following:   - YYYY-MM-DDThh:mm:ss[.sss]Z   - YYYY-MM-DDThh:mm:ss[.sss]±hh:mm  Where [.sss] is optional and can be 1 to 3 digits. Must be a value no more than 30 days in the future. Mastercard recommends using a value of (Current Time + 30 minutes).  | [optional] 
**PaymentAccountReference** | **string** | \&quot;The unique account reference assigned to the PAN. Conditionally returned if the Token Requestor has opted to receive PAR and providing PAR is assigned by Mastercard or the Issuer provides PAR in the authorization message response.\&quot;  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

