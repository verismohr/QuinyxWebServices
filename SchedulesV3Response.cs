using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class SchedulesV3Response
{
    private ScheduleV3[] schedulesField;

    private string[] validationErrorsField;

    public ScheduleV3[] schedules
    {
        get { return schedulesField; }
        set { schedulesField = value; }
    }

    public string[] validationErrors
    {
        get { return validationErrorsField; }
        set { validationErrorsField = value; }
    }
}
