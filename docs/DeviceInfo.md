# Acme.App.MastercardApi.Client.Model.DeviceInfo
Contains information about the target device to be provisioned. Max length - Not applicable. Type - Map (DeviceInfo).

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**deviceName** | **string** | The name that the Account holder has associated to the device with the Payment App Provider. | [optional] 
**serialNumber** | **string** | The serial number of the device. May be masked. | [optional] 
**formFactor** | **string** | The form factor of the device to be provisioned. New values can be added without notice and should be accpeted. Must be one of; PHONE &#x3D; Mobile phone, TABLET &#x3D; Tablet computer, TABLET_OR_EREADER &#x3D; Tablet computer or e-reader, WATCH &#x3D; Watch, WATCH_OR_WRISTBAND &#x3D; Watch or wristband, including a fitness band, smart strap, disposable band, watch add-on, security/ ID Band, CARD &#x3D; Card, STICKER &#x3D; Sticker, PC &#x3D; PC or Laptop, DEVICE_PERIPHERAL &#x3D; Device peripherals, such as a mobile phone case or sleeve, TAG &#x3D; Tag, such as a key fob or mobile tag, JEWELRY &#x3D; Jewelry, such as a ring, bracelet, necklace and cuff links, FASHION_ACCESSORY &#x3D; Fashion accessory, such as a handbag, bag charm, glasses, GARMENT &#x3D; Garment, such as a dress, DOMESTIC_APPLIANCE &#x3D; Domestic appliance, such as a refrigerator, washing machine, VEHICLE &#x3D; Vehicle, including vehicle attached devices, MEDIA_OR_GAMING_DEVICE &#x3D; Media or gaming device, including a set top box, media player, television, UNDEFINED &#x3D; Device type that is not yet defined. Used for wallets introducing a new device type that is not yet public knowledge. | [optional] 
**isoDeviceType** | **string** | The 2 digit device type provided on the iso messages that the token is being provisioned to. Only present when provided by a Wallet Provider. See Global Communication bulletins for values. | [optional] 
**osName** | **string** | The name of the device operating system. Must be one of; ANDROID &#x3D; Google Android operating system, WINDOWS &#x3D; Microsoft Windows operating system, TIZEN &#x3D; Tizen operating system, IOS &#x3D; Apple iOS operating system, PAGARE_EMBEDDED_OS &#x3D; FitPay embedded operating system, ANDROID_WEAR &#x3D; Android wear operating system, EMBEDDED_OS &#x3D; All Embedded operating system and Real time Operating systems. | [optional] 
**osVersion** | **string** | The version of the device operating system. | [optional] 
**imei** | **string** | The IMEI number of the device being provisioned. | [optional] 
**msisdn** | **string** | The MSISDN of the device being provisioned. Type - String. | [optional] 
**paymentTypes** | **List&lt;string&gt;** | Different types of Payments supported for the token. Must be one of; NFC &#x3D; The token is NFC capable, DSRP &#x3D; The token is DSRP capable, ECOMMERCE &#x3D; The token can be used for e-commerce transactions. Max length - Not applicable. Type - Array [String]. | [optional] 
**storageTechnology** | **string** | The architecture or technology used for token storage. Must be one of DEVICE_MEMORY - Device memory, DEVICE_MEMORY_PROTECTED_TPM - Device memory using a protected trust platform module, TEE - Trusted execution environment, SE - Secure element, SERVER - Server host, or VEE - Virtual Execution Environment. | [optional] 
**cardCaptureTechnology** | **string** | TThe technology used to capture the card details. New values can be added at any time and must not result in an error. Must be one of CAMERA &#x3D; The card details were captured using the device camera, MANUAL &#x3D; The card details were manually entered, UNKNOWN &#x3D; It is not known how the card details were entered, READER_MODE &#x3D; The card details were captured using reader mode. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

