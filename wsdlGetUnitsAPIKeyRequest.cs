using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(
    WrapperName = "wsdlGetUnitsAPIKey",
    WrapperNamespace = "uri:FlexForce",
    IsWrapped = true
)]
public class wsdlGetUnitsAPIKeyRequest
{
    [MessageBodyMember(Namespace = "", Order = 0)]
    public string apiKey;

    public wsdlGetUnitsAPIKeyRequest() { }

    public wsdlGetUnitsAPIKeyRequest(string apiKey)
    {
        this.apiKey = apiKey;
    }
}
