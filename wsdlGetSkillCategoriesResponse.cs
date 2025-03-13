using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(WrapperName = "wsdlGetSkillCategoriesResponse", WrapperNamespace = "uri:FlexForce", IsWrapped = true)]
public class wsdlGetSkillCategoriesResponse
{
		[MessageBodyMember(Namespace = "", Order = 0)]
		public SkillCategory[] @return;

	public wsdlGetSkillCategoriesResponse()
	{
	}

	public wsdlGetSkillCategoriesResponse(SkillCategory[] @return)
	{
		this.@return = @return;
	}
}
