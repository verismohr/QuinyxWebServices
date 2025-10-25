using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class ttBalanceItem
{
    private string badgeNoField;

    private int userIdField;

    private int timeTrackerIdField;

    private int periodField;

    private bool periodFieldSpecified;

    private string dateField;

    public string badgeNo
    {
        get { return badgeNoField; }
        set { badgeNoField = value; }
    }

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

    public int period
    {
        get { return periodField; }
        set { periodField = value; }
    }

    [SoapIgnore]
    public bool periodSpecified
    {
        get { return periodFieldSpecified; }
        set { periodFieldSpecified = value; }
    }

    public string date
    {
        get { return dateField; }
        set { dateField = value; }
    }
}
