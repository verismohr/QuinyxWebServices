using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(
    WrapperName = "wsdlGetEmployeeGroups",
    WrapperNamespace = "uri:FlexForce",
    IsWrapped = true
)]
public class wsdlGetEmployeeGroupsRequest
{
    [MessageBodyMember(Namespace = "", Order = 0)]
    public string apiKey;

    [MessageBodyMember(Namespace = "", Order = 1)]
    public int groupId;

    [MessageBodyMember(Namespace = "", Order = 2)]
    public bool sharedGroups;

    [MessageBodyMember(Namespace = "", Order = 3)]
    public string lastModified;

    public wsdlGetEmployeeGroupsRequest() { }

    public wsdlGetEmployeeGroupsRequest(
        string apiKey,
        int groupId,
        bool sharedGroups,
        string lastModified
    )
    {
        this.apiKey = apiKey;
        this.groupId = groupId;
        this.sharedGroups = sharedGroups;
        this.lastModified = lastModified;
    }
}
