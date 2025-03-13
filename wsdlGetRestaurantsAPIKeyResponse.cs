using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(WrapperName = "wsdlGetRestaurantsAPIKeyResponse", WrapperNamespace = "uri:FlexForce", IsWrapped = true)]
public class wsdlGetRestaurantsAPIKeyResponse
{
		[MessageBodyMember(Namespace = "", Order = 0)]
		public RestaurantKey[] @return;

	public wsdlGetRestaurantsAPIKeyResponse()
	{
	}

	public wsdlGetRestaurantsAPIKeyResponse(RestaurantKey[] @return)
	{
		this.@return = @return;
	}
}
