using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(WrapperName = "wsdlGetEmployeeGroupsResponse", WrapperNamespace = "uri:FlexForce", IsWrapped = true)]
public class wsdlGetEmployeeGroupsResponse
{
		[MessageBodyMember(Namespace = "", Order = 0)]
		public Group[] @return;

	public wsdlGetEmployeeGroupsResponse()
	{
	}

	public wsdlGetEmployeeGroupsResponse(Group[] @return)
	{
		this.@return = @return;
	}
}
