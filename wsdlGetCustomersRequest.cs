using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(WrapperName = "wsdlGetCustomers", WrapperNamespace = "uri:FlexForce", IsWrapped = true)]
public class wsdlGetCustomersRequest
{
		[MessageBodyMember(Namespace = "", Order = 0)]
		public string apiKey;

	public wsdlGetCustomersRequest()
	{
	}

	public wsdlGetCustomersRequest(string apiKey)
	{
		this.apiKey = apiKey;
	}
}
