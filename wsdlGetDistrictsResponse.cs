using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(
    WrapperName = "wsdlGetDistrictsResponse",
    WrapperNamespace = "uri:FlexForce",
    IsWrapped = true
)]
public class wsdlGetDistrictsResponse
{
    [MessageBodyMember(Namespace = "", Order = 0)]
    public District[] @return;

    public wsdlGetDistrictsResponse() { }

    public wsdlGetDistrictsResponse(District[] @return)
    {
        this.@return = @return;
    }
}
