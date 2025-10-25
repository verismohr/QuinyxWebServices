using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class GetSchedulesV3
{
    private string sectionField;

    private string badgeNoField;

    private int employeeIdField;

    private bool employeeIdFieldSpecified;

    private string fromDateField;

    private string fromTimeField;

    private string toDateField;

    private string toTimeField;

    private bool scheduledShiftsField;

    private bool scheduledShiftsFieldSpecified;

    private bool absenceShiftsField;

    private bool absenceShiftsFieldSpecified;

    private string modifiedAfterField;

    private string modifiedBeforeField;

    private bool includeCostsField;

    private bool includeCostsFieldSpecified;

    private bool useFixedScheduleField;

    private bool useFixedScheduleFieldSpecified;

    private bool includeNOIField;

    private bool includeNOIFieldSpecified;

    private bool includeTagsField;

    private bool includeTagsFieldSpecified;

    private bool includeExtScheduleIdField;

    private bool includeExtScheduleIdFieldSpecified;

    public string section
    {
        get { return sectionField; }
        set { sectionField = value; }
    }

    public string badgeNo
    {
        get { return badgeNoField; }
        set { badgeNoField = value; }
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

    public string fromDate
    {
        get { return fromDateField; }
        set { fromDateField = value; }
    }

    public string fromTime
    {
        get { return fromTimeField; }
        set { fromTimeField = value; }
    }

    public string toDate
    {
        get { return toDateField; }
        set { toDateField = value; }
    }

    public string toTime
    {
        get { return toTimeField; }
        set { toTimeField = value; }
    }

    public bool scheduledShifts
    {
        get { return scheduledShiftsField; }
        set { scheduledShiftsField = value; }
    }

    [SoapIgnore]
    public bool scheduledShiftsSpecified
    {
        get { return scheduledShiftsFieldSpecified; }
        set { scheduledShiftsFieldSpecified = value; }
    }

    public bool absenceShifts
    {
        get { return absenceShiftsField; }
        set { absenceShiftsField = value; }
    }

    [SoapIgnore]
    public bool absenceShiftsSpecified
    {
        get { return absenceShiftsFieldSpecified; }
        set { absenceShiftsFieldSpecified = value; }
    }

    public string modifiedAfter
    {
        get { return modifiedAfterField; }
        set { modifiedAfterField = value; }
    }

    public string modifiedBefore
    {
        get { return modifiedBeforeField; }
        set { modifiedBeforeField = value; }
    }

    public bool includeCosts
    {
        get { return includeCostsField; }
        set { includeCostsField = value; }
    }

    [SoapIgnore]
    public bool includeCostsSpecified
    {
        get { return includeCostsFieldSpecified; }
        set { includeCostsFieldSpecified = value; }
    }

    public bool useFixedSchedule
    {
        get { return useFixedScheduleField; }
        set { useFixedScheduleField = value; }
    }

    [SoapIgnore]
    public bool useFixedScheduleSpecified
    {
        get { return useFixedScheduleFieldSpecified; }
        set { useFixedScheduleFieldSpecified = value; }
    }

    public bool includeNOI
    {
        get { return includeNOIField; }
        set { includeNOIField = value; }
    }

    [SoapIgnore]
    public bool includeNOISpecified
    {
        get { return includeNOIFieldSpecified; }
        set { includeNOIFieldSpecified = value; }
    }

    public bool includeTags
    {
        get { return includeTagsField; }
        set { includeTagsField = value; }
    }

    [SoapIgnore]
    public bool includeTagsSpecified
    {
        get { return includeTagsFieldSpecified; }
        set { includeTagsFieldSpecified = value; }
    }

    public bool includeExtScheduleId
    {
        get { return includeExtScheduleIdField; }
        set { includeExtScheduleIdField = value; }
    }

    [SoapIgnore]
    public bool includeExtScheduleIdSpecified
    {
        get { return includeExtScheduleIdFieldSpecified; }
        set { includeExtScheduleIdFieldSpecified = value; }
    }
}
