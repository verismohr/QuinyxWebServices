using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(
    WrapperName = "wsdlScheduleRequestApprove",
    WrapperNamespace = "uri:FlexForce",
    IsWrapped = true
)]
public class wsdlScheduleRequestApproveRequest
{
    [MessageBodyMember(Namespace = "", Order = 0)]
    public string apiKey;

    [MessageBodyMember(Namespace = "", Order = 1)]
    public scheduleRequest scheduleRequest;

    public wsdlScheduleRequestApproveRequest() { }

    public wsdlScheduleRequestApproveRequest(string apiKey, scheduleRequest scheduleRequest)
    {
        this.apiKey = apiKey;
        this.scheduleRequest = scheduleRequest;
    }
}
