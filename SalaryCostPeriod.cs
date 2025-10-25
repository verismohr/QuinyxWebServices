using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class SalaryCostPeriod
{
    private DateTime fromDateField;

    private int periodTypeField;

    private int periodLengthField;

    [SoapElement(DataType = "date")]
    public DateTime fromDate
    {
        get { return fromDateField; }
        set { fromDateField = value; }
    }

    public int periodType
    {
        get { return periodTypeField; }
        set { periodTypeField = value; }
    }

    public int periodLength
    {
        get { return periodLengthField; }
        set { periodLengthField = value; }
    }
}
