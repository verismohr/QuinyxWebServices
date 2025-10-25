using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(
    WrapperName = "wsdlGetResultTransferToPayroll",
    WrapperNamespace = "uri:FlexForce",
    IsWrapped = true
)]
public class wsdlGetResultTransferToPayrollRequest
{
    [MessageBodyMember(Namespace = "", Order = 0)]
    public string apiKey;

    [MessageBodyMember(Namespace = "", Order = 1)]
    public string extTransferId;

    public wsdlGetResultTransferToPayrollRequest() { }

    public wsdlGetResultTransferToPayrollRequest(string apiKey, string extTransferId)
    {
        this.apiKey = apiKey;
        this.extTransferId = extTransferId;
    }
}
