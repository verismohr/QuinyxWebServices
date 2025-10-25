using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class UpdateAgreement
{
    private int idField;

    private bool idFieldSpecified;

    private string extAgreementIdField;

    private string nameField;

    private string badgeNoField;

    private int restIdField;

    private decimal weekHoursField;

    private decimal minHoursField;

    private decimal maxHoursField;

    private decimal salaryField;

    private decimal monthlySalaryField;

    private decimal hourlySalaryField;

    private decimal premiumSalaryField;

    private decimal premiumSalary2Field;

    private decimal premiumSalary3Field;

    private int hourlyField;

    private DateTime fromDateField;

    private DateTime toDateField;

    private int expiresField;

    private int periodTypeField;

    private DateTime periodStartField;

    private int periodLengthField;

    private decimal weeklyAvgField;

    private decimal empLevelField;

    private int templateIdField;

    private int useTempAvailField;

    private int useTempTimeRulesField;

    private int useTempSalaryField;

    private int useTempWorkTimeField;

    private int useTempMonthHoursField;

    private int useTempRedDatesField;

    private int useTempTandAField;

    private int overtimeMethodField;

    private string additionalField1Field;

    private string additionalField2Field;

    private string additionalField3Field;

    private string additionalField4Field;

    private string additionalField5Field;

    private int closeParallelAgreementsField;

    private int useObjectAgreementField;

    private int useTempCostsField;

    private int roundingBreaksField;

    private bool roundingBreaksFieldSpecified;

    private punchRounding[] punchRoundingsField;

    private agreementOvertimeMethod[] agreementOvertimeMethodsField;

    private bool isMainAgreementField;

    private bool isMainAgreementFieldSpecified;

    private bool showUnspecifiedLeaveInWPField;

    private bool showUnspecifiedLeaveInWPFieldSpecified;

    private decimal customMonthlyHoursDivisorField;

    private bool customMonthlyHoursDivisorFieldSpecified;

    private string[] validationErrorsField;

    public int id
    {
        get { return idField; }
        set { idField = value; }
    }

    [SoapIgnore]
    public bool idSpecified
    {
        get { return idFieldSpecified; }
        set { idFieldSpecified = value; }
    }

    public string extAgreementId
    {
        get { return extAgreementIdField; }
        set { extAgreementIdField = value; }
    }

    public string name
    {
        get { return nameField; }
        set { nameField = value; }
    }

    public string badgeNo
    {
        get { return badgeNoField; }
        set { badgeNoField = value; }
    }

    public int restId
    {
        get { return restIdField; }
        set { restIdField = value; }
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

    public decimal monthlySalary
    {
        get { return monthlySalaryField; }
        set { monthlySalaryField = value; }
    }

    public decimal hourlySalary
    {
        get { return hourlySalaryField; }
        set { hourlySalaryField = value; }
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

    public int periodType
    {
        get { return periodTypeField; }
        set { periodTypeField = value; }
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

    public int useTempAvail
    {
        get { return useTempAvailField; }
        set { useTempAvailField = value; }
    }

    public int useTempTimeRules
    {
        get { return useTempTimeRulesField; }
        set { useTempTimeRulesField = value; }
    }

    public int useTempSalary
    {
        get { return useTempSalaryField; }
        set { useTempSalaryField = value; }
    }

    public int useTempWorkTime
    {
        get { return useTempWorkTimeField; }
        set { useTempWorkTimeField = value; }
    }

    public int useTempMonthHours
    {
        get { return useTempMonthHoursField; }
        set { useTempMonthHoursField = value; }
    }

    public int useTempRedDates
    {
        get { return useTempRedDatesField; }
        set { useTempRedDatesField = value; }
    }

    public int useTempTandA
    {
        get { return useTempTandAField; }
        set { useTempTandAField = value; }
    }

    public int overtimeMethod
    {
        get { return overtimeMethodField; }
        set { overtimeMethodField = value; }
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

    public int closeParallelAgreements
    {
        get { return closeParallelAgreementsField; }
        set { closeParallelAgreementsField = value; }
    }

    public int useObjectAgreement
    {
        get { return useObjectAgreementField; }
        set { useObjectAgreementField = value; }
    }

    public int useTempCosts
    {
        get { return useTempCostsField; }
        set { useTempCostsField = value; }
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

    public bool showUnspecifiedLeaveInWP
    {
        get { return showUnspecifiedLeaveInWPField; }
        set { showUnspecifiedLeaveInWPField = value; }
    }

    [SoapIgnore]
    public bool showUnspecifiedLeaveInWPSpecified
    {
        get { return showUnspecifiedLeaveInWPFieldSpecified; }
        set { showUnspecifiedLeaveInWPFieldSpecified = value; }
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

    public string[] validationErrors
    {
        get { return validationErrorsField; }
        set { validationErrorsField = value; }
    }
}
