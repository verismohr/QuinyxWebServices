using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(
    WrapperName = "wsdlGetSchedulesV2Response",
    WrapperNamespace = "uri:FlexForce",
    IsWrapped = true
)]
public class wsdlGetSchedulesV2Response
{
    [MessageBodyMember(Namespace = "", Order = 0)]
    public SchedulesV2Response @return;

    public wsdlGetSchedulesV2Response() { }

    public wsdlGetSchedulesV2Response(SchedulesV2Response @return)
    {
        this.@return = @return;
    }
}
