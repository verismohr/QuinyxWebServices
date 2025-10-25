using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(
    WrapperName = "wsdlUpdateTimePunchesResponse",
    WrapperNamespace = "uri:FlexForce",
    IsWrapped = true
)]
public class wsdlUpdateTimePunchesResponse
{
    [MessageBodyMember(Namespace = "", Order = 0)]
    public UpdateTimePunch[] @return;

    public wsdlUpdateTimePunchesResponse() { }

    public wsdlUpdateTimePunchesResponse(UpdateTimePunch[] @return)
    {
        this.@return = @return;
    }
}
