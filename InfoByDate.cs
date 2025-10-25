using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class InfoByDate
{
    private string dateField;

    private EmployeeBadgeNo employeeBadgeNoField;

    public string date
    {
        get { return dateField; }
        set { dateField = value; }
    }

    public EmployeeBadgeNo EmployeeBadgeNo
    {
        get { return employeeBadgeNoField; }
        set { employeeBadgeNoField = value; }
    }
}
