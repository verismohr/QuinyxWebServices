using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(
    WrapperName = "wsdlUpdateUnitResponse",
    WrapperNamespace = "uri:FlexForce",
    IsWrapped = true
)]
public class wsdlUpdateUnitResponse
{
    [MessageBodyMember(Namespace = "", Order = 0)]
    public Unit[] @return;

    public wsdlUpdateUnitResponse() { }

    public wsdlUpdateUnitResponse(Unit[] @return)
    {
        this.@return = @return;
    }
}
