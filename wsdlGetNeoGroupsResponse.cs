using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(WrapperName = "wsdlGetNeoGroupsResponse", WrapperNamespace = "uri:FlexForce", IsWrapped = true)]
public class wsdlGetNeoGroupsResponse
{
		[MessageBodyMember(Namespace = "", Order = 0)]
		public NeoGroup[] @return;

	public wsdlGetNeoGroupsResponse()
	{
	}

	public wsdlGetNeoGroupsResponse(NeoGroup[] @return)
	{
		this.@return = @return;
	}
}
