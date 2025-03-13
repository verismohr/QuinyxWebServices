using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(WrapperName = "wsdlGetNeoRoles", WrapperNamespace = "uri:FlexForce", IsWrapped = true)]
public class wsdlGetNeoRolesRequest
{
		[MessageBodyMember(Namespace = "", Order = 0)]
		public string apiKey;

	public wsdlGetNeoRolesRequest()
	{
	}

	public wsdlGetNeoRolesRequest(string apiKey)
	{
		this.apiKey = apiKey;
	}
}
