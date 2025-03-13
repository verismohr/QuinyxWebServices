using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(WrapperName = "wsdlGetTextItems", WrapperNamespace = "uri:FlexForce", IsWrapped = true)]
public class wsdlGetTextItemsRequest
{
		[MessageBodyMember(Namespace = "", Order = 0)]
		public string apiKey;

	public wsdlGetTextItemsRequest()
	{
	}

	public wsdlGetTextItemsRequest(string apiKey)
	{
		this.apiKey = apiKey;
	}
}
