using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class reverseInfo
{
    private DateTime startDateField;

    private DateTime endDateField;

    private string[] badgeNosField;

    private bool unLockSchedulePeriodField;

    private bool unLockSchedulePeriodFieldSpecified;

    private string[] validationErrorsField;

    [SoapElement(DataType = "date")]
    public DateTime startDate
    {
        get { return startDateField; }
        set { startDateField = value; }
    }

    [SoapElement(DataType = "date")]
    public DateTime endDate
    {
        get { return endDateField; }
        set { endDateField = value; }
    }

    public string[] badgeNos
    {
        get { return badgeNosField; }
        set { badgeNosField = value; }
    }

    public bool unLockSchedulePeriod
    {
        get { return unLockSchedulePeriodField; }
        set { unLockSchedulePeriodField = value; }
    }

    [SoapIgnore]
    public bool unLockSchedulePeriodSpecified
    {
        get { return unLockSchedulePeriodFieldSpecified; }
        set { unLockSchedulePeriodFieldSpecified = value; }
    }

    public string[] validationErrors
    {
        get { return validationErrorsField; }
        set { validationErrorsField = value; }
    }
}
