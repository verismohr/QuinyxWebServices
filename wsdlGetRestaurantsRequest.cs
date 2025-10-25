using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(
    WrapperName = "wsdlGetRestaurants",
    WrapperNamespace = "uri:FlexForce",
    IsWrapped = true
)]
public class wsdlGetRestaurantsRequest
{
    [MessageBodyMember(Namespace = "", Order = 0)]
    public string apiKey;

    [MessageBodyMember(Namespace = "", Order = 1)]
    public string lastModified;

    public wsdlGetRestaurantsRequest() { }

    public wsdlGetRestaurantsRequest(string apiKey, string lastModified)
    {
        this.apiKey = apiKey;
        this.lastModified = lastModified;
    }
}
