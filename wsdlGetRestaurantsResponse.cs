using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(
    WrapperName = "wsdlGetRestaurantsResponse",
    WrapperNamespace = "uri:FlexForce",
    IsWrapped = true
)]
public class wsdlGetRestaurantsResponse
{
    [MessageBodyMember(Namespace = "", Order = 0)]
    public Restaurant[] @return;

    public wsdlGetRestaurantsResponse() { }

    public wsdlGetRestaurantsResponse(Restaurant[] @return)
    {
        this.@return = @return;
    }
}
