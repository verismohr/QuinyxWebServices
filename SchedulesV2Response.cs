using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class SchedulesV2Response
{
    private ScheduleV2[] schedulesField;

    private string[] validationErrorsField;

    public ScheduleV2[] schedules
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
