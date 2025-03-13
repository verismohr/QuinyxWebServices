using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class AgreementTemplateV2
{
	private int idField;

	private string extTemplateIdField;

	private int restIdField;

	private string templateNameField;

	private int hourlyField;

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

	private bool stdRedDaysField;

	private bool stdOverTimeField;

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

	private decimal autoPunchOutField;

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

	private int balancePeriodLengthField;

	private decimal balancePeriodHoursField;

	private DateTime balancePeriodStartDateField;

	private bool useWorkDayModelField;

	private AvailabilityTimePeriod[] availabilityField;

	private OvertimePeriod[] overtimePeriodsField;

	private OvertimePeriod[] utPeriodsField;

	private MonthlyHours[] monthlyHoursField;

	private agreementOvertimeMethod[] overtimeMethodsField;

	private punchRounding[] punchDeviationsField;

	private EmploymentRate[] employmentRatesField;

	private NominalDayPerWeek[] nominalDaysPerWeekField;

	private AgreementSalary[] salariesField;

	private SalaryAdditionByYear[] salaryAdditionsAgeBasedField;

	private int ageBasedSalaryAdditionCalcModeField;

	private bool ageBasedSalaryAdditionCalcModeFieldSpecified;

	private SalaryAdditionByYear[] salaryAdditionsYearsWorkedBasedField;

	private int yearsWorkedBasedSalaryAdditionCalcModeField;

	private bool yearsWorkedBasedSalaryAdditionCalcModeFieldSpecified;

	private bool useStdBreakCreationRulesField;

	private bool useStdBreakCreationRulesFieldSpecified;

	private BreakCalculationRule[] breakCalculationRulesField;

	private MinShiftLength[] minShiftLenghtsField;

	private BankHoliday[] bankHolidaysField;

	private SocialCost[] socialCostsField;

	private SalaryCostPeriod[] salaryCostPeriodsField;

	private SalaryCostLimit[] salaryCostLimitsField;

	private DateTime tsField;

	public int id
	{
		get
		{
			return idField;
		}
		set
		{
			idField = value;
		}
	}

	public string extTemplateId
	{
		get
		{
			return extTemplateIdField;
		}
		set
		{
			extTemplateIdField = value;
		}
	}

	public int restId
	{
		get
		{
			return restIdField;
		}
		set
		{
			restIdField = value;
		}
	}

	public string templateName
	{
		get
		{
			return templateNameField;
		}
		set
		{
			templateNameField = value;
		}
	}

	public int hourly
	{
		get
		{
			return hourlyField;
		}
		set
		{
			hourlyField = value;
		}
	}

	public string comment
	{
		get
		{
			return commentField;
		}
		set
		{
			commentField = value;
		}
	}

	public int schedulePeriodType
	{
		get
		{
			return schedulePeriodTypeField;
		}
		set
		{
			schedulePeriodTypeField = value;
		}
	}

	public int schedulePeriodLength
	{
		get
		{
			return schedulePeriodLengthField;
		}
		set
		{
			schedulePeriodLengthField = value;
		}
	}

	[SoapElement(DataType = "date")]
	public DateTime schedulePeriodStartDate
	{
		get
		{
			return schedulePeriodStartDateField;
		}
		set
		{
			schedulePeriodStartDateField = value;
		}
	}

	public decimal fullEmploymentDays
	{
		get
		{
			return fullEmploymentDaysField;
		}
		set
		{
			fullEmploymentDaysField = value;
		}
	}

	public int fullEmploymentDaysPerWeek
	{
		get
		{
			return fullEmploymentDaysPerWeekField;
		}
		set
		{
			fullEmploymentDaysPerWeekField = value;
		}
	}

	public decimal fullEmploymentHrs
	{
		get
		{
			return fullEmploymentHrsField;
		}
		set
		{
			fullEmploymentHrsField = value;
		}
	}

	public bool excludeSundaysInWorkHours
	{
		get
		{
			return excludeSundaysInWorkHoursField;
		}
		set
		{
			excludeSundaysInWorkHoursField = value;
		}
	}

	public bool breakRounding
	{
		get
		{
			return breakRoundingField;
		}
		set
		{
			breakRoundingField = value;
		}
	}

	public bool breakIsWorkTime
	{
		get
		{
			return breakIsWorkTimeField;
		}
		set
		{
			breakIsWorkTimeField = value;
		}
	}

	public string dayBreak
	{
		get
		{
			return dayBreakField;
		}
		set
		{
			dayBreakField = value;
		}
	}

	public decimal weeklyAvg
	{
		get
		{
			return weeklyAvgField;
		}
		set
		{
			weeklyAvgField = value;
		}
	}

	public bool stdRedDays
	{
		get
		{
			return stdRedDaysField;
		}
		set
		{
			stdRedDaysField = value;
		}
	}

	public bool stdOverTime
	{
		get
		{
			return stdOverTimeField;
		}
		set
		{
			stdOverTimeField = value;
		}
	}

	public decimal minHrsWeek
	{
		get
		{
			return minHrsWeekField;
		}
		set
		{
			minHrsWeekField = value;
		}
	}

	public int maxDays
	{
		get
		{
			return maxDaysField;
		}
		set
		{
			maxDaysField = value;
		}
	}

	public int minFreeDays
	{
		get
		{
			return minFreeDaysField;
		}
		set
		{
			minFreeDaysField = value;
		}
	}

	public decimal maxHourDay
	{
		get
		{
			return maxHourDayField;
		}
		set
		{
			maxHourDayField = value;
		}
	}

	public decimal maxHourWeek
	{
		get
		{
			return maxHourWeekField;
		}
		set
		{
			maxHourWeekField = value;
		}
	}

	public decimal minRest
	{
		get
		{
			return minRestField;
		}
		set
		{
			minRestField = value;
		}
	}

	public decimal minRestWeek
	{
		get
		{
			return minRestWeekField;
		}
		set
		{
			minRestWeekField = value;
		}
	}

	public int seqDays
	{
		get
		{
			return seqDaysField;
		}
		set
		{
			seqDaysField = value;
		}
	}

	public int seqMaxDays
	{
		get
		{
			return seqMaxDaysField;
		}
		set
		{
			seqMaxDaysField = value;
		}
	}

	public decimal seqMaxHrs
	{
		get
		{
			return seqMaxHrsField;
		}
		set
		{
			seqMaxHrsField = value;
		}
	}

	public int weekStart
	{
		get
		{
			return weekStartField;
		}
		set
		{
			weekStartField = value;
		}
	}

	public bool atDayBreak
	{
		get
		{
			return atDayBreakField;
		}
		set
		{
			atDayBreakField = value;
		}
	}

	public string dayBreakRest
	{
		get
		{
			return dayBreakRestField;
		}
		set
		{
			dayBreakRestField = value;
		}
	}

	public int minBreak
	{
		get
		{
			return minBreakField;
		}
		set
		{
			minBreakField = value;
		}
	}

	public int maxBreak
	{
		get
		{
			return maxBreakField;
		}
		set
		{
			maxBreakField = value;
		}
	}

	public int weeksAvail
	{
		get
		{
			return weeksAvailField;
		}
		set
		{
			weeksAvailField = value;
		}
	}

	public bool schedWeekEnds
	{
		get
		{
			return schedWeekEndsField;
		}
		set
		{
			schedWeekEndsField = value;
		}
	}

	public int minWeekEndYear
	{
		get
		{
			return minWeekEndYearField;
		}
		set
		{
			minWeekEndYearField = value;
		}
	}

	public decimal maxTimeWoBreak
	{
		get
		{
			return maxTimeWoBreakField;
		}
		set
		{
			maxTimeWoBreakField = value;
		}
	}

	public decimal scheduleLockPeriod
	{
		get
		{
			return scheduleLockPeriodField;
		}
		set
		{
			scheduleLockPeriodField = value;
		}
	}

	public int scheduleLockPeriodType
	{
		get
		{
			return scheduleLockPeriodTypeField;
		}
		set
		{
			scheduleLockPeriodTypeField = value;
		}
	}

	public bool checkAvailability
	{
		get
		{
			return checkAvailabilityField;
		}
		set
		{
			checkAvailabilityField = value;
		}
	}

	public int punchType
	{
		get
		{
			return punchTypeField;
		}
		set
		{
			punchTypeField = value;
		}
	}

	public bool appPayOnAbsence
	{
		get
		{
			return appPayOnAbsenceField;
		}
		set
		{
			appPayOnAbsenceField = value;
		}
	}

	public int payOtime
	{
		get
		{
			return payOtimeField;
		}
		set
		{
			payOtimeField = value;
		}
	}

	public int payUT
	{
		get
		{
			return payUTField;
		}
		set
		{
			payUTField = value;
		}
	}

	public bool showIgnoreOtime
	{
		get
		{
			return showIgnoreOtimeField;
		}
		set
		{
			showIgnoreOtimeField = value;
		}
	}

	public bool showUnspecifiedLeaveInWP
	{
		get
		{
			return showUnspecifiedLeaveInWPField;
		}
		set
		{
			showUnspecifiedLeaveInWPField = value;
		}
	}

	public bool allowPunchingOnSubshifts
	{
		get
		{
			return allowPunchingOnSubshiftsField;
		}
		set
		{
			allowPunchingOnSubshiftsField = value;
		}
	}

	public bool genMoretime
	{
		get
		{
			return genMoretimeField;
		}
		set
		{
			genMoretimeField = value;
		}
	}

	public int overtimeMethod
	{
		get
		{
			return overtimeMethodField;
		}
		set
		{
			overtimeMethodField = value;
		}
	}

	public int overtimeWindow
	{
		get
		{
			return overtimeWindowField;
		}
		set
		{
			overtimeWindowField = value;
		}
	}

	public decimal autoPunchOut
	{
		get
		{
			return autoPunchOutField;
		}
		set
		{
			autoPunchOutField = value;
		}
	}

	public bool lateChange
	{
		get
		{
			return lateChangeField;
		}
		set
		{
			lateChangeField = value;
		}
	}

	public int lateChangeUT
	{
		get
		{
			return lateChangeUTField;
		}
		set
		{
			lateChangeUTField = value;
		}
	}

	public bool breakDayrest
	{
		get
		{
			return breakDayrestField;
		}
		set
		{
			breakDayrestField = value;
		}
	}

	public int breakDayrestUT
	{
		get
		{
			return breakDayrestUTField;
		}
		set
		{
			breakDayrestUTField = value;
		}
	}

	public bool breakWeekrest
	{
		get
		{
			return breakWeekrestField;
		}
		set
		{
			breakWeekrestField = value;
		}
	}

	public int breakWeekrestUT
	{
		get
		{
			return breakWeekrestUTField;
		}
		set
		{
			breakWeekrestUTField = value;
		}
	}

	public bool timeBank
	{
		get
		{
			return timeBankField;
		}
		set
		{
			timeBankField = value;
		}
	}

	public int payrollSystem
	{
		get
		{
			return payrollSystemField;
		}
		set
		{
			payrollSystemField = value;
		}
	}

	public bool adjustForLeave
	{
		get
		{
			return adjustForLeaveField;
		}
		set
		{
			adjustForLeaveField = value;
		}
	}

	public bool advancedTimeRules
	{
		get
		{
			return advancedTimeRulesField;
		}
		set
		{
			advancedTimeRulesField = value;
		}
	}

	public bool otCancelsUt
	{
		get
		{
			return otCancelsUtField;
		}
		set
		{
			otCancelsUtField = value;
		}
	}

	public bool allowOverrideOverlapping
	{
		get
		{
			return allowOverrideOverlappingField;
		}
		set
		{
			allowOverrideOverlappingField = value;
		}
	}

	public bool useSecondWeekend
	{
		get
		{
			return useSecondWeekendField;
		}
		set
		{
			useSecondWeekendField = value;
		}
	}

	public decimal utThreshold
	{
		get
		{
			return utThresholdField;
		}
		set
		{
			utThresholdField = value;
		}
	}

	public int utThresholdType
	{
		get
		{
			return utThresholdTypeField;
		}
		set
		{
			utThresholdTypeField = value;
		}
	}

	public decimal dailyOvertimeHours
	{
		get
		{
			return dailyOvertimeHoursField;
		}
		set
		{
			dailyOvertimeHoursField = value;
		}
	}

	public decimal weeklyOvertimeHours
	{
		get
		{
			return weeklyOvertimeHoursField;
		}
		set
		{
			weeklyOvertimeHoursField = value;
		}
	}

	public string noCostPeriodStart
	{
		get
		{
			return noCostPeriodStartField;
		}
		set
		{
			noCostPeriodStartField = value;
		}
	}

	public string noCostPeriodEnd
	{
		get
		{
			return noCostPeriodEndField;
		}
		set
		{
			noCostPeriodEndField = value;
		}
	}

	public int balancePeriodType
	{
		get
		{
			return balancePeriodTypeField;
		}
		set
		{
			balancePeriodTypeField = value;
		}
	}

	public int balancePeriodLength
	{
		get
		{
			return balancePeriodLengthField;
		}
		set
		{
			balancePeriodLengthField = value;
		}
	}

	public decimal balancePeriodHours
	{
		get
		{
			return balancePeriodHoursField;
		}
		set
		{
			balancePeriodHoursField = value;
		}
	}

	[SoapElement(DataType = "date")]
	public DateTime balancePeriodStartDate
	{
		get
		{
			return balancePeriodStartDateField;
		}
		set
		{
			balancePeriodStartDateField = value;
		}
	}

	public bool useWorkDayModel
	{
		get
		{
			return useWorkDayModelField;
		}
		set
		{
			useWorkDayModelField = value;
		}
	}

	public AvailabilityTimePeriod[] availability
	{
		get
		{
			return availabilityField;
		}
		set
		{
			availabilityField = value;
		}
	}

	public OvertimePeriod[] overtimePeriods
	{
		get
		{
			return overtimePeriodsField;
		}
		set
		{
			overtimePeriodsField = value;
		}
	}

	public OvertimePeriod[] utPeriods
	{
		get
		{
			return utPeriodsField;
		}
		set
		{
			utPeriodsField = value;
		}
	}

	public MonthlyHours[] monthlyHours
	{
		get
		{
			return monthlyHoursField;
		}
		set
		{
			monthlyHoursField = value;
		}
	}

	public agreementOvertimeMethod[] overtimeMethods
	{
		get
		{
			return overtimeMethodsField;
		}
		set
		{
			overtimeMethodsField = value;
		}
	}

	public punchRounding[] punchDeviations
	{
		get
		{
			return punchDeviationsField;
		}
		set
		{
			punchDeviationsField = value;
		}
	}

	public EmploymentRate[] employmentRates
	{
		get
		{
			return employmentRatesField;
		}
		set
		{
			employmentRatesField = value;
		}
	}

	public NominalDayPerWeek[] nominalDaysPerWeek
	{
		get
		{
			return nominalDaysPerWeekField;
		}
		set
		{
			nominalDaysPerWeekField = value;
		}
	}

	public AgreementSalary[] salaries
	{
		get
		{
			return salariesField;
		}
		set
		{
			salariesField = value;
		}
	}

	public SalaryAdditionByYear[] salaryAdditionsAgeBased
	{
		get
		{
			return salaryAdditionsAgeBasedField;
		}
		set
		{
			salaryAdditionsAgeBasedField = value;
		}
	}

	public int ageBasedSalaryAdditionCalcMode
	{
		get
		{
			return ageBasedSalaryAdditionCalcModeField;
		}
		set
		{
			ageBasedSalaryAdditionCalcModeField = value;
		}
	}

	[SoapIgnore]
	public bool ageBasedSalaryAdditionCalcModeSpecified
	{
		get
		{
			return ageBasedSalaryAdditionCalcModeFieldSpecified;
		}
		set
		{
			ageBasedSalaryAdditionCalcModeFieldSpecified = value;
		}
	}

	public SalaryAdditionByYear[] salaryAdditionsYearsWorkedBased
	{
		get
		{
			return salaryAdditionsYearsWorkedBasedField;
		}
		set
		{
			salaryAdditionsYearsWorkedBasedField = value;
		}
	}

	public int yearsWorkedBasedSalaryAdditionCalcMode
	{
		get
		{
			return yearsWorkedBasedSalaryAdditionCalcModeField;
		}
		set
		{
			yearsWorkedBasedSalaryAdditionCalcModeField = value;
		}
	}

	[SoapIgnore]
	public bool yearsWorkedBasedSalaryAdditionCalcModeSpecified
	{
		get
		{
			return yearsWorkedBasedSalaryAdditionCalcModeFieldSpecified;
		}
		set
		{
			yearsWorkedBasedSalaryAdditionCalcModeFieldSpecified = value;
		}
	}

	public bool useStdBreakCreationRules
	{
		get
		{
			return useStdBreakCreationRulesField;
		}
		set
		{
			useStdBreakCreationRulesField = value;
		}
	}

	[SoapIgnore]
	public bool useStdBreakCreationRulesSpecified
	{
		get
		{
			return useStdBreakCreationRulesFieldSpecified;
		}
		set
		{
			useStdBreakCreationRulesFieldSpecified = value;
		}
	}

	public BreakCalculationRule[] breakCalculationRules
	{
		get
		{
			return breakCalculationRulesField;
		}
		set
		{
			breakCalculationRulesField = value;
		}
	}

	public MinShiftLength[] minShiftLenghts
	{
		get
		{
			return minShiftLenghtsField;
		}
		set
		{
			minShiftLenghtsField = value;
		}
	}

	public BankHoliday[] bankHolidays
	{
		get
		{
			return bankHolidaysField;
		}
		set
		{
			bankHolidaysField = value;
		}
	}

	public SocialCost[] socialCosts
	{
		get
		{
			return socialCostsField;
		}
		set
		{
			socialCostsField = value;
		}
	}

	public SalaryCostPeriod[] salaryCostPeriods
	{
		get
		{
			return salaryCostPeriodsField;
		}
		set
		{
			salaryCostPeriodsField = value;
		}
	}

	public SalaryCostLimit[] salaryCostLimits
	{
		get
		{
			return salaryCostLimitsField;
		}
		set
		{
			salaryCostLimitsField = value;
		}
	}

	public DateTime ts
	{
		get
		{
			return tsField;
		}
		set
		{
			tsField = value;
		}
	}
}
