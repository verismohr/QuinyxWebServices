using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(
    WrapperName = "wsdlGetTimeTrackersBalanceResponse",
    WrapperNamespace = "uri:FlexForce",
    IsWrapped = true
)]
public class wsdlGetTimeTrackersBalanceResponse
{
    [MessageBodyMember(Namespace = "", Order = 0)]
    public ttBalanceResultItem[] @return;

    public wsdlGetTimeTrackersBalanceResponse() { }

    public wsdlGetTimeTrackersBalanceResponse(ttBalanceResultItem[] @return)
    {
        this.@return = @return;
    }
}
