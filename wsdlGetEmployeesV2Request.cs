using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(
    WrapperName = "wsdlGetEmployeesV2",
    WrapperNamespace = "uri:FlexForce",
    IsWrapped = true
)]
public class wsdlGetEmployeesV2Request
{
    [MessageBodyMember(Namespace = "", Order = 0)]
    public string apiKey;

    [MessageBodyMember(Namespace = "", Order = 1)]
    public int sectionId;

    [MessageBodyMember(Namespace = "", Order = 2)]
    public int employeeId;

    [MessageBodyMember(Namespace = "", Order = 3)]
    public string badgeNo;

    [MessageBodyMember(Namespace = "", Order = 4)]
    public string lastModified;

    [MessageBodyMember(Namespace = "", Order = 5)]
    public bool includeNeoRoles;

    [MessageBodyMember(Namespace = "", Order = 6)]
    public int[] neoRolesIds;

    [MessageBodyMember(Namespace = "", Order = 7)]
    public string[] neoExtRolesIds;

    public wsdlGetEmployeesV2Request() { }

    public wsdlGetEmployeesV2Request(
        string apiKey,
        int sectionId,
        int employeeId,
        string badgeNo,
        string lastModified,
        bool includeNeoRoles,
        int[] neoRolesIds,
        string[] neoExtRolesIds
    )
    {
        this.apiKey = apiKey;
        this.sectionId = sectionId;
        this.employeeId = employeeId;
        this.badgeNo = badgeNo;
        this.lastModified = lastModified;
        this.includeNeoRoles = includeNeoRoles;
        this.neoRolesIds = neoRolesIds;
        this.neoExtRolesIds = neoExtRolesIds;
    }
}
