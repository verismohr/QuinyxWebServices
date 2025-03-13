using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(WrapperName = "wsdlGetErrorMessagesResponse", WrapperNamespace = "uri:FlexForce", IsWrapped = true)]
public class wsdlGetErrorMessagesResponse
{
		[MessageBodyMember(Namespace = "", Order = 0)]
		public ErrorMessage[] @return;

	public wsdlGetErrorMessagesResponse()
	{
	}

	public wsdlGetErrorMessagesResponse(ErrorMessage[] @return)
	{
		this.@return = @return;
	}
}
