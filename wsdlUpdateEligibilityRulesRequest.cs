using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(
    WrapperName = "wsdlUpdateEligibilityRules",
    WrapperNamespace = "uri:FlexForce",
    IsWrapped = true
)]
public class wsdlUpdateEligibilityRulesRequest
{
    [MessageBodyMember(Namespace = "", Order = 0)]
    public string apiKey;

    [MessageBodyMember(Namespace = "", Order = 1)]
    public EligibilityRule[] eligibilityRules;

    public wsdlUpdateEligibilityRulesRequest() { }

    public wsdlUpdateEligibilityRulesRequest(string apiKey, EligibilityRule[] eligibilityRules)
    {
        this.apiKey = apiKey;
        this.eligibilityRules = eligibilityRules;
    }
}
