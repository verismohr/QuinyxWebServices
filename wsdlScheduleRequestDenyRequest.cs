using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(
    WrapperName = "wsdlScheduleRequestDeny",
    WrapperNamespace = "uri:FlexForce",
    IsWrapped = true
)]
public class wsdlScheduleRequestDenyRequest
{
    [MessageBodyMember(Namespace = "", Order = 0)]
    public string apiKey;

    [MessageBodyMember(Namespace = "", Order = 1)]
    public scheduleRequest scheduleRequest;

    public wsdlScheduleRequestDenyRequest() { }

    public wsdlScheduleRequestDenyRequest(string apiKey, scheduleRequest scheduleRequest)
    {
        this.apiKey = apiKey;
        this.scheduleRequest = scheduleRequest;
    }
}
