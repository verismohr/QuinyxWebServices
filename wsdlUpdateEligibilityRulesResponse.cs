using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(
    WrapperName = "wsdlUpdateEligibilityRulesResponse",
    WrapperNamespace = "uri:FlexForce",
    IsWrapped = true
)]
public class wsdlUpdateEligibilityRulesResponse
{
    [MessageBodyMember(Namespace = "", Order = 0)]
    public EligibilityRule[] @return;

    public wsdlUpdateEligibilityRulesResponse() { }

    public wsdlUpdateEligibilityRulesResponse(EligibilityRule[] @return)
    {
        this.@return = @return;
    }
}
