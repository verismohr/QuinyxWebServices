using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(
    WrapperName = "wsdlGetTimeTrackerListResponse",
    WrapperNamespace = "uri:FlexForce",
    IsWrapped = true
)]
public class wsdlGetTimeTrackerListResponse
{
    [MessageBodyMember(Namespace = "", Order = 0)]
    public timeTrackerListItem[] @return;

    public wsdlGetTimeTrackerListResponse() { }

    public wsdlGetTimeTrackerListResponse(timeTrackerListItem[] @return)
    {
        this.@return = @return;
    }
}
