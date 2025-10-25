using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class EmployeeBadgeNo
{
    private string badgeNoField;

    public string badgeNo
    {
        get { return badgeNoField; }
        set { badgeNoField = value; }
    }
}
