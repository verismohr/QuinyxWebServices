using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class baseScheduleRollout
{
    private badgeNo[] badgeNosField;

    private DateTime fromDateTimeField;

    private DateTime toDateTimeField;

    public badgeNo[] badgeNos
    {
        get { return badgeNosField; }
        set { badgeNosField = value; }
    }

    public DateTime fromDateTime
    {
        get { return fromDateTimeField; }
        set { fromDateTimeField = value; }
    }

    public DateTime toDateTime
    {
        get { return toDateTimeField; }
        set { toDateTimeField = value; }
    }
}
