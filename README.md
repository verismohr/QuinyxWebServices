# QuinyxWebServices

```csharp
var binding = new BasicHttpBinding(BasicHttpSecurityMode.Transport) { MaxReceivedMessageSize = 9_999_999 };
var address = new EndpointAddress("https://rc.quinyx.com/FlexForceWebServices.php");
var client = new FlexForcePortTypeClient(binding, address);

var agreementTemplate = client
    .wsdlGetAgreementTemplatesV2(new() // wsdlGetAgreementTemplatesV2Request
    {
        apiKey = "*************",
        GetAgreementTemplatesV2 = new() // GetAgreementTemplatesV2
        {
            modifiedAfter = "2024-01-01",
        }
    })
    .@return
    .agreementTemplates
    .Select(x => new
    {
        x.id,
        x.extTemplateId,
        x.templateName
    })
    .OrderBy(x => x.extTemplateId);
```