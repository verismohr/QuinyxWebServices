using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class OvertimePeriod
{
    private int weekDayField;

    private string overtimeFromField;

    private string overtimeToField;

    private int oTypeField;

    private int altWeekDayField;

    public int weekDay
    {
        get { return weekDayField; }
        set { weekDayField = value; }
    }

    public string overtimeFrom
    {
        get { return overtimeFromField; }
        set { overtimeFromField = value; }
    }

    public string overtimeTo
    {
        get { return overtimeToField; }
        set { overtimeToField = value; }
    }

    public int oType
    {
        get { return oTypeField; }
        set { oTypeField = value; }
    }

    public int altWeekDay
    {
        get { return altWeekDayField; }
        set { altWeekDayField = value; }
    }
}
