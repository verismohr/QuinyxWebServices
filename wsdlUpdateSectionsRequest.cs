using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(
    WrapperName = "wsdlUpdateSections",
    WrapperNamespace = "uri:FlexForce",
    IsWrapped = true
)]
public class wsdlUpdateSectionsRequest
{
    [MessageBodyMember(Namespace = "", Order = 0)]
    public string apiKey;

    [MessageBodyMember(Namespace = "", Order = 1)]
    public Section[] sections;

    public wsdlUpdateSectionsRequest() { }

    public wsdlUpdateSectionsRequest(string apiKey, Section[] sections)
    {
        this.apiKey = apiKey;
        this.sections = sections;
    }
}
