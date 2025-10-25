using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class AgreementTemplate
{
    private int idField;

    private string templateNameField;

    private decimal weekHoursField;

    private decimal minHoursField;

    private decimal maxHoursField;

    private decimal salaryField;

    private decimal premiumSalaryField;

    private decimal premiumSalary2Field;

    private decimal premiumSalary3Field;

    private int hourlyField;

    private DateTime fromDateField;

    private DateTime toDateField;

    private int expiresField;

    private string commentField;

    private int periodTypeField;

    private int periodDayField;

    private DateTime periodStartField;

    private int periodLengthField;

    private decimal weeklyAvgField;

    private decimal empLevelField;

    private int stdRedDaysField;

    private int stdOverTimeField;

    private int maxHourDayField;

    private int maxHourWeekField;

    private int minShiftField;

    private int minRestField;

    private TemplateShift[] shiftsField;

    private TemplateRedDay[] redDaysField;

    private TemplateOverTime[] overTimeField;

    private DateTime tsField;

    public int id
    {
        get { return idField; }
        set { idField = value; }
    }

    public string templateName
    {
        get { return templateNameField; }
        set { templateNameField = value; }
    }

    public decimal weekHours
    {
        get { return weekHoursField; }
        set { weekHoursField = value; }
    }

    public decimal minHours
    {
        get { return minHoursField; }
        set { minHoursField = value; }
    }

    public decimal maxHours
    {
        get { return maxHoursField; }
        set { maxHoursField = value; }
    }

    public decimal salary
    {
        get { return salaryField; }
        set { salaryField = value; }
    }

    public decimal premiumSalary
    {
        get { return premiumSalaryField; }
        set { premiumSalaryField = value; }
    }

    public decimal premiumSalary2
    {
        get { return premiumSalary2Field; }
        set { premiumSalary2Field = value; }
    }

    public decimal premiumSalary3
    {
        get { return premiumSalary3Field; }
        set { premiumSalary3Field = value; }
    }

    public int hourly
    {
        get { return hourlyField; }
        set { hourlyField = value; }
    }

    [SoapElement(DataType = "date")]
    public DateTime fromDate
    {
        get { return fromDateField; }
        set { fromDateField = value; }
    }

    [SoapElement(DataType = "date")]
    public DateTime toDate
    {
        get { return toDateField; }
        set { toDateField = value; }
    }

    public int expires
    {
        get { return expiresField; }
        set { expiresField = value; }
    }

    public string comment
    {
        get { return commentField; }
        set { commentField = value; }
    }

    public int periodType
    {
        get { return periodTypeField; }
        set { periodTypeField = value; }
    }

    public int periodDay
    {
        get { return periodDayField; }
        set { periodDayField = value; }
    }

    [SoapElement(DataType = "date")]
    public DateTime periodStart
    {
        get { return periodStartField; }
        set { periodStartField = value; }
    }

    public int periodLength
    {
        get { return periodLengthField; }
        set { periodLengthField = value; }
    }

    public decimal weeklyAvg
    {
        get { return weeklyAvgField; }
        set { weeklyAvgField = value; }
    }

    public decimal empLevel
    {
        get { return empLevelField; }
        set { empLevelField = value; }
    }

    public int stdRedDays
    {
        get { return stdRedDaysField; }
        set { stdRedDaysField = value; }
    }

    public int stdOverTime
    {
        get { return stdOverTimeField; }
        set { stdOverTimeField = value; }
    }

    public int maxHourDay
    {
        get { return maxHourDayField; }
        set { maxHourDayField = value; }
    }

    public int maxHourWeek
    {
        get { return maxHourWeekField; }
        set { maxHourWeekField = value; }
    }

    public int minShift
    {
        get { return minShiftField; }
        set { minShiftField = value; }
    }

    public int minRest
    {
        get { return minRestField; }
        set { minRestField = value; }
    }

    public TemplateShift[] shifts
    {
        get { return shiftsField; }
        set { shiftsField = value; }
    }

    public TemplateRedDay[] redDays
    {
        get { return redDaysField; }
        set { redDaysField = value; }
    }

    public TemplateOverTime[] overTime
    {
        get { return overTimeField; }
        set { overTimeField = value; }
    }

    public DateTime ts
    {
        get { return tsField; }
        set { tsField = value; }
    }
}
