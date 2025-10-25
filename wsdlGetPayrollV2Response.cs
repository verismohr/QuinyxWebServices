using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(
    WrapperName = "wsdlGetPayrollV2Response",
    WrapperNamespace = "uri:FlexForce",
    IsWrapped = true
)]
public class wsdlGetPayrollV2Response
{
    [MessageBodyMember(Namespace = "", Order = 0)]
    public PayrollV2[] @return;

    public wsdlGetPayrollV2Response() { }

    public wsdlGetPayrollV2Response(PayrollV2[] @return)
    {
        this.@return = @return;
    }
}
