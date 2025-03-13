using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(WrapperName = "wsdlGetEmployeeSkillsResponse", WrapperNamespace = "uri:FlexForce", IsWrapped = true)]
public class wsdlGetEmployeeSkillsResponse
{
		[MessageBodyMember(Namespace = "", Order = 0)]
		public GetEmployeeSkillsResponse @return;

	public wsdlGetEmployeeSkillsResponse()
	{
	}

	public wsdlGetEmployeeSkillsResponse(GetEmployeeSkillsResponse @return)
	{
		this.@return = @return;
	}
}
