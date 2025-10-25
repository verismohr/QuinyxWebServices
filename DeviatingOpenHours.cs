using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class DeviatingOpenHours
{
    private string timeStartField;

    private string timeEndField;

    private string dateField;

    public string timeStart
    {
        get { return timeStartField; }
        set { timeStartField = value; }
    }

    public string timeEnd
    {
        get { return timeEndField; }
        set { timeEndField = value; }
    }

    public string date
    {
        get { return dateField; }
        set { dateField = value; }
    }
}
