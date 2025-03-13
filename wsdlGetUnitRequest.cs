using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(WrapperName = "wsdlGetUnit", WrapperNamespace = "uri:FlexForce", IsWrapped = true)]
public class wsdlGetUnitRequest
{
		[MessageBodyMember(Namespace = "", Order = 0)]
		public string apiKey;

	public wsdlGetUnitRequest()
	{
	}

	public wsdlGetUnitRequest(string apiKey)
	{
		this.apiKey = apiKey;
	}
}
