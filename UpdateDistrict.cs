using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class UpdateDistrict
{
    private int idField;

    private int groupIdField;

    private bool groupIdFieldSpecified;

    private string extGroupIdField;

    private string nameField;

    private int? managerIdField;

    private bool managerIdFieldSpecified;

    private string managerBadgeNoField;

    private string[] validationErrorsField;

    public int id
    {
        get { return idField; }
        set { idField = value; }
    }

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

    public string extGroupId
    {
        get { return extGroupIdField; }
        set { extGroupIdField = value; }
    }

    public string name
    {
        get { return nameField; }
        set { nameField = value; }
    }

    [SoapElement(IsNullable = true)]
    public int? managerId
    {
        get { return managerIdField; }
        set { managerIdField = value; }
    }

    [SoapIgnore]
    public bool managerIdSpecified
    {
        get { return managerIdFieldSpecified; }
        set { managerIdFieldSpecified = value; }
    }

    public string managerBadgeNo
    {
        get { return managerBadgeNoField; }
        set { managerBadgeNoField = value; }
    }

    public string[] validationErrors
    {
        get { return validationErrorsField; }
        set { validationErrorsField = value; }
    }
}
