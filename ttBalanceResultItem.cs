using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class ttBalanceResultItem
{
    private int userIdField;

    private string badgeNoField;

    private int timeTrackerIdField;

    private int periodField;

    private bool periodFieldSpecified;

    private decimal balanceField;

    private string dateField;

    private string[] validationErrorsField;

    public int userId
    {
        get { return userIdField; }
        set { userIdField = value; }
    }

    public string badgeNo
    {
        get { return badgeNoField; }
        set { badgeNoField = value; }
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

    public decimal balance
    {
        get { return balanceField; }
        set { balanceField = value; }
    }

    public string date
    {
        get { return dateField; }
        set { dateField = value; }
    }

    public string[] validationErrors
    {
        get { return validationErrorsField; }
        set { validationErrorsField = value; }
    }
}
