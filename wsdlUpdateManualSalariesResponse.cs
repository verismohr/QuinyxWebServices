using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(
    WrapperName = "wsdlUpdateManualSalariesResponse",
    WrapperNamespace = "uri:FlexForce",
    IsWrapped = true
)]
public class wsdlUpdateManualSalariesResponse
{
    [MessageBodyMember(Namespace = "", Order = 0)]
    public updateManualSalary[] @return;

    public wsdlUpdateManualSalariesResponse() { }

    public wsdlUpdateManualSalariesResponse(updateManualSalary[] @return)
    {
        this.@return = @return;
    }
}
