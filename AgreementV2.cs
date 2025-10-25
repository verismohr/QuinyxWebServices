using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class AgreementV2
{
    private int idField;

    private string extAgreementIdField;

    private int templateIdField;

    private string extTemplateIdField;

    private int restIdField;

    private int employeeIdField;

    private string badgeNoField;

    private string nameField;

    private int hourlyField;

    private DateTime fromDateField;

    private DateTime toDateField;

    private bool expiresField;

    private string commentField;

    private int schedulePeriodTypeField;

    private int schedulePeriodLengthField;

    private DateTime schedulePeriodStartDateField;

    private decimal fullEmploymentDaysField;

    private int fullEmploymentDaysPerWeekField;

    private decimal fullEmploymentHrsField;

    private bool excludeSundaysInWorkHoursField;

    private bool breakRoundingField;

    private bool breakIsWorkTimeField;

    private string dayBreakField;

    private decimal weeklyAvgField;

    private decimal minHrsWeekField;

    private int maxDaysField;

    private int minFreeDaysField;

    private decimal maxHourDayField;

    private decimal maxHourWeekField;

    private decimal minRestField;

    private decimal minRestWeekField;

    private int seqDaysField;

    private int seqMaxDaysField;

    private decimal seqMaxHrsField;

    private int weekStartField;

    private bool atDayBreakField;

    private string dayBreakRestField;

    private int minBreakField;

    private int maxBreakField;

    private int weeksAvailField;

    private bool schedWeekEndsField;

    private int minWeekEndYearField;

    private decimal maxTimeWoBreakField;

    private decimal scheduleLockPeriodField;

    private int scheduleLockPeriodTypeField;

    private bool checkAvailabilityField;

    private int punchTypeField;

    private bool appPayOnAbsenceField;

    private int payOtimeField;

    private int payUTField;

    private bool showIgnoreOtimeField;

    private bool showUnspecifiedLeaveInWPField;

    private bool allowPunchingOnSubshiftsField;

    private bool genMoretimeField;

    private int overtimeMethodField;

    private int overtimeWindowField;

    private bool autoPunchOutField;

    private bool lateChangeField;

    private int lateChangeUTField;

    private bool breakDayrestField;

    private int breakDayrestUTField;

    private bool breakWeekrestField;

    private int breakWeekrestUTField;

    private bool timeBankField;

    private int payrollSystemField;

    private bool adjustForLeaveField;

    private bool advancedTimeRulesField;

    private bool otCancelsUtField;

    private bool allowOverrideOverlappingField;

    private bool useSecondWeekendField;

    private decimal utThresholdField;

    private int utThresholdTypeField;

    private decimal dailyOvertimeHoursField;

    private decimal weeklyOvertimeHoursField;

    private string noCostPeriodStartField;

    private string noCostPeriodEndField;

    private int balancePeriodTypeField;

    private decimal balancePeriodLengthField;

    private decimal balancePeriodHoursField;

    private DateTime balancePeriodStartDateField;

    private bool useWorkDayModelField;

    private bool isMainAgreementField;

    private bool isMainAgreementFieldSpecified;

    private string additionalField1Field;

    private string additionalField2Field;

    private string additionalField3Field;

    private string additionalField4Field;

    private string additionalField5Field;

    private bool useTempAvailField;

    private bool useTempTimeRulesField;

    private bool useTempSalaryField;

    private bool useTempWorkTimeField;

    private bool useTempEmploymentRateField;

    private bool useTempMonthHoursField;

    private bool useTempTandAField;

    private bool useTemplateBalancePeriodField;

    private bool useTempCostsField;

    private bool useTempNominalDaysPerWeekField;

    private bool useStdTimeRulesField;

    private int signStatusField;

    private AvailabilityTimePeriod[] availabilityField;

    private MonthlyHours[] monthlyHoursField;

    private agreementOvertimeMethod[] overtimeMethodsField;

    private punchRounding[] punchDeviationsField;

    private EmploymentRate[] employmentRatesField;

    private NominalDayPerWeek[] nominalDaysPerWeekField;

    private SalaryAdditionByYear[] salaryAdditionsAgeBasedField;

    private bool useTemplateAgeBasedSalaryAdditionField;

    private bool useTemplateAgeBasedSalaryAdditionFieldSpecified;

    private int ageBasedSalaryAdditionCalcModeField;

    private bool ageBasedSalaryAdditionCalcModeFieldSpecified;

    private SalaryAdditionByYear[] salaryAdditionsYearsWorkedBasedField;

    private bool useTemplateYearsWorkedBasedSalaryAdditionField;

    private bool useTemplateYearsWorkedBasedSalaryAdditionFieldSpecified;

    private int yearsWorkedBasedSalaryAdditionCalcModeField;

    private bool yearsWorkedBasedSalaryAdditionCalcModeFieldSpecified;

    private SalaryAdditionByDate[] salaryAdditionsDateBasedField;

    private AgreementSalary[] salariesField;

    private bool useTemplateBreakCreationRulesField;

    private bool useTemplateBreakCreationRulesFieldSpecified;

    private bool useStdBreakCreationRulesField;

    private bool useStdBreakCreationRulesFieldSpecified;

    private BreakCalculationRule[] breakCalculationRulesField;

    private MinShiftLength[] minShiftLenghtsField;

    private SocialCost[] socialCostsField;

    private DateTime tsField;

    private int weeklyRestTypeField;

    private bool weeklyRestTypeFieldSpecified;

    public int id
    {
        get { return idField; }
        set { idField = value; }
    }

    public string extAgreementId
    {
        get { return extAgreementIdField; }
        set { extAgreementIdField = value; }
    }

    public int templateId
    {
        get { return templateIdField; }
        set { templateIdField = value; }
    }

    public string extTemplateId
    {
        get { return extTemplateIdField; }
        set { extTemplateIdField = value; }
    }

    public int restId
    {
        get { return restIdField; }
        set { restIdField = value; }
    }

    public int employeeId
    {
        get { return employeeIdField; }
        set { employeeIdField = value; }
    }

    public string badgeNo
    {
        get { return badgeNoField; }
        set { badgeNoField = value; }
    }

    public string name
    {
        get { return nameField; }
        set { nameField = value; }
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

    public bool expires
    {
        get { return expiresField; }
        set { expiresField = value; }
    }

    public string comment
    {
        get { return commentField; }
        set { commentField = value; }
    }

    public int schedulePeriodType
    {
        get { return schedulePeriodTypeField; }
        set { schedulePeriodTypeField = value; }
    }

    public int schedulePeriodLength
    {
        get { return schedulePeriodLengthField; }
        set { schedulePeriodLengthField = value; }
    }

    [SoapElement(DataType = "date")]
    public DateTime schedulePeriodStartDate
    {
        get { return schedulePeriodStartDateField; }
        set { schedulePeriodStartDateField = value; }
    }

    public decimal fullEmploymentDays
    {
        get { return fullEmploymentDaysField; }
        set { fullEmploymentDaysField = value; }
    }

    public int fullEmploymentDaysPerWeek
    {
        get { return fullEmploymentDaysPerWeekField; }
        set { fullEmploymentDaysPerWeekField = value; }
    }

    public decimal fullEmploymentHrs
    {
        get { return fullEmploymentHrsField; }
        set { fullEmploymentHrsField = value; }
    }

    public bool excludeSundaysInWorkHours
    {
        get { return excludeSundaysInWorkHoursField; }
        set { excludeSundaysInWorkHoursField = value; }
    }

    public bool breakRounding
    {
        get { return breakRoundingField; }
        set { breakRoundingField = value; }
    }

    public bool breakIsWorkTime
    {
        get { return breakIsWorkTimeField; }
        set { breakIsWorkTimeField = value; }
    }

    public string dayBreak
    {
        get { return dayBreakField; }
        set { dayBreakField = value; }
    }

    public decimal weeklyAvg
    {
        get { return weeklyAvgField; }
        set { weeklyAvgField = value; }
    }

    public decimal minHrsWeek
    {
        get { return minHrsWeekField; }
        set { minHrsWeekField = value; }
    }

    public int maxDays
    {
        get { return maxDaysField; }
        set { maxDaysField = value; }
    }

    public int minFreeDays
    {
        get { return minFreeDaysField; }
        set { minFreeDaysField = value; }
    }

    public decimal maxHourDay
    {
        get { return maxHourDayField; }
        set { maxHourDayField = value; }
    }

    public decimal maxHourWeek
    {
        get { return maxHourWeekField; }
        set { maxHourWeekField = value; }
    }

    public decimal minRest
    {
        get { return minRestField; }
        set { minRestField = value; }
    }

    public decimal minRestWeek
    {
        get { return minRestWeekField; }
        set { minRestWeekField = value; }
    }

    public int seqDays
    {
        get { return seqDaysField; }
        set { seqDaysField = value; }
    }

    public int seqMaxDays
    {
        get { return seqMaxDaysField; }
        set { seqMaxDaysField = value; }
    }

    public decimal seqMaxHrs
    {
        get { return seqMaxHrsField; }
        set { seqMaxHrsField = value; }
    }

    public int weekStart
    {
        get { return weekStartField; }
        set { weekStartField = value; }
    }

    public bool atDayBreak
    {
        get { return atDayBreakField; }
        set { atDayBreakField = value; }
    }

    public string dayBreakRest
    {
        get { return dayBreakRestField; }
        set { dayBreakRestField = value; }
    }

    public int minBreak
    {
        get { return minBreakField; }
        set { minBreakField = value; }
    }

    public int maxBreak
    {
        get { return maxBreakField; }
        set { maxBreakField = value; }
    }

    public int weeksAvail
    {
        get { return weeksAvailField; }
        set { weeksAvailField = value; }
    }

    public bool schedWeekEnds
    {
        get { return schedWeekEndsField; }
        set { schedWeekEndsField = value; }
    }

    public int minWeekEndYear
    {
        get { return minWeekEndYearField; }
        set { minWeekEndYearField = value; }
    }

    public decimal maxTimeWoBreak
    {
        get { return maxTimeWoBreakField; }
        set { maxTimeWoBreakField = value; }
    }

    public decimal scheduleLockPeriod
    {
        get { return scheduleLockPeriodField; }
        set { scheduleLockPeriodField = value; }
    }

    public int scheduleLockPeriodType
    {
        get { return scheduleLockPeriodTypeField; }
        set { scheduleLockPeriodTypeField = value; }
    }

    public bool checkAvailability
    {
        get { return checkAvailabilityField; }
        set { checkAvailabilityField = value; }
    }

    public int punchType
    {
        get { return punchTypeField; }
        set { punchTypeField = value; }
    }

    public bool appPayOnAbsence
    {
        get { return appPayOnAbsenceField; }
        set { appPayOnAbsenceField = value; }
    }

    public int payOtime
    {
        get { return payOtimeField; }
        set { payOtimeField = value; }
    }

    public int payUT
    {
        get { return payUTField; }
        set { payUTField = value; }
    }

    public bool showIgnoreOtime
    {
        get { return showIgnoreOtimeField; }
        set { showIgnoreOtimeField = value; }
    }

    public bool showUnspecifiedLeaveInWP
    {
        get { return showUnspecifiedLeaveInWPField; }
        set { showUnspecifiedLeaveInWPField = value; }
    }

    public bool allowPunchingOnSubshifts
    {
        get { return allowPunchingOnSubshiftsField; }
        set { allowPunchingOnSubshiftsField = value; }
    }

    public bool genMoretime
    {
        get { return genMoretimeField; }
        set { genMoretimeField = value; }
    }

    public int overtimeMethod
    {
        get { return overtimeMethodField; }
        set { overtimeMethodField = value; }
    }

    public int overtimeWindow
    {
        get { return overtimeWindowField; }
        set { overtimeWindowField = value; }
    }

    public bool autoPunchOut
    {
        get { return autoPunchOutField; }
        set { autoPunchOutField = value; }
    }

    public bool lateChange
    {
        get { return lateChangeField; }
        set { lateChangeField = value; }
    }

    public int lateChangeUT
    {
        get { return lateChangeUTField; }
        set { lateChangeUTField = value; }
    }

    public bool breakDayrest
    {
        get { return breakDayrestField; }
        set { breakDayrestField = value; }
    }

    public int breakDayrestUT
    {
        get { return breakDayrestUTField; }
        set { breakDayrestUTField = value; }
    }

    public bool breakWeekrest
    {
        get { return breakWeekrestField; }
        set { breakWeekrestField = value; }
    }

    public int breakWeekrestUT
    {
        get { return breakWeekrestUTField; }
        set { breakWeekrestUTField = value; }
    }

    public bool timeBank
    {
        get { return timeBankField; }
        set { timeBankField = value; }
    }

    public int payrollSystem
    {
        get { return payrollSystemField; }
        set { payrollSystemField = value; }
    }

    public bool adjustForLeave
    {
        get { return adjustForLeaveField; }
        set { adjustForLeaveField = value; }
    }

    public bool advancedTimeRules
    {
        get { return advancedTimeRulesField; }
        set { advancedTimeRulesField = value; }
    }

    public bool otCancelsUt
    {
        get { return otCancelsUtField; }
        set { otCancelsUtField = value; }
    }

    public bool allowOverrideOverlapping
    {
        get { return allowOverrideOverlappingField; }
        set { allowOverrideOverlappingField = value; }
    }

    public bool useSecondWeekend
    {
        get { return useSecondWeekendField; }
        set { useSecondWeekendField = value; }
    }

    public decimal utThreshold
    {
        get { return utThresholdField; }
        set { utThresholdField = value; }
    }

    public int utThresholdType
    {
        get { return utThresholdTypeField; }
        set { utThresholdTypeField = value; }
    }

    public decimal dailyOvertimeHours
    {
        get { return dailyOvertimeHoursField; }
        set { dailyOvertimeHoursField = value; }
    }

    public decimal weeklyOvertimeHours
    {
        get { return weeklyOvertimeHoursField; }
        set { weeklyOvertimeHoursField = value; }
    }

    public string noCostPeriodStart
    {
        get { return noCostPeriodStartField; }
        set { noCostPeriodStartField = value; }
    }

    public string noCostPeriodEnd
    {
        get { return noCostPeriodEndField; }
        set { noCostPeriodEndField = value; }
    }

    public int balancePeriodType
    {
        get { return balancePeriodTypeField; }
        set { balancePeriodTypeField = value; }
    }

    public decimal balancePeriodLength
    {
        get { return balancePeriodLengthField; }
        set { balancePeriodLengthField = value; }
    }

    public decimal balancePeriodHours
    {
        get { return balancePeriodHoursField; }
        set { balancePeriodHoursField = value; }
    }

    [SoapElement(DataType = "date")]
    public DateTime balancePeriodStartDate
    {
        get { return balancePeriodStartDateField; }
        set { balancePeriodStartDateField = value; }
    }

    public bool useWorkDayModel
    {
        get { return useWorkDayModelField; }
        set { useWorkDayModelField = value; }
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

    public bool useTempAvail
    {
        get { return useTempAvailField; }
        set { useTempAvailField = value; }
    }

    public bool useTempTimeRules
    {
        get { return useTempTimeRulesField; }
        set { useTempTimeRulesField = value; }
    }

    public bool useTempSalary
    {
        get { return useTempSalaryField; }
        set { useTempSalaryField = value; }
    }

    public bool useTempWorkTime
    {
        get { return useTempWorkTimeField; }
        set { useTempWorkTimeField = value; }
    }

    public bool useTempEmploymentRate
    {
        get { return useTempEmploymentRateField; }
        set { useTempEmploymentRateField = value; }
    }

    public bool useTempMonthHours
    {
        get { return useTempMonthHoursField; }
        set { useTempMonthHoursField = value; }
    }

    public bool useTempTandA
    {
        get { return useTempTandAField; }
        set { useTempTandAField = value; }
    }

    public bool useTemplateBalancePeriod
    {
        get { return useTemplateBalancePeriodField; }
        set { useTemplateBalancePeriodField = value; }
    }

    public bool useTempCosts
    {
        get { return useTempCostsField; }
        set { useTempCostsField = value; }
    }

    public bool useTempNominalDaysPerWeek
    {
        get { return useTempNominalDaysPerWeekField; }
        set { useTempNominalDaysPerWeekField = value; }
    }

    public bool useStdTimeRules
    {
        get { return useStdTimeRulesField; }
        set { useStdTimeRulesField = value; }
    }

    public int signStatus
    {
        get { return signStatusField; }
        set { signStatusField = value; }
    }

    public AvailabilityTimePeriod[] availability
    {
        get { return availabilityField; }
        set { availabilityField = value; }
    }

    public MonthlyHours[] monthlyHours
    {
        get { return monthlyHoursField; }
        set { monthlyHoursField = value; }
    }

    public agreementOvertimeMethod[] overtimeMethods
    {
        get { return overtimeMethodsField; }
        set { overtimeMethodsField = value; }
    }

    public punchRounding[] punchDeviations
    {
        get { return punchDeviationsField; }
        set { punchDeviationsField = value; }
    }

    public EmploymentRate[] employmentRates
    {
        get { return employmentRatesField; }
        set { employmentRatesField = value; }
    }

    public NominalDayPerWeek[] nominalDaysPerWeek
    {
        get { return nominalDaysPerWeekField; }
        set { nominalDaysPerWeekField = value; }
    }

    public SalaryAdditionByYear[] salaryAdditionsAgeBased
    {
        get { return salaryAdditionsAgeBasedField; }
        set { salaryAdditionsAgeBasedField = value; }
    }

    public bool useTemplateAgeBasedSalaryAddition
    {
        get { return useTemplateAgeBasedSalaryAdditionField; }
        set { useTemplateAgeBasedSalaryAdditionField = value; }
    }

    [SoapIgnore]
    public bool useTemplateAgeBasedSalaryAdditionSpecified
    {
        get { return useTemplateAgeBasedSalaryAdditionFieldSpecified; }
        set { useTemplateAgeBasedSalaryAdditionFieldSpecified = value; }
    }

    public int ageBasedSalaryAdditionCalcMode
    {
        get { return ageBasedSalaryAdditionCalcModeField; }
        set { ageBasedSalaryAdditionCalcModeField = value; }
    }

    [SoapIgnore]
    public bool ageBasedSalaryAdditionCalcModeSpecified
    {
        get { return ageBasedSalaryAdditionCalcModeFieldSpecified; }
        set { ageBasedSalaryAdditionCalcModeFieldSpecified = value; }
    }

    public SalaryAdditionByYear[] salaryAdditionsYearsWorkedBased
    {
        get { return salaryAdditionsYearsWorkedBasedField; }
        set { salaryAdditionsYearsWorkedBasedField = value; }
    }

    public bool useTemplateYearsWorkedBasedSalaryAddition
    {
        get { return useTemplateYearsWorkedBasedSalaryAdditionField; }
        set { useTemplateYearsWorkedBasedSalaryAdditionField = value; }
    }

    [SoapIgnore]
    public bool useTemplateYearsWorkedBasedSalaryAdditionSpecified
    {
        get { return useTemplateYearsWorkedBasedSalaryAdditionFieldSpecified; }
        set { useTemplateYearsWorkedBasedSalaryAdditionFieldSpecified = value; }
    }

    public int yearsWorkedBasedSalaryAdditionCalcMode
    {
        get { return yearsWorkedBasedSalaryAdditionCalcModeField; }
        set { yearsWorkedBasedSalaryAdditionCalcModeField = value; }
    }

    [SoapIgnore]
    public bool yearsWorkedBasedSalaryAdditionCalcModeSpecified
    {
        get { return yearsWorkedBasedSalaryAdditionCalcModeFieldSpecified; }
        set { yearsWorkedBasedSalaryAdditionCalcModeFieldSpecified = value; }
    }

    public SalaryAdditionByDate[] salaryAdditionsDateBased
    {
        get { return salaryAdditionsDateBasedField; }
        set { salaryAdditionsDateBasedField = value; }
    }

    public AgreementSalary[] salaries
    {
        get { return salariesField; }
        set { salariesField = value; }
    }

    public bool useTemplateBreakCreationRules
    {
        get { return useTemplateBreakCreationRulesField; }
        set { useTemplateBreakCreationRulesField = value; }
    }

    [SoapIgnore]
    public bool useTemplateBreakCreationRulesSpecified
    {
        get { return useTemplateBreakCreationRulesFieldSpecified; }
        set { useTemplateBreakCreationRulesFieldSpecified = value; }
    }

    public bool useStdBreakCreationRules
    {
        get { return useStdBreakCreationRulesField; }
        set { useStdBreakCreationRulesField = value; }
    }

    [SoapIgnore]
    public bool useStdBreakCreationRulesSpecified
    {
        get { return useStdBreakCreationRulesFieldSpecified; }
        set { useStdBreakCreationRulesFieldSpecified = value; }
    }

    public BreakCalculationRule[] breakCalculationRules
    {
        get { return breakCalculationRulesField; }
        set { breakCalculationRulesField = value; }
    }

    public MinShiftLength[] minShiftLenghts
    {
        get { return minShiftLenghtsField; }
        set { minShiftLenghtsField = value; }
    }

    public SocialCost[] socialCosts
    {
        get { return socialCostsField; }
        set { socialCostsField = value; }
    }

    public DateTime ts
    {
        get { return tsField; }
        set { tsField = value; }
    }

    public int weeklyRestType
    {
        get { return weeklyRestTypeField; }
        set { weeklyRestTypeField = value; }
    }

    [SoapIgnore]
    public bool weeklyRestTypeSpecified
    {
        get { return weeklyRestTypeFieldSpecified; }
        set { weeklyRestTypeFieldSpecified = value; }
    }
}
