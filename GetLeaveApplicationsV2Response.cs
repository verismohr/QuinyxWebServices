using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class GetLeaveApplicationsV2Response
{
    private LeaveApplicationV2[] leaveApplicationsField;

    private string[] validationErrorsField;

    public LeaveApplicationV2[] leaveApplications
    {
        get { return leaveApplicationsField; }
        set { leaveApplicationsField = value; }
    }

    public string[] validationErrors
    {
        get { return validationErrorsField; }
        set { validationErrorsField = value; }
    }
}
