using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(
    WrapperName = "wsdlGetOvertimeMethodsResponse",
    WrapperNamespace = "uri:FlexForce",
    IsWrapped = true
)]
public class wsdlGetOvertimeMethodsResponse
{
    [MessageBodyMember(Namespace = "", Order = 0)]
    public OvertimeMethod[] @return;

    public wsdlGetOvertimeMethodsResponse() { }

    public wsdlGetOvertimeMethodsResponse(OvertimeMethod[] @return)
    {
        this.@return = @return;
    }
}
