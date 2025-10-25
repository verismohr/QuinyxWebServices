using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(
    WrapperName = "wsdlUpdateDistricts",
    WrapperNamespace = "uri:FlexForce",
    IsWrapped = true
)]
public class wsdlUpdateDistrictsRequest
{
    [MessageBodyMember(Namespace = "", Order = 0)]
    public string apiKey;

    [MessageBodyMember(Namespace = "", Order = 1)]
    public UpdateDistrict[] districts;

    public wsdlUpdateDistrictsRequest() { }

    public wsdlUpdateDistrictsRequest(string apiKey, UpdateDistrict[] districts)
    {
        this.apiKey = apiKey;
        this.districts = districts;
    }
}
