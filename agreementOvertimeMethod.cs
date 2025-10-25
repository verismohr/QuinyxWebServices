using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class agreementOvertimeMethod
{
    private int overtimeMethodIdField;

    private int orderField;

    private bool orderFieldSpecified;

    public int overtimeMethodId
    {
        get { return overtimeMethodIdField; }
        set { overtimeMethodIdField = value; }
    }

    public int order
    {
        get { return orderField; }
        set { orderField = value; }
    }

    [SoapIgnore]
    public bool orderSpecified
    {
        get { return orderFieldSpecified; }
        set { orderFieldSpecified = value; }
    }
}
