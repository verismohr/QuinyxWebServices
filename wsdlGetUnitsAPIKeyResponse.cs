using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(
    WrapperName = "wsdlGetUnitsAPIKeyResponse",
    WrapperNamespace = "uri:FlexForce",
    IsWrapped = true
)]
public class wsdlGetUnitsAPIKeyResponse
{
    [MessageBodyMember(Namespace = "", Order = 0)]
    public UnitKey[] @return;

    public wsdlGetUnitsAPIKeyResponse() { }

    public wsdlGetUnitsAPIKeyResponse(UnitKey[] @return)
    {
        this.@return = @return;
    }
}
