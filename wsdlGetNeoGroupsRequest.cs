using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(
    WrapperName = "wsdlGetNeoGroups",
    WrapperNamespace = "uri:FlexForce",
    IsWrapped = true
)]
public class wsdlGetNeoGroupsRequest
{
    [MessageBodyMember(Namespace = "", Order = 0)]
    public string apiKey;

    public wsdlGetNeoGroupsRequest() { }

    public wsdlGetNeoGroupsRequest(string apiKey)
    {
        this.apiKey = apiKey;
    }
}
