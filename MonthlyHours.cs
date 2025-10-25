using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class MonthlyHours
{
    private int yearField;

    private int monthField;

    private decimal hoursField;

    public int year
    {
        get { return yearField; }
        set { yearField = value; }
    }

    public int month
    {
        get { return monthField; }
        set { monthField = value; }
    }

    public decimal hours
    {
        get { return hoursField; }
        set { hoursField = value; }
    }
}
