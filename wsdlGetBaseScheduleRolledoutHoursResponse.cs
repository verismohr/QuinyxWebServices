using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(
    WrapperName = "wsdlGetBaseScheduleRolledoutHoursResponse",
    WrapperNamespace = "uri:FlexForce",
    IsWrapped = true
)]
public class wsdlGetBaseScheduleRolledoutHoursResponse
{
    [MessageBodyMember(Namespace = "", Order = 0)]
    public baseScheduleRolloutData @return;

    public wsdlGetBaseScheduleRolledoutHoursResponse() { }

    public wsdlGetBaseScheduleRolledoutHoursResponse(baseScheduleRolloutData @return)
    {
        this.@return = @return;
    }
}
