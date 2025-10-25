using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(
    WrapperName = "wsdlDeleteSalaryCompensationsResponse",
    WrapperNamespace = "uri:FlexForce",
    IsWrapped = true
)]
public class wsdlDeleteSalaryCompensationsResponse
{
    [MessageBodyMember(Namespace = "", Order = 0)]
    public SalaryCompensation[] @return;

    public wsdlDeleteSalaryCompensationsResponse() { }

    public wsdlDeleteSalaryCompensationsResponse(SalaryCompensation[] @return)
    {
        this.@return = @return;
    }
}
