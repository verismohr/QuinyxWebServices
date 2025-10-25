using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(
    WrapperName = "wsdlGetTextItemsResponse",
    WrapperNamespace = "uri:FlexForce",
    IsWrapped = true
)]
public class wsdlGetTextItemsResponse
{
    [MessageBodyMember(Namespace = "", Order = 0)]
    public GetTextItem[] @return;

    public wsdlGetTextItemsResponse() { }

    public wsdlGetTextItemsResponse(GetTextItem[] @return)
    {
        this.@return = @return;
    }
}
