using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(
    WrapperName = "wsdlGetResultTransferToPayrollResponse",
    WrapperNamespace = "uri:FlexForce",
    IsWrapped = true
)]
public class wsdlGetResultTransferToPayrollResponse
{
    [MessageBodyMember(Namespace = "", Order = 0)]
    public ResultTransfer @return;

    public wsdlGetResultTransferToPayrollResponse() { }

    public wsdlGetResultTransferToPayrollResponse(ResultTransfer @return)
    {
        this.@return = @return;
    }
}
