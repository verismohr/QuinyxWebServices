using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(
    WrapperName = "wsdlGetEmployeeSkills",
    WrapperNamespace = "uri:FlexForce",
    IsWrapped = true
)]
public class wsdlGetEmployeeSkillsRequest
{
    [MessageBodyMember(Namespace = "", Order = 0)]
    public string apiKey;

    [MessageBodyMember(Namespace = "", Order = 1)]
    public int employeeId;

    [MessageBodyMember(Namespace = "", Order = 2)]
    public string employeeBadgeNo;

    [MessageBodyMember(Namespace = "", Order = 3)]
    public int employeeGroupId;

    [MessageBodyMember(Namespace = "", Order = 4)]
    public int employeeSectionId;

    [MessageBodyMember(Namespace = "", Order = 5)]
    public int skillCategoryId;

    public wsdlGetEmployeeSkillsRequest() { }

    public wsdlGetEmployeeSkillsRequest(
        string apiKey,
        int employeeId,
        string employeeBadgeNo,
        int employeeGroupId,
        int employeeSectionId,
        int skillCategoryId
    )
    {
        this.apiKey = apiKey;
        this.employeeId = employeeId;
        this.employeeBadgeNo = employeeBadgeNo;
        this.employeeGroupId = employeeGroupId;
        this.employeeSectionId = employeeSectionId;
        this.skillCategoryId = skillCategoryId;
    }
}
