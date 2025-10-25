using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(
    WrapperName = "wsdlDeleteEligibilityRules",
    WrapperNamespace = "uri:FlexForce",
    IsWrapped = true
)]
public class wsdlDeleteEligibilityRulesRequest
{
    [MessageBodyMember(Namespace = "", Order = 0)]
    public string apiKey;

    [MessageBodyMember(Namespace = "", Order = 1)]
    public EligibilityRule[] eligibilityRules;

    public wsdlDeleteEligibilityRulesRequest() { }

    public wsdlDeleteEligibilityRulesRequest(string apiKey, EligibilityRule[] eligibilityRules)
    {
        this.apiKey = apiKey;
        this.eligibilityRules = eligibilityRules;
    }
}
