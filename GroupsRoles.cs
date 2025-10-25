using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class GroupsRoles
{
    private int groupIdField;

    private bool groupIdFieldSpecified;

    private string groupNameField;

    private string extGroupIdField;

    private string roleIdField;

    private string extNeoRoleIdField;

    private string roleNameField;

    private DateTime startDateField;

    private bool startDateFieldSpecified;

    private DateTime endDateField;

    private bool endDateFieldSpecified;

    public int groupId
    {
        get { return groupIdField; }
        set { groupIdField = value; }
    }

    [SoapIgnore]
    public bool groupIdSpecified
    {
        get { return groupIdFieldSpecified; }
        set { groupIdFieldSpecified = value; }
    }

    public string groupName
    {
        get { return groupNameField; }
        set { groupNameField = value; }
    }

    public string extGroupId
    {
        get { return extGroupIdField; }
        set { extGroupIdField = value; }
    }

    public string roleId
    {
        get { return roleIdField; }
        set { roleIdField = value; }
    }

    public string extNeoRoleId
    {
        get { return extNeoRoleIdField; }
        set { extNeoRoleIdField = value; }
    }

    public string roleName
    {
        get { return roleNameField; }
        set { roleNameField = value; }
    }

    [SoapElement(DataType = "date")]
    public DateTime startDate
    {
        get { return startDateField; }
        set { startDateField = value; }
    }

    [SoapIgnore]
    public bool startDateSpecified
    {
        get { return startDateFieldSpecified; }
        set { startDateFieldSpecified = value; }
    }

    [SoapElement(DataType = "date")]
    public DateTime endDate
    {
        get { return endDateField; }
        set { endDateField = value; }
    }

    [SoapIgnore]
    public bool endDateSpecified
    {
        get { return endDateFieldSpecified; }
        set { endDateFieldSpecified = value; }
    }
}
