using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(
    WrapperName = "wsdlUpdateEmployeePortraitsResponse",
    WrapperNamespace = "uri:FlexForce",
    IsWrapped = true
)]
public class wsdlUpdateEmployeePortraitsResponse
{
    [MessageBodyMember(Namespace = "", Order = 0)]
    public UpdateEmployeePortrait[] @return;

    public wsdlUpdateEmployeePortraitsResponse() { }

    public wsdlUpdateEmployeePortraitsResponse(UpdateEmployeePortrait[] @return)
    {
        this.@return = @return;
    }
}
