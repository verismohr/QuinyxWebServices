using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(
    WrapperName = "wsdlGetEligibilityRules",
    WrapperNamespace = "uri:FlexForce",
    IsWrapped = true
)]
public class wsdlGetEligibilityRulesRequest
{
    [MessageBodyMember(Namespace = "", Order = 0)]
    public string apiKey;

    public wsdlGetEligibilityRulesRequest() { }

    public wsdlGetEligibilityRulesRequest(string apiKey)
    {
        this.apiKey = apiKey;
    }
}
