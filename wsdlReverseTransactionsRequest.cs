using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(
    WrapperName = "wsdlReverseTransactions",
    WrapperNamespace = "uri:FlexForce",
    IsWrapped = true
)]
public class wsdlReverseTransactionsRequest
{
    [MessageBodyMember(Namespace = "", Order = 0)]
    public string apiKey;

    [MessageBodyMember(Namespace = "", Order = 1)]
    public reverseInfo[] reverseInfos;

    public wsdlReverseTransactionsRequest() { }

    public wsdlReverseTransactionsRequest(string apiKey, reverseInfo[] reverseInfos)
    {
        this.apiKey = apiKey;
        this.reverseInfos = reverseInfos;
    }
}
