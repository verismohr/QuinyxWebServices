using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(
    WrapperName = "wsdlGetSalaryCompensationsResponse",
    WrapperNamespace = "uri:FlexForce",
    IsWrapped = true
)]
public class wsdlGetSalaryCompensationsResponse
{
    [MessageBodyMember(Namespace = "", Order = 0)]
    public SalaryCompensation[] @return;

    public wsdlGetSalaryCompensationsResponse() { }

    public wsdlGetSalaryCompensationsResponse(SalaryCompensation[] @return)
    {
        this.@return = @return;
    }
}
