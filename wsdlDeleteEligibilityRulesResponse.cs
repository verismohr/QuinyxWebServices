using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(WrapperName = "wsdlDeleteEligibilityRulesResponse", WrapperNamespace = "uri:FlexForce", IsWrapped = true)]
public class wsdlDeleteEligibilityRulesResponse
{
		[MessageBodyMember(Namespace = "", Order = 0)]
		public EligibilityRule[] @return;

	public wsdlDeleteEligibilityRulesResponse()
	{
	}

	public wsdlDeleteEligibilityRulesResponse(EligibilityRule[] @return)
	{
		this.@return = @return;
	}
}
