using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(
    WrapperName = "wsdlGetTimePunches",
    WrapperNamespace = "uri:FlexForce",
    IsWrapped = true
)]
public class wsdlGetTimePunchesRequest
{
    [MessageBodyMember(Namespace = "", Order = 0)]
    public string apiKey;

    [MessageBodyMember(Namespace = "", Order = 1)]
    public getTimePunchesRequest getTimePunchesRequest;

    public wsdlGetTimePunchesRequest() { }

    public wsdlGetTimePunchesRequest(string apiKey, getTimePunchesRequest getTimePunchesRequest)
    {
        this.apiKey = apiKey;
        this.getTimePunchesRequest = getTimePunchesRequest;
    }
}
