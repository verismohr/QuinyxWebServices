using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class Task
{
    private string shiftTypeExtCodeField;

    private int shiftTypeIdField;

    private bool shiftTypeIdFieldSpecified;

    private string begTimeField;

    private string endTimeField;

    public string shiftTypeExtCode
    {
        get { return shiftTypeExtCodeField; }
        set { shiftTypeExtCodeField = value; }
    }

    public int shiftTypeId
    {
        get { return shiftTypeIdField; }
        set { shiftTypeIdField = value; }
    }

    [SoapIgnore]
    public bool shiftTypeIdSpecified
    {
        get { return shiftTypeIdFieldSpecified; }
        set { shiftTypeIdFieldSpecified = value; }
    }

    public string begTime
    {
        get { return begTimeField; }
        set { begTimeField = value; }
    }

    public string endTime
    {
        get { return endTimeField; }
        set { endTimeField = value; }
    }
}
