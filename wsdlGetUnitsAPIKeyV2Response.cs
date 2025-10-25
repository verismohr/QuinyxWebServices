using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(
    WrapperName = "wsdlGetUnitsAPIKeyV2Response",
    WrapperNamespace = "uri:FlexForce",
    IsWrapped = true
)]
public class wsdlGetUnitsAPIKeyV2Response
{
    [MessageBodyMember(Namespace = "", Order = 0)]
    public UnitKeyV2[] @return;

    public wsdlGetUnitsAPIKeyV2Response() { }

    public wsdlGetUnitsAPIKeyV2Response(UnitKeyV2[] @return)
    {
        this.@return = @return;
    }
}
