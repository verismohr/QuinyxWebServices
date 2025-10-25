using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class MinShiftLength
{
    private string fromTimeField;

    private string toTimeField;

    private decimal lengthField;

    public string fromTime
    {
        get { return fromTimeField; }
        set { fromTimeField = value; }
    }

    public string toTime
    {
        get { return toTimeField; }
        set { toTimeField = value; }
    }

    public decimal length
    {
        get { return lengthField; }
        set { lengthField = value; }
    }
}
