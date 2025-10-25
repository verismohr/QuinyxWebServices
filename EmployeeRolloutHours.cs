using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class EmployeeRolloutHours
{
    private string badgeNoField;

    private decimal hoursField;

    public string badgeNo
    {
        get { return badgeNoField; }
        set { badgeNoField = value; }
    }

    public decimal hours
    {
        get { return hoursField; }
        set { hoursField = value; }
    }
}
