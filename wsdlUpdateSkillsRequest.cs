using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(
    WrapperName = "wsdlUpdateSkills",
    WrapperNamespace = "uri:FlexForce",
    IsWrapped = true
)]
public class wsdlUpdateSkillsRequest
{
    [MessageBodyMember(Namespace = "", Order = 0)]
    public string apiKey;

    [MessageBodyMember(Namespace = "", Order = 1)]
    public SkillItem[] SkillItems;

    public wsdlUpdateSkillsRequest() { }

    public wsdlUpdateSkillsRequest(string apiKey, SkillItem[] SkillItems)
    {
        this.apiKey = apiKey;
        this.SkillItems = SkillItems;
    }
}
