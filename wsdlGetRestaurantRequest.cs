using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(WrapperName = "wsdlGetRestaurant", WrapperNamespace = "uri:FlexForce", IsWrapped = true)]
public class wsdlGetRestaurantRequest
{
		[MessageBodyMember(Namespace = "", Order = 0)]
		public string apiKey;

	public wsdlGetRestaurantRequest()
	{
	}

	public wsdlGetRestaurantRequest(string apiKey)
	{
		this.apiKey = apiKey;
	}
}
