using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(WrapperName = "wsdlGetNeoRolesResponse", WrapperNamespace = "uri:FlexForce", IsWrapped = true)]
public class wsdlGetNeoRolesResponse
{
		[MessageBodyMember(Namespace = "", Order = 0)]
		public NeoRole[] @return;

	public wsdlGetNeoRolesResponse()
	{
	}

	public wsdlGetNeoRolesResponse(NeoRole[] @return)
	{
		this.@return = @return;
	}
}
