using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(
    WrapperName = "wsdlUpdateTimePunches",
    WrapperNamespace = "uri:FlexForce",
    IsWrapped = true
)]
public class wsdlUpdateTimePunchesRequest
{
    [MessageBodyMember(Namespace = "", Order = 0)]
    public string apiKey;

    [MessageBodyMember(Namespace = "", Order = 1)]
    public UpdateTimePunch[] punchData;

    public wsdlUpdateTimePunchesRequest() { }

    public wsdlUpdateTimePunchesRequest(string apiKey, UpdateTimePunch[] punchData)
    {
        this.apiKey = apiKey;
        this.punchData = punchData;
    }
}
