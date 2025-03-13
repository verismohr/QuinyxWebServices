using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(WrapperName = "wsdlGetErrorMessages", WrapperNamespace = "uri:FlexForce", IsWrapped = true)]
public class wsdlGetErrorMessagesRequest
{
		[MessageBodyMember(Namespace = "", Order = 0)]
		public string apiKey;

		[MessageBodyMember(Namespace = "", Order = 1)]
		public string wsdlServiceName;

	public wsdlGetErrorMessagesRequest()
	{
	}

	public wsdlGetErrorMessagesRequest(string apiKey, string wsdlServiceName)
	{
		this.apiKey = apiKey;
		this.wsdlServiceName = wsdlServiceName;
	}
}
