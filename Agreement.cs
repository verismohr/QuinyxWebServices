using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class Agreement
{
    private int idField;

    private int persIdField;

    private string badgeNoField;

    private decimal weekHoursField;

    private decimal minHoursField;

    private decimal maxHoursField;

    private decimal salaryField;

    private decimal premiumSalaryField;

    private decimal premiumSalary2Field;

    private decimal premiumSalary3Field;

    private int periodTypeField;

    private int periodDayField;

    private DateTime periodStartField;

    private int periodLengthField;

    private decimal weeklyAvgField;

    private decimal empLevelField;

    private int templateIdField;

    private int hourlyField;

    private DateTime fromDateField;

    private DateTime toDateField;

    private int expiresField;

    private string commentField;

    private Vacation[] vacationsField;

    private string[] redDaysField;

    private OverTime[] overTime1Field;

    private OverTime[] overTime2Field;

    private OverTime[] overTime3Field;

    private Xtrawork[] xtraworkField;

    private Shift[] shiftsField;

    private DateTime tsField;

    private int restIdField;

    private string extAgreementIdField;

    private int roundingBreaksField;

    private bool roundingBreaksFieldSpecified;

    private punchRounding[] punchRoundingsField;

    private agreementOvertimeMethod[] agreementOvertimeMethodsField;

    private bool isMainAgreementField;

    private bool isMainAgreementFieldSpecified;

    private string additionalField1Field;

    private string additionalField2Field;

    private string additionalField3Field;

    private string additionalField4Field;

    private string additionalField5Field;

    private decimal monthlySalaryField;

    private bool monthlySalaryFieldSpecified;

    private decimal customMonthlyHoursDivisorField;

    private bool customMonthlyHoursDivisorFieldSpecified;

    private string nameField;

    public int id
    {
        get { return idField; }
        set { idField = value; }
    }

    public int persId
    {
        get { return persIdField; }
        set { persIdField = value; }
    }

    public string badgeNo
    {
        get { return badgeNoField; }
        set { badgeNoField = value; }
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

    public int templateId
    {
        get { return templateIdField; }
        set { templateIdField = value; }
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

    public Vacation[] vacations
    {
        get { return vacationsField; }
        set { vacationsField = value; }
    }

    public string[] redDays
    {
        get { return redDaysField; }
        set { redDaysField = value; }
    }

    public OverTime[] overTime1
    {
        get { return overTime1Field; }
        set { overTime1Field = value; }
    }

    public OverTime[] overTime2
    {
        get { return overTime2Field; }
        set { overTime2Field = value; }
    }

    public OverTime[] overTime3
    {
        get { return overTime3Field; }
        set { overTime3Field = value; }
    }

    public Xtrawork[] xtrawork
    {
        get { return xtraworkField; }
        set { xtraworkField = value; }
    }

    public Shift[] shifts
    {
        get { return shiftsField; }
        set { shiftsField = value; }
    }

    public DateTime ts
    {
        get { return tsField; }
        set { tsField = value; }
    }

    public int restId
    {
        get { return restIdField; }
        set { restIdField = value; }
    }

    public string extAgreementId
    {
        get { return extAgreementIdField; }
        set { extAgreementIdField = value; }
    }

    public int roundingBreaks
    {
        get { return roundingBreaksField; }
        set { roundingBreaksField = value; }
    }

    [SoapIgnore]
    public bool roundingBreaksSpecified
    {
        get { return roundingBreaksFieldSpecified; }
        set { roundingBreaksFieldSpecified = value; }
    }

    public punchRounding[] punchRoundings
    {
        get { return punchRoundingsField; }
        set { punchRoundingsField = value; }
    }

    public agreementOvertimeMethod[] agreementOvertimeMethods
    {
        get { return agreementOvertimeMethodsField; }
        set { agreementOvertimeMethodsField = value; }
    }

    public bool isMainAgreement
    {
        get { return isMainAgreementField; }
        set { isMainAgreementField = value; }
    }

    [SoapIgnore]
    public bool isMainAgreementSpecified
    {
        get { return isMainAgreementFieldSpecified; }
        set { isMainAgreementFieldSpecified = value; }
    }

    public string additionalField1
    {
        get { return additionalField1Field; }
        set { additionalField1Field = value; }
    }

    public string additionalField2
    {
        get { return additionalField2Field; }
        set { additionalField2Field = value; }
    }

    public string additionalField3
    {
        get { return additionalField3Field; }
        set { additionalField3Field = value; }
    }

    public string additionalField4
    {
        get { return additionalField4Field; }
        set { additionalField4Field = value; }
    }

    public string additionalField5
    {
        get { return additionalField5Field; }
        set { additionalField5Field = value; }
    }

    public decimal monthlySalary
    {
        get { return monthlySalaryField; }
        set { monthlySalaryField = value; }
    }

    [SoapIgnore]
    public bool monthlySalarySpecified
    {
        get { return monthlySalaryFieldSpecified; }
        set { monthlySalaryFieldSpecified = value; }
    }

    public decimal customMonthlyHoursDivisor
    {
        get { return customMonthlyHoursDivisorField; }
        set { customMonthlyHoursDivisorField = value; }
    }

    [SoapIgnore]
    public bool customMonthlyHoursDivisorSpecified
    {
        get { return customMonthlyHoursDivisorFieldSpecified; }
        set { customMonthlyHoursDivisorFieldSpecified = value; }
    }

    public string name
    {
        get { return nameField; }
        set { nameField = value; }
    }
}
