using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(
    WrapperName = "wsdlUpdateDistrictsResponse",
    WrapperNamespace = "uri:FlexForce",
    IsWrapped = true
)]
public class wsdlUpdateDistrictsResponse
{
    [MessageBodyMember(Namespace = "", Order = 0)]
    public UpdateDistrict[] @return;

    public wsdlUpdateDistrictsResponse() { }

    public wsdlUpdateDistrictsResponse(UpdateDistrict[] @return)
    {
        this.@return = @return;
    }
}
