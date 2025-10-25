using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(
    WrapperName = "wsdlGetDistricts",
    WrapperNamespace = "uri:FlexForce",
    IsWrapped = true
)]
public class wsdlGetDistrictsRequest
{
    [MessageBodyMember(Namespace = "", Order = 0)]
    public string apiKey;

    [MessageBodyMember(Namespace = "", Order = 1)]
    public string lastModified;

    public wsdlGetDistrictsRequest() { }

    public wsdlGetDistrictsRequest(string apiKey, string lastModified)
    {
        this.apiKey = apiKey;
        this.lastModified = lastModified;
    }
}
