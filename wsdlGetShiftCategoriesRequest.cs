using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(
    WrapperName = "wsdlGetShiftCategories",
    WrapperNamespace = "uri:FlexForce",
    IsWrapped = true
)]
public class wsdlGetShiftCategoriesRequest
{
    [MessageBodyMember(Namespace = "", Order = 0)]
    public string apiKey;

    [MessageBodyMember(Namespace = "", Order = 1)]
    public string lastModified;

    [MessageBodyMember(Namespace = "", Order = 2)]
    public bool includeTags;

    [MessageBodyMember(Namespace = "", Order = 3)]
    public bool includeSkills;

    public wsdlGetShiftCategoriesRequest() { }

    public wsdlGetShiftCategoriesRequest(
        string apiKey,
        string lastModified,
        bool includeTags,
        bool includeSkills
    )
    {
        this.apiKey = apiKey;
        this.lastModified = lastModified;
        this.includeTags = includeTags;
        this.includeSkills = includeSkills;
    }
}
