using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(
    WrapperName = "wsdlGetTimeTrackersBalance",
    WrapperNamespace = "uri:FlexForce",
    IsWrapped = true
)]
public class wsdlGetTimeTrackersBalanceRequest
{
    [MessageBodyMember(Namespace = "", Order = 0)]
    public string apiKey;

    [MessageBodyMember(Namespace = "", Order = 1)]
    public ttBalanceItem[] timeTrackers;

    public wsdlGetTimeTrackersBalanceRequest() { }

    public wsdlGetTimeTrackersBalanceRequest(string apiKey, ttBalanceItem[] timeTrackers)
    {
        this.apiKey = apiKey;
        this.timeTrackers = timeTrackers;
    }
}
