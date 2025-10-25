using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(
    WrapperName = "wsdlGetSkillCategories",
    WrapperNamespace = "uri:FlexForce",
    IsWrapped = true
)]
public class wsdlGetSkillCategoriesRequest
{
    [MessageBodyMember(Namespace = "", Order = 0)]
    public string apiKey;

    public wsdlGetSkillCategoriesRequest() { }

    public wsdlGetSkillCategoriesRequest(string apiKey)
    {
        this.apiKey = apiKey;
    }
}
