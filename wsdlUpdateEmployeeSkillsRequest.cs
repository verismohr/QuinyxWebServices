using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(WrapperName = "wsdlUpdateEmployeeSkills", WrapperNamespace = "uri:FlexForce", IsWrapped = true)]
public class wsdlUpdateEmployeeSkillsRequest
{
		[MessageBodyMember(Namespace = "", Order = 0)]
		public string apiKey;

		[MessageBodyMember(Namespace = "", Order = 1)]
		public UpdateEmployeeSkill[] skills;

	public wsdlUpdateEmployeeSkillsRequest()
	{
	}

	public wsdlUpdateEmployeeSkillsRequest(string apiKey, UpdateEmployeeSkill[] skills)
	{
		this.apiKey = apiKey;
		this.skills = skills;
	}
}
