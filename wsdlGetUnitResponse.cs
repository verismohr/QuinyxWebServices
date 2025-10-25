using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(
    WrapperName = "wsdlGetUnitResponse",
    WrapperNamespace = "uri:FlexForce",
    IsWrapped = true
)]
public class wsdlGetUnitResponse
{
    [MessageBodyMember(Namespace = "", Order = 0)]
    public Unit[] @return;

    public wsdlGetUnitResponse() { }

    public wsdlGetUnitResponse(Unit[] @return)
    {
        this.@return = @return;
    }
}
