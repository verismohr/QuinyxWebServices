using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class updateManualSalary
{
    private string salaryCodeField;

    private decimal hoursField;

    private string operatorField;

    private int timepunchIdField;

    private bool timepunchIdFieldSpecified;

    private string punchDateTimeField;

    private int employeeIdField;

    private bool employeeIdFieldSpecified;

    private string badgeNoField;

    private bool overridevalidationsField;

    private bool overridevalidationsFieldSpecified;

    private string[] validationErrorsField;

    public string salaryCode
    {
        get { return salaryCodeField; }
        set { salaryCodeField = value; }
    }

    public decimal hours
    {
        get { return hoursField; }
        set { hoursField = value; }
    }

    public string @operator
    {
        get { return operatorField; }
        set { operatorField = value; }
    }

    public int timepunchId
    {
        get { return timepunchIdField; }
        set { timepunchIdField = value; }
    }

    [SoapIgnore]
    public bool timepunchIdSpecified
    {
        get { return timepunchIdFieldSpecified; }
        set { timepunchIdFieldSpecified = value; }
    }

    public string punchDateTime
    {
        get { return punchDateTimeField; }
        set { punchDateTimeField = value; }
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

    public bool overridevalidations
    {
        get { return overridevalidationsField; }
        set { overridevalidationsField = value; }
    }

    [SoapIgnore]
    public bool overridevalidationsSpecified
    {
        get { return overridevalidationsFieldSpecified; }
        set { overridevalidationsFieldSpecified = value; }
    }

    public string[] validationErrors
    {
        get { return validationErrorsField; }
        set { validationErrorsField = value; }
    }
}
