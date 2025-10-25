using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(
    WrapperName = "wsdlGetTimePunchesResponse",
    WrapperNamespace = "uri:FlexForce",
    IsWrapped = true
)]
public class wsdlGetTimePunchesResponse
{
    [MessageBodyMember(Namespace = "", Order = 0)]
    public GetTimePunchesResponse @return;

    public wsdlGetTimePunchesResponse() { }

    public wsdlGetTimePunchesResponse(GetTimePunchesResponse @return)
    {
        this.@return = @return;
    }
}
