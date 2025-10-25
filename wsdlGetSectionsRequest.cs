using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(
    WrapperName = "wsdlGetSections",
    WrapperNamespace = "uri:FlexForce",
    IsWrapped = true
)]
public class wsdlGetSectionsRequest
{
    [MessageBodyMember(Namespace = "", Order = 0)]
    public string apiKey;

    [MessageBodyMember(Namespace = "", Order = 1)]
    public string lastModified;

    public wsdlGetSectionsRequest() { }

    public wsdlGetSectionsRequest(string apiKey, string lastModified)
    {
        this.apiKey = apiKey;
        this.lastModified = lastModified;
    }
}
