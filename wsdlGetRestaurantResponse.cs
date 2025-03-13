using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(WrapperName = "wsdlGetRestaurantResponse", WrapperNamespace = "uri:FlexForce", IsWrapped = true)]
public class wsdlGetRestaurantResponse
{
		[MessageBodyMember(Namespace = "", Order = 0)]
		public Restaurant[] @return;

	public wsdlGetRestaurantResponse()
	{
	}

	public wsdlGetRestaurantResponse(Restaurant[] @return)
	{
		this.@return = @return;
	}
}
