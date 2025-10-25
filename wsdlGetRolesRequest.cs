using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(
    WrapperName = "wsdlGetRoles",
    WrapperNamespace = "uri:FlexForce",
    IsWrapped = true
)]
public class wsdlGetRolesRequest
{
    [MessageBodyMember(Namespace = "", Order = 0)]
    public string apiKey;

    public wsdlGetRolesRequest() { }

    public wsdlGetRolesRequest(string apiKey)
    {
        this.apiKey = apiKey;
    }
}
