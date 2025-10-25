using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(
    WrapperName = "wsdlUpdateShifts",
    WrapperNamespace = "uri:FlexForce",
    IsWrapped = true
)]
public class wsdlUpdateShiftsRequest
{
    [MessageBodyMember(Namespace = "", Order = 0)]
    public string apiKey;

    [MessageBodyMember(Namespace = "", Order = 1)]
    public Shift[] Shifts;

    public wsdlUpdateShiftsRequest() { }

    public wsdlUpdateShiftsRequest(string apiKey, Shift[] Shifts)
    {
        this.apiKey = apiKey;
        this.Shifts = Shifts;
    }
}
