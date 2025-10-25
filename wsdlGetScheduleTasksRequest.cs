using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(
    WrapperName = "wsdlGetScheduleTasks",
    WrapperNamespace = "uri:FlexForce",
    IsWrapped = true
)]
public class wsdlGetScheduleTasksRequest
{
    [MessageBodyMember(Namespace = "", Order = 0)]
    public string apiKey;

    [MessageBodyMember(Namespace = "", Order = 1)]
    public int scheduleId;

    [MessageBodyMember(Namespace = "", Order = 2)]
    public int categoryId;

    [MessageBodyMember(Namespace = "", Order = 3)]
    public string begTime;

    [MessageBodyMember(Namespace = "", Order = 4)]
    public string endTime;

    [MessageBodyMember(Namespace = "", Order = 5)]
    public string lastModified;

    public wsdlGetScheduleTasksRequest() { }

    public wsdlGetScheduleTasksRequest(
        string apiKey,
        int scheduleId,
        int categoryId,
        string begTime,
        string endTime,
        string lastModified
    )
    {
        this.apiKey = apiKey;
        this.scheduleId = scheduleId;
        this.categoryId = categoryId;
        this.begTime = begTime;
        this.endTime = endTime;
        this.lastModified = lastModified;
    }
}
