using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class GetTimePunchesResponse
{
    private TimePunch[] timepunchesField;

    private string[] validationErrorsField;

    public TimePunch[] timepunches
    {
        get { return timepunchesField; }
        set { timepunchesField = value; }
    }

    public string[] validationErrors
    {
        get { return validationErrorsField; }
        set { validationErrorsField = value; }
    }
}
