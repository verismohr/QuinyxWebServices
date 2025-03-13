using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(WrapperName = "wsdlUpdateEmployeeSkillsResponse", WrapperNamespace = "uri:FlexForce", IsWrapped = true)]
public class wsdlUpdateEmployeeSkillsResponse
{
		[MessageBodyMember(Namespace = "", Order = 0)]
		public UpdateEmployeeSkill[] @return;

	public wsdlUpdateEmployeeSkillsResponse()
	{
	}

	public wsdlUpdateEmployeeSkillsResponse(UpdateEmployeeSkill[] @return)
	{
		this.@return = @return;
	}
}
