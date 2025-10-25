using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class baseScheduleRolloutData
{
    private EmployeeRolloutHours[] employeesRolloutHoursField;

    private string[] validationErrorsField;

    public EmployeeRolloutHours[] employeesRolloutHours
    {
        get { return employeesRolloutHoursField; }
        set { employeesRolloutHoursField = value; }
    }

    public string[] validationErrors
    {
        get { return validationErrorsField; }
        set { validationErrorsField = value; }
    }
}
