using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class employeeSkill
{
    private string unitNameField;

    private string employeeBadgeNoField;

    private string employeeFirstNameField;

    private string employeeFamilyNameField;

    private empSkill[] skillsField;

    public string unitName
    {
        get { return unitNameField; }
        set { unitNameField = value; }
    }

    public string employeeBadgeNo
    {
        get { return employeeBadgeNoField; }
        set { employeeBadgeNoField = value; }
    }

    public string employeeFirstName
    {
        get { return employeeFirstNameField; }
        set { employeeFirstNameField = value; }
    }

    public string employeeFamilyName
    {
        get { return employeeFamilyNameField; }
        set { employeeFamilyNameField = value; }
    }

    public empSkill[] skills
    {
        get { return skillsField; }
        set { skillsField = value; }
    }
}
