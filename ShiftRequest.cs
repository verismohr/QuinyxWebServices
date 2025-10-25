using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class ShiftRequest
{
    private int employeeIdField;

    private string badgeNoField;

    private int requestTypeField;

    private int swappedScheduleIdField;

    private bool fulfillsField;

    private DateTime tsField;

    public int employeeId
    {
        get { return employeeIdField; }
        set { employeeIdField = value; }
    }

    public string badgeNo
    {
        get { return badgeNoField; }
        set { badgeNoField = value; }
    }

    public int requestType
    {
        get { return requestTypeField; }
        set { requestTypeField = value; }
    }

    public int swappedScheduleId
    {
        get { return swappedScheduleIdField; }
        set { swappedScheduleIdField = value; }
    }

    public bool fulfills
    {
        get { return fulfillsField; }
        set { fulfillsField = value; }
    }

    public DateTime ts
    {
        get { return tsField; }
        set { tsField = value; }
    }
}
