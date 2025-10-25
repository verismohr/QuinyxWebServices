using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(
    WrapperName = "wsdlReverseTransactionsResponse",
    WrapperNamespace = "uri:FlexForce",
    IsWrapped = true
)]
public class wsdlReverseTransactionsResponse
{
    [MessageBodyMember(Namespace = "", Order = 0)]
    public reverseInfo[] @return;

    public wsdlReverseTransactionsResponse() { }

    public wsdlReverseTransactionsResponse(reverseInfo[] @return)
    {
        this.@return = @return;
    }
}
