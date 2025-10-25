using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(
    WrapperName = "wsdlGetRestaurantsAPIKey",
    WrapperNamespace = "uri:FlexForce",
    IsWrapped = true
)]
public class wsdlGetRestaurantsAPIKeyRequest
{
    [MessageBodyMember(Namespace = "", Order = 0)]
    public string apiKey;

    public wsdlGetRestaurantsAPIKeyRequest() { }

    public wsdlGetRestaurantsAPIKeyRequest(string apiKey)
    {
        this.apiKey = apiKey;
    }
}
