using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class SalaryCompensation
{
    private int idField;

    private bool idFieldSpecified;

    private string nameField;

    private int reddayIdField;

    private string salaryCodesField;

    private string eligibilityRuleIdsField;

    private int salaryCodeNameField;

    private bool salaryCodeNameFieldSpecified;

    private int periodTypeField;

    private int periodLengthField;

    private string allowedAbsencesField;

    private int fixedNrOfWorkedDaysField;

    private bool fixedNrOfWorkedDaysFieldSpecified;

    private int calculationTypeField;

    private int periodCalculationTypeField;

    private bool includeAllAbsencesCountedAsWorkedHoursField;

    private bool includeAllAbsencesCountedAsWorkedHoursFieldSpecified;

    private bool countVirtualShiftAsWorkingDayField;

    private bool deductWorkingHoursFromCompensationField;

    private bool deductWorkingHoursFromCompensationFieldSpecified;

    private decimal percentageOfSummedSalariesField;

    private bool percentageOfSummedSalariesFieldSpecified;

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

    public int reddayId
    {
        get { return reddayIdField; }
        set { reddayIdField = value; }
    }

    public string salaryCodes
    {
        get { return salaryCodesField; }
        set { salaryCodesField = value; }
    }

    public string eligibilityRuleIds
    {
        get { return eligibilityRuleIdsField; }
        set { eligibilityRuleIdsField = value; }
    }

    public int salaryCodeName
    {
        get { return salaryCodeNameField; }
        set { salaryCodeNameField = value; }
    }

    [SoapIgnore]
    public bool salaryCodeNameSpecified
    {
        get { return salaryCodeNameFieldSpecified; }
        set { salaryCodeNameFieldSpecified = value; }
    }

    public int periodType
    {
        get { return periodTypeField; }
        set { periodTypeField = value; }
    }

    public int periodLength
    {
        get { return periodLengthField; }
        set { periodLengthField = value; }
    }

    public string allowedAbsences
    {
        get { return allowedAbsencesField; }
        set { allowedAbsencesField = value; }
    }

    public int fixedNrOfWorkedDays
    {
        get { return fixedNrOfWorkedDaysField; }
        set { fixedNrOfWorkedDaysField = value; }
    }

    [SoapIgnore]
    public bool fixedNrOfWorkedDaysSpecified
    {
        get { return fixedNrOfWorkedDaysFieldSpecified; }
        set { fixedNrOfWorkedDaysFieldSpecified = value; }
    }

    public int calculationType
    {
        get { return calculationTypeField; }
        set { calculationTypeField = value; }
    }

    public int periodCalculationType
    {
        get { return periodCalculationTypeField; }
        set { periodCalculationTypeField = value; }
    }

    public bool includeAllAbsencesCountedAsWorkedHours
    {
        get { return includeAllAbsencesCountedAsWorkedHoursField; }
        set { includeAllAbsencesCountedAsWorkedHoursField = value; }
    }

    [SoapIgnore]
    public bool includeAllAbsencesCountedAsWorkedHoursSpecified
    {
        get { return includeAllAbsencesCountedAsWorkedHoursFieldSpecified; }
        set { includeAllAbsencesCountedAsWorkedHoursFieldSpecified = value; }
    }

    public bool countVirtualShiftAsWorkingDay
    {
        get { return countVirtualShiftAsWorkingDayField; }
        set { countVirtualShiftAsWorkingDayField = value; }
    }

    public bool deductWorkingHoursFromCompensation
    {
        get { return deductWorkingHoursFromCompensationField; }
        set { deductWorkingHoursFromCompensationField = value; }
    }

    [SoapIgnore]
    public bool deductWorkingHoursFromCompensationSpecified
    {
        get { return deductWorkingHoursFromCompensationFieldSpecified; }
        set { deductWorkingHoursFromCompensationFieldSpecified = value; }
    }

    public decimal percentageOfSummedSalaries
    {
        get { return percentageOfSummedSalariesField; }
        set { percentageOfSummedSalariesField = value; }
    }

    [SoapIgnore]
    public bool percentageOfSummedSalariesSpecified
    {
        get { return percentageOfSummedSalariesFieldSpecified; }
        set { percentageOfSummedSalariesFieldSpecified = value; }
    }

    public string[] validationErrors
    {
        get { return validationErrorsField; }
        set { validationErrorsField = value; }
    }
}
