using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(
    WrapperName = "wsdlInitiateTransferToPayrollResponse",
    WrapperNamespace = "uri:FlexForce",
    IsWrapped = true
)]
public class wsdlInitiateTransferToPayrollResponse
{
    [MessageBodyMember(Namespace = "", Order = 0)]
    public TransferStatus @return;

    public wsdlInitiateTransferToPayrollResponse() { }

    public wsdlInitiateTransferToPayrollResponse(TransferStatus @return)
    {
        this.@return = @return;
    }
}
