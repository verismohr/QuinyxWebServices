using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(
    WrapperName = "wsdlUpdateTextItems",
    WrapperNamespace = "uri:FlexForce",
    IsWrapped = true
)]
public class wsdlUpdateTextItemsRequest
{
    [MessageBodyMember(Namespace = "", Order = 0)]
    public string apiKey;

    [MessageBodyMember(Namespace = "", Order = 1)]
    public TextItem[] TextItems;

    public wsdlUpdateTextItemsRequest() { }

    public wsdlUpdateTextItemsRequest(string apiKey, TextItem[] TextItems)
    {
        this.apiKey = apiKey;
        this.TextItems = TextItems;
    }
}
