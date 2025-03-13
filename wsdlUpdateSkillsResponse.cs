using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(WrapperName = "wsdlUpdateSkillsResponse", WrapperNamespace = "uri:FlexForce", IsWrapped = true)]
public class wsdlUpdateSkillsResponse
{
		[MessageBodyMember(Namespace = "", Order = 0)]
		public SkillItem[] @return;

	public wsdlUpdateSkillsResponse()
	{
	}

	public wsdlUpdateSkillsResponse(SkillItem[] @return)
	{
		this.@return = @return;
	}
}
