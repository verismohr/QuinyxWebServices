using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(
    WrapperName = "wsdlPunchResponse",
    WrapperNamespace = "uri:FlexForce",
    IsWrapped = true
)]
public class wsdlPunchResponse
{
    [MessageBodyMember(Namespace = "", Order = 0)]
    public PunchValidation @return;

    public wsdlPunchResponse() { }

    public wsdlPunchResponse(PunchValidation @return)
    {
        this.@return = @return;
    }
}
