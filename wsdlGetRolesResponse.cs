using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(WrapperName = "wsdlGetRolesResponse", WrapperNamespace = "uri:FlexForce", IsWrapped = true)]
public class wsdlGetRolesResponse
{
		[MessageBodyMember(Namespace = "", Order = 0)]
		public Role[] @return;

	public wsdlGetRolesResponse()
	{
	}

	public wsdlGetRolesResponse(Role[] @return)
	{
		this.@return = @return;
	}
}
