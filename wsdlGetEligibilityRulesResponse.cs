using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(
    WrapperName = "wsdlGetEligibilityRulesResponse",
    WrapperNamespace = "uri:FlexForce",
    IsWrapped = true
)]
public class wsdlGetEligibilityRulesResponse
{
    [MessageBodyMember(Namespace = "", Order = 0)]
    public EligibilityRule[] @return;

    public wsdlGetEligibilityRulesResponse() { }

    public wsdlGetEligibilityRulesResponse(EligibilityRule[] @return)
    {
        this.@return = @return;
    }
}
