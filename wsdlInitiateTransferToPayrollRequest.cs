using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(
    WrapperName = "wsdlInitiateTransferToPayroll",
    WrapperNamespace = "uri:FlexForce",
    IsWrapped = true
)]
public class wsdlInitiateTransferToPayrollRequest
{
    [MessageBodyMember(Namespace = "", Order = 0)]
    public string apiKey;

    [MessageBodyMember(Namespace = "", Order = 1)]
    public searchOption searchOptions;

    public wsdlInitiateTransferToPayrollRequest() { }

    public wsdlInitiateTransferToPayrollRequest(string apiKey, searchOption searchOptions)
    {
        this.apiKey = apiKey;
        this.searchOptions = searchOptions;
    }
}
