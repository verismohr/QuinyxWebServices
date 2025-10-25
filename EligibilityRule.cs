using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class EligibilityRule
{
    private int idField;

    private bool idFieldSpecified;

    private string nameField;

    private int employeeConditionField;

    private int employeeConditionAmountField;

    private int employeePeriodTypeField;

    private int periodConditionAmountField;

    private int periodConditionTypeField;

    private bool countAbsencesField;

    private string allowedAbsencesField;

    private bool overrideCountAsWorkedHoursField;

    private bool overrideCountAsWorkedHoursFieldSpecified;

    private bool virtualShiftsAsWorkedTimeDayField;

    private bool virtualShiftsAsWorkedTimeDayFieldSpecified;

    private bool ignoreOvertimeShiftsField;

    private bool ignoreOvertimeShiftsFieldSpecified;

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

    public string name
    {
        get { return nameField; }
        set { nameField = value; }
    }

    public int employeeCondition
    {
        get { return employeeConditionField; }
        set { employeeConditionField = value; }
    }

    public int employeeConditionAmount
    {
        get { return employeeConditionAmountField; }
        set { employeeConditionAmountField = value; }
    }

    public int employeePeriodType
    {
        get { return employeePeriodTypeField; }
        set { employeePeriodTypeField = value; }
    }

    public int periodConditionAmount
    {
        get { return periodConditionAmountField; }
        set { periodConditionAmountField = value; }
    }

    public int periodConditionType
    {
        get { return periodConditionTypeField; }
        set { periodConditionTypeField = value; }
    }

    public bool countAbsences
    {
        get { return countAbsencesField; }
        set { countAbsencesField = value; }
    }

    public string allowedAbsences
    {
        get { return allowedAbsencesField; }
        set { allowedAbsencesField = value; }
    }

    public bool overrideCountAsWorkedHours
    {
        get { return overrideCountAsWorkedHoursField; }
        set { overrideCountAsWorkedHoursField = value; }
    }

    [SoapIgnore]
    public bool overrideCountAsWorkedHoursSpecified
    {
        get { return overrideCountAsWorkedHoursFieldSpecified; }
        set { overrideCountAsWorkedHoursFieldSpecified = value; }
    }

    public bool virtualShiftsAsWorkedTimeDay
    {
        get { return virtualShiftsAsWorkedTimeDayField; }
        set { virtualShiftsAsWorkedTimeDayField = value; }
    }

    [SoapIgnore]
    public bool virtualShiftsAsWorkedTimeDaySpecified
    {
        get { return virtualShiftsAsWorkedTimeDayFieldSpecified; }
        set { virtualShiftsAsWorkedTimeDayFieldSpecified = value; }
    }

    public bool ignoreOvertimeShifts
    {
        get { return ignoreOvertimeShiftsField; }
        set { ignoreOvertimeShiftsField = value; }
    }

    [SoapIgnore]
    public bool ignoreOvertimeShiftsSpecified
    {
        get { return ignoreOvertimeShiftsFieldSpecified; }
        set { ignoreOvertimeShiftsFieldSpecified = value; }
    }

    public string[] validationErrors
    {
        get { return validationErrorsField; }
        set { validationErrorsField = value; }
    }
}
