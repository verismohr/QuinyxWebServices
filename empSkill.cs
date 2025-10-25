using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class empSkill
{
    private string skillDescriptionField;

    private string shiftTypeNameField;

    private int shiftTypeIdField;

    private int skillExpiresField;

    private DateTime skillExpiringDateField;

    private bool skillExpiringDateFieldSpecified;

    public string skillDescription
    {
        get { return skillDescriptionField; }
        set { skillDescriptionField = value; }
    }

    public string shiftTypeName
    {
        get { return shiftTypeNameField; }
        set { shiftTypeNameField = value; }
    }

    public int shiftTypeId
    {
        get { return shiftTypeIdField; }
        set { shiftTypeIdField = value; }
    }

    public int skillExpires
    {
        get { return skillExpiresField; }
        set { skillExpiresField = value; }
    }

    [SoapElement(DataType = "date")]
    public DateTime skillExpiringDate
    {
        get { return skillExpiringDateField; }
        set { skillExpiringDateField = value; }
    }

    [SoapIgnore]
    public bool skillExpiringDateSpecified
    {
        get { return skillExpiringDateFieldSpecified; }
        set { skillExpiringDateFieldSpecified = value; }
    }
}
