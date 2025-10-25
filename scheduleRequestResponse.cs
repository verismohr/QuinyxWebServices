using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class scheduleRequestResponse
{
    private int scheduleIdField;

    private int employeeIdField;

    private bool employeeIdFieldSpecified;

    private string badgeNoField;

    private string commentField;

    private string[] validationErrorsField;

    public int scheduleId
    {
        get { return scheduleIdField; }
        set { scheduleIdField = value; }
    }

    public int employeeId
    {
        get { return employeeIdField; }
        set { employeeIdField = value; }
    }

    [SoapIgnore]
    public bool employeeIdSpecified
    {
        get { return employeeIdFieldSpecified; }
        set { employeeIdFieldSpecified = value; }
    }

    public string badgeNo
    {
        get { return badgeNoField; }
        set { badgeNoField = value; }
    }

    public string comment
    {
        get { return commentField; }
        set { commentField = value; }
    }

    public string[] validationErrors
    {
        get { return validationErrorsField; }
        set { validationErrorsField = value; }
    }
}
