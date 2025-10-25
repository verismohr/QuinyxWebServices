using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class timeTrackerListItem
{
    private int userIdField;

    private int timeTrackerIdField;

    private string timeTrackerNameField;

    private string[] validationErrorsField;

    public int userId
    {
        get { return userIdField; }
        set { userIdField = value; }
    }

    public int timeTrackerId
    {
        get { return timeTrackerIdField; }
        set { timeTrackerIdField = value; }
    }

    public string timeTrackerName
    {
        get { return timeTrackerNameField; }
        set { timeTrackerNameField = value; }
    }

    public string[] validationErrors
    {
        get { return validationErrorsField; }
        set { validationErrorsField = value; }
    }
}
