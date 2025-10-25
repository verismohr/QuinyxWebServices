using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class OverTime
{
    private int startPeriod1Field;

    private int endPeriod1Field;

    private int startPeriod2Field;

    private int endPeriod2Field;

    public int startPeriod1
    {
        get { return startPeriod1Field; }
        set { startPeriod1Field = value; }
    }

    public int endPeriod1
    {
        get { return endPeriod1Field; }
        set { endPeriod1Field = value; }
    }

    public int startPeriod2
    {
        get { return startPeriod2Field; }
        set { startPeriod2Field = value; }
    }

    public int endPeriod2
    {
        get { return endPeriod2Field; }
        set { endPeriod2Field = value; }
    }
}
