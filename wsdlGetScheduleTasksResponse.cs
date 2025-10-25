using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(
    WrapperName = "wsdlGetScheduleTasksResponse",
    WrapperNamespace = "uri:FlexForce",
    IsWrapped = true
)]
public class wsdlGetScheduleTasksResponse
{
    [MessageBodyMember(Namespace = "", Order = 0)]
    public ScheduleTask[] @return;

    public wsdlGetScheduleTasksResponse() { }

    public wsdlGetScheduleTasksResponse(ScheduleTask[] @return)
    {
        this.@return = @return;
    }
}
