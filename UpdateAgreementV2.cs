using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class UpdateAgreementV2
{
	private int idField;

	private bool idFieldSpecified;

	private string extAgreementIdField;

	private string nameField;

	private int restIdField;

	private bool restIdFieldSpecified;

	private int employeeIdField;

	private bool employeeIdFieldSpecified;

	private string badgeNoField;

	private int templateIdField;

	private bool templateIdFieldSpecified;

	private string extTemplateIdField;

	private bool hourlyField;

	private bool hourlyFieldSpecified;

	private DateTime fromDateField;

	private bool fromDateFieldSpecified;

	private DateTime toDateField;

	private bool toDateFieldSpecified;

	private bool expiresField;

	private bool expiresFieldSpecified;

	private string commentField;

	private int schedulePeriodTypeField;

	private bool schedulePeriodTypeFieldSpecified;

	private int schedulePeriodLengthField;

	private bool schedulePeriodLengthFieldSpecified;

	private DateTime schedulePeriodStartDateField;

	private bool schedulePeriodStartDateFieldSpecified;

	private decimal fullEmploymentDaysField;

	private bool fullEmploymentDaysFieldSpecified;

	private int fullEmploymentDaysPerWeekField;

	private bool fullEmploymentDaysPerWeekFieldSpecified;

	private decimal fullEmploymentHrsField;

	private bool fullEmploymentHrsFieldSpecified;

	private bool excludeSundaysInWorkHoursField;

	private bool excludeSundaysInWorkHoursFieldSpecified;

	private bool breakRoundingField;

	private bool breakRoundingFieldSpecified;

	private bool breakIsWorkTimeField;

	private bool breakIsWorkTimeFieldSpecified;

	private string dayBreakField;

	private decimal minHrsWeekField;

	private bool minHrsWeekFieldSpecified;

	private int maxDaysField;

	private bool maxDaysFieldSpecified;

	private int minFreeDaysField;

	private bool minFreeDaysFieldSpecified;

	private decimal maxHourDayField;

	private bool maxHourDayFieldSpecified;

	private decimal maxHourWeekField;

	private bool maxHourWeekFieldSpecified;

	private decimal minRestField;

	private bool minRestFieldSpecified;

	private decimal minRestWeekField;

	private bool minRestWeekFieldSpecified;

	private int seqDaysField;

	private bool seqDaysFieldSpecified;

	private int seqMaxDaysField;

	private bool seqMaxDaysFieldSpecified;

	private decimal seqMaxHrsField;

	private bool seqMaxHrsFieldSpecified;

	private int weekStartField;

	private bool weekStartFieldSpecified;

	private bool atDayBreakField;

	private bool atDayBreakFieldSpecified;

	private string dayBreakRestField;

	private int minBreakField;

	private bool minBreakFieldSpecified;

	private int maxBreakField;

	private bool maxBreakFieldSpecified;

	private int weeksAvailField;

	private bool weeksAvailFieldSpecified;

	private bool schedWeekEndsField;

	private bool schedWeekEndsFieldSpecified;

	private int minWeekEndYearField;

	private bool minWeekEndYearFieldSpecified;

	private decimal maxTimeWoBreakField;

	private bool maxTimeWoBreakFieldSpecified;

	private decimal scheduleLockPeriodField;

	private bool scheduleLockPeriodFieldSpecified;

	private int scheduleLockPeriodTypeField;

	private bool scheduleLockPeriodTypeFieldSpecified;

	private bool checkAvailabilityField;

	private bool checkAvailabilityFieldSpecified;

	private int punchTypeField;

	private bool punchTypeFieldSpecified;

	private bool appPayOnAbsenceField;

	private bool appPayOnAbsenceFieldSpecified;

	private int payOtimeField;

	private bool payOtimeFieldSpecified;

	private int payUTField;

	private bool payUTFieldSpecified;

	private bool showIgnoreOtimeField;

	private bool showIgnoreOtimeFieldSpecified;

	private bool showUnspecifiedLeaveInWPField;

	private bool showUnspecifiedLeaveInWPFieldSpecified;

	private bool allowPunchingOnSubshiftsField;

	private bool allowPunchingOnSubshiftsFieldSpecified;

	private bool genMoretimeField;

	private bool genMoretimeFieldSpecified;

	private int overtimeMethodField;

	private bool overtimeMethodFieldSpecified;

	private int overtimeWindowField;

	private bool overtimeWindowFieldSpecified;

	private bool autoPunchOutField;

	private bool autoPunchOutFieldSpecified;

	private bool lateChangeField;

	private bool lateChangeFieldSpecified;

	private int lateChangeUTField;

	private bool lateChangeUTFieldSpecified;

	private bool breakDayrestField;

	private bool breakDayrestFieldSpecified;

	private int breakDayrestUTField;

	private bool breakDayrestUTFieldSpecified;

	private bool breakWeekrestField;

	private bool breakWeekrestFieldSpecified;

	private int breakWeekrestUTField;

	private bool breakWeekrestUTFieldSpecified;

	private bool timeBankField;

	private bool timeBankFieldSpecified;

	private bool adjustForLeaveField;

	private bool adjustForLeaveFieldSpecified;

	private bool advancedTimeRulesField;

	private bool advancedTimeRulesFieldSpecified;

	private bool otCancelsUtField;

	private bool otCancelsUtFieldSpecified;

	private bool allowOverrideOverlappingField;

	private bool allowOverrideOverlappingFieldSpecified;

	private bool useSecondWeekendField;

	private bool useSecondWeekendFieldSpecified;

	private decimal utThresholdField;

	private bool utThresholdFieldSpecified;

	private int utThresholdTypeField;

	private bool utThresholdTypeFieldSpecified;

	private decimal dailyOvertimeHoursField;

	private bool dailyOvertimeHoursFieldSpecified;

	private decimal weeklyOvertimeHoursField;

	private bool weeklyOvertimeHoursFieldSpecified;

	private string noCostPeriodStartField;

	private string noCostPeriodEndField;

	private int balancePeriodTypeField;

	private bool balancePeriodTypeFieldSpecified;

	private decimal balancePeriodLengthField;

	private bool balancePeriodLengthFieldSpecified;

	private decimal balancePeriodHoursField;

	private bool balancePeriodHoursFieldSpecified;

	private DateTime balancePeriodStartDateField;

	private bool balancePeriodStartDateFieldSpecified;

	private bool useWorkDayModelField;

	private bool useWorkDayModelFieldSpecified;

	private bool isMainAgreementField;

	private bool isMainAgreementFieldSpecified;

	private string additionalField1Field;

	private string additionalField2Field;

	private string additionalField3Field;

	private string additionalField4Field;

	private string additionalField5Field;

	private bool useTempAvailField;

	private bool useTempAvailFieldSpecified;

	private bool useTempTimeRulesField;

	private bool useTempTimeRulesFieldSpecified;

	private bool useTempSalaryField;

	private bool useTempSalaryFieldSpecified;

	private bool useTempWorkTimeField;

	private bool useTempWorkTimeFieldSpecified;

	private bool useTempEmploymentRateField;

	private bool useTempEmploymentRateFieldSpecified;

	private bool useTempNominalDaysPerWeekField;

	private bool useTempNominalDaysPerWeekFieldSpecified;

	private bool useTempMonthHoursField;

	private bool useTempMonthHoursFieldSpecified;

	private bool useTempTandAField;

	private bool useTempTandAFieldSpecified;

	private bool useTemplateBalancePeriodField;

	private bool useTemplateBalancePeriodFieldSpecified;

	private bool useTempCostsField;

	private bool useTempCostsFieldSpecified;

	private bool useStdTimeRulesField;

	private bool useStdTimeRulesFieldSpecified;

	private AvailabilityTimePeriod[] availabilityField;

	private MonthlyHours[] monthlyHoursField;

	private agreementOvertimeMethod[] overtimeMethodsField;

	private punchRounding[] punchDeviationsField;

	private EmploymentRate[] employmentRatesAddField;

	private EmploymentRate[] employmentRatesReplaceField;

	private NominalDayPerWeek[] nominalDaysPerWeekAddField;

	private NominalDayPerWeek[] nominalDaysPerWeekReplaceField;

	private AgreementSalary[] salariesAddField;

	private AgreementSalary[] salariesReplaceField;

	private SalaryAdditionByYear[] salaryAdditionsAgeBasedAddField;

	private SalaryAdditionByYear[] salaryAdditionsAgeBasedReplaceField;

	private bool useTemplateAgeBasedSalaryAdditionField;

	private bool useTemplateAgeBasedSalaryAdditionFieldSpecified;

	private int ageBasedSalaryAdditionCalcModeField;

	private bool ageBasedSalaryAdditionCalcModeFieldSpecified;

	private SalaryAdditionByYear[] salaryAdditionsYearsWorkedBasedAddField;

	private SalaryAdditionByYear[] salaryAdditionsYearsWorkedBasedReplaceField;

	private bool useTemplateYearsWorkedBasedSalaryAdditionField;

	private bool useTemplateYearsWorkedBasedSalaryAdditionFieldSpecified;

	private int yearsWorkedBasedSalaryAdditionCalcModeField;

	private bool yearsWorkedBasedSalaryAdditionCalcModeFieldSpecified;

	private SalaryAdditionByDate[] salaryAdditionsDateBasedAddField;

	private SalaryAdditionByDate[] salaryAdditionsDateBasedReplaceField;

	private bool useTemplateBreakCreationRulesField;

	private bool useTemplateBreakCreationRulesFieldSpecified;

	private bool useStdBreakCreationRulesField;

	private bool useStdBreakCreationRulesFieldSpecified;

	private BreakCalculationRule[] breakCalculationRulesField;

	private MinShiftLength[] minShiftLenghtsField;

	private SocialCost[] socialCostsField;

	private string[] validationErrorsField;

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

	[SoapIgnore]
	public bool idSpecified
	{
		get
		{
			return idFieldSpecified;
		}
		set
		{
			idFieldSpecified = value;
		}
	}

	public string extAgreementId
	{
		get
		{
			return extAgreementIdField;
		}
		set
		{
			extAgreementIdField = value;
		}
	}

	public string name
	{
		get
		{
			return nameField;
		}
		set
		{
			nameField = value;
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

	[SoapIgnore]
	public bool restIdSpecified
	{
		get
		{
			return restIdFieldSpecified;
		}
		set
		{
			restIdFieldSpecified = value;
		}
	}

	public int employeeId
	{
		get
		{
			return employeeIdField;
		}
		set
		{
			employeeIdField = value;
		}
	}

	[SoapIgnore]
	public bool employeeIdSpecified
	{
		get
		{
			return employeeIdFieldSpecified;
		}
		set
		{
			employeeIdFieldSpecified = value;
		}
	}

	public string badgeNo
	{
		get
		{
			return badgeNoField;
		}
		set
		{
			badgeNoField = value;
		}
	}

	public int templateId
	{
		get
		{
			return templateIdField;
		}
		set
		{
			templateIdField = value;
		}
	}

	[SoapIgnore]
	public bool templateIdSpecified
	{
		get
		{
			return templateIdFieldSpecified;
		}
		set
		{
			templateIdFieldSpecified = value;
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

	public bool hourly
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

	[SoapIgnore]
	public bool hourlySpecified
	{
		get
		{
			return hourlyFieldSpecified;
		}
		set
		{
			hourlyFieldSpecified = value;
		}
	}

	[SoapElement(DataType = "date")]
	public DateTime fromDate
	{
		get
		{
			return fromDateField;
		}
		set
		{
			fromDateField = value;
		}
	}

	[SoapIgnore]
	public bool fromDateSpecified
	{
		get
		{
			return fromDateFieldSpecified;
		}
		set
		{
			fromDateFieldSpecified = value;
		}
	}

	[SoapElement(DataType = "date")]
	public DateTime toDate
	{
		get
		{
			return toDateField;
		}
		set
		{
			toDateField = value;
		}
	}

	[SoapIgnore]
	public bool toDateSpecified
	{
		get
		{
			return toDateFieldSpecified;
		}
		set
		{
			toDateFieldSpecified = value;
		}
	}

	public bool expires
	{
		get
		{
			return expiresField;
		}
		set
		{
			expiresField = value;
		}
	}

	[SoapIgnore]
	public bool expiresSpecified
	{
		get
		{
			return expiresFieldSpecified;
		}
		set
		{
			expiresFieldSpecified = value;
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

	[SoapIgnore]
	public bool schedulePeriodTypeSpecified
	{
		get
		{
			return schedulePeriodTypeFieldSpecified;
		}
		set
		{
			schedulePeriodTypeFieldSpecified = value;
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

	[SoapIgnore]
	public bool schedulePeriodLengthSpecified
	{
		get
		{
			return schedulePeriodLengthFieldSpecified;
		}
		set
		{
			schedulePeriodLengthFieldSpecified = value;
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

	[SoapIgnore]
	public bool schedulePeriodStartDateSpecified
	{
		get
		{
			return schedulePeriodStartDateFieldSpecified;
		}
		set
		{
			schedulePeriodStartDateFieldSpecified = value;
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

	[SoapIgnore]
	public bool fullEmploymentDaysSpecified
	{
		get
		{
			return fullEmploymentDaysFieldSpecified;
		}
		set
		{
			fullEmploymentDaysFieldSpecified = value;
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

	[SoapIgnore]
	public bool fullEmploymentDaysPerWeekSpecified
	{
		get
		{
			return fullEmploymentDaysPerWeekFieldSpecified;
		}
		set
		{
			fullEmploymentDaysPerWeekFieldSpecified = value;
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

	[SoapIgnore]
	public bool fullEmploymentHrsSpecified
	{
		get
		{
			return fullEmploymentHrsFieldSpecified;
		}
		set
		{
			fullEmploymentHrsFieldSpecified = value;
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

	[SoapIgnore]
	public bool excludeSundaysInWorkHoursSpecified
	{
		get
		{
			return excludeSundaysInWorkHoursFieldSpecified;
		}
		set
		{
			excludeSundaysInWorkHoursFieldSpecified = value;
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

	[SoapIgnore]
	public bool breakRoundingSpecified
	{
		get
		{
			return breakRoundingFieldSpecified;
		}
		set
		{
			breakRoundingFieldSpecified = value;
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

	[SoapIgnore]
	public bool breakIsWorkTimeSpecified
	{
		get
		{
			return breakIsWorkTimeFieldSpecified;
		}
		set
		{
			breakIsWorkTimeFieldSpecified = value;
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

	[SoapIgnore]
	public bool minHrsWeekSpecified
	{
		get
		{
			return minHrsWeekFieldSpecified;
		}
		set
		{
			minHrsWeekFieldSpecified = value;
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

	[SoapIgnore]
	public bool maxDaysSpecified
	{
		get
		{
			return maxDaysFieldSpecified;
		}
		set
		{
			maxDaysFieldSpecified = value;
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

	[SoapIgnore]
	public bool minFreeDaysSpecified
	{
		get
		{
			return minFreeDaysFieldSpecified;
		}
		set
		{
			minFreeDaysFieldSpecified = value;
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

	[SoapIgnore]
	public bool maxHourDaySpecified
	{
		get
		{
			return maxHourDayFieldSpecified;
		}
		set
		{
			maxHourDayFieldSpecified = value;
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

	[SoapIgnore]
	public bool maxHourWeekSpecified
	{
		get
		{
			return maxHourWeekFieldSpecified;
		}
		set
		{
			maxHourWeekFieldSpecified = value;
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

	[SoapIgnore]
	public bool minRestSpecified
	{
		get
		{
			return minRestFieldSpecified;
		}
		set
		{
			minRestFieldSpecified = value;
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

	[SoapIgnore]
	public bool minRestWeekSpecified
	{
		get
		{
			return minRestWeekFieldSpecified;
		}
		set
		{
			minRestWeekFieldSpecified = value;
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

	[SoapIgnore]
	public bool seqDaysSpecified
	{
		get
		{
			return seqDaysFieldSpecified;
		}
		set
		{
			seqDaysFieldSpecified = value;
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

	[SoapIgnore]
	public bool seqMaxDaysSpecified
	{
		get
		{
			return seqMaxDaysFieldSpecified;
		}
		set
		{
			seqMaxDaysFieldSpecified = value;
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

	[SoapIgnore]
	public bool seqMaxHrsSpecified
	{
		get
		{
			return seqMaxHrsFieldSpecified;
		}
		set
		{
			seqMaxHrsFieldSpecified = value;
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

	[SoapIgnore]
	public bool weekStartSpecified
	{
		get
		{
			return weekStartFieldSpecified;
		}
		set
		{
			weekStartFieldSpecified = value;
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

	[SoapIgnore]
	public bool atDayBreakSpecified
	{
		get
		{
			return atDayBreakFieldSpecified;
		}
		set
		{
			atDayBreakFieldSpecified = value;
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

	[SoapIgnore]
	public bool minBreakSpecified
	{
		get
		{
			return minBreakFieldSpecified;
		}
		set
		{
			minBreakFieldSpecified = value;
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

	[SoapIgnore]
	public bool maxBreakSpecified
	{
		get
		{
			return maxBreakFieldSpecified;
		}
		set
		{
			maxBreakFieldSpecified = value;
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

	[SoapIgnore]
	public bool weeksAvailSpecified
	{
		get
		{
			return weeksAvailFieldSpecified;
		}
		set
		{
			weeksAvailFieldSpecified = value;
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

	[SoapIgnore]
	public bool schedWeekEndsSpecified
	{
		get
		{
			return schedWeekEndsFieldSpecified;
		}
		set
		{
			schedWeekEndsFieldSpecified = value;
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

	[SoapIgnore]
	public bool minWeekEndYearSpecified
	{
		get
		{
			return minWeekEndYearFieldSpecified;
		}
		set
		{
			minWeekEndYearFieldSpecified = value;
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

	[SoapIgnore]
	public bool maxTimeWoBreakSpecified
	{
		get
		{
			return maxTimeWoBreakFieldSpecified;
		}
		set
		{
			maxTimeWoBreakFieldSpecified = value;
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

	[SoapIgnore]
	public bool scheduleLockPeriodSpecified
	{
		get
		{
			return scheduleLockPeriodFieldSpecified;
		}
		set
		{
			scheduleLockPeriodFieldSpecified = value;
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

	[SoapIgnore]
	public bool scheduleLockPeriodTypeSpecified
	{
		get
		{
			return scheduleLockPeriodTypeFieldSpecified;
		}
		set
		{
			scheduleLockPeriodTypeFieldSpecified = value;
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

	[SoapIgnore]
	public bool checkAvailabilitySpecified
	{
		get
		{
			return checkAvailabilityFieldSpecified;
		}
		set
		{
			checkAvailabilityFieldSpecified = value;
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

	[SoapIgnore]
	public bool punchTypeSpecified
	{
		get
		{
			return punchTypeFieldSpecified;
		}
		set
		{
			punchTypeFieldSpecified = value;
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

	[SoapIgnore]
	public bool appPayOnAbsenceSpecified
	{
		get
		{
			return appPayOnAbsenceFieldSpecified;
		}
		set
		{
			appPayOnAbsenceFieldSpecified = value;
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

	[SoapIgnore]
	public bool payOtimeSpecified
	{
		get
		{
			return payOtimeFieldSpecified;
		}
		set
		{
			payOtimeFieldSpecified = value;
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

	[SoapIgnore]
	public bool payUTSpecified
	{
		get
		{
			return payUTFieldSpecified;
		}
		set
		{
			payUTFieldSpecified = value;
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

	[SoapIgnore]
	public bool showIgnoreOtimeSpecified
	{
		get
		{
			return showIgnoreOtimeFieldSpecified;
		}
		set
		{
			showIgnoreOtimeFieldSpecified = value;
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

	[SoapIgnore]
	public bool showUnspecifiedLeaveInWPSpecified
	{
		get
		{
			return showUnspecifiedLeaveInWPFieldSpecified;
		}
		set
		{
			showUnspecifiedLeaveInWPFieldSpecified = value;
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

	[SoapIgnore]
	public bool allowPunchingOnSubshiftsSpecified
	{
		get
		{
			return allowPunchingOnSubshiftsFieldSpecified;
		}
		set
		{
			allowPunchingOnSubshiftsFieldSpecified = value;
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

	[SoapIgnore]
	public bool genMoretimeSpecified
	{
		get
		{
			return genMoretimeFieldSpecified;
		}
		set
		{
			genMoretimeFieldSpecified = value;
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

	[SoapIgnore]
	public bool overtimeMethodSpecified
	{
		get
		{
			return overtimeMethodFieldSpecified;
		}
		set
		{
			overtimeMethodFieldSpecified = value;
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

	[SoapIgnore]
	public bool overtimeWindowSpecified
	{
		get
		{
			return overtimeWindowFieldSpecified;
		}
		set
		{
			overtimeWindowFieldSpecified = value;
		}
	}

	public bool autoPunchOut
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

	[SoapIgnore]
	public bool autoPunchOutSpecified
	{
		get
		{
			return autoPunchOutFieldSpecified;
		}
		set
		{
			autoPunchOutFieldSpecified = value;
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

	[SoapIgnore]
	public bool lateChangeSpecified
	{
		get
		{
			return lateChangeFieldSpecified;
		}
		set
		{
			lateChangeFieldSpecified = value;
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

	[SoapIgnore]
	public bool lateChangeUTSpecified
	{
		get
		{
			return lateChangeUTFieldSpecified;
		}
		set
		{
			lateChangeUTFieldSpecified = value;
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

	[SoapIgnore]
	public bool breakDayrestSpecified
	{
		get
		{
			return breakDayrestFieldSpecified;
		}
		set
		{
			breakDayrestFieldSpecified = value;
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

	[SoapIgnore]
	public bool breakDayrestUTSpecified
	{
		get
		{
			return breakDayrestUTFieldSpecified;
		}
		set
		{
			breakDayrestUTFieldSpecified = value;
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

	[SoapIgnore]
	public bool breakWeekrestSpecified
	{
		get
		{
			return breakWeekrestFieldSpecified;
		}
		set
		{
			breakWeekrestFieldSpecified = value;
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

	[SoapIgnore]
	public bool breakWeekrestUTSpecified
	{
		get
		{
			return breakWeekrestUTFieldSpecified;
		}
		set
		{
			breakWeekrestUTFieldSpecified = value;
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

	[SoapIgnore]
	public bool timeBankSpecified
	{
		get
		{
			return timeBankFieldSpecified;
		}
		set
		{
			timeBankFieldSpecified = value;
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

	[SoapIgnore]
	public bool adjustForLeaveSpecified
	{
		get
		{
			return adjustForLeaveFieldSpecified;
		}
		set
		{
			adjustForLeaveFieldSpecified = value;
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

	[SoapIgnore]
	public bool advancedTimeRulesSpecified
	{
		get
		{
			return advancedTimeRulesFieldSpecified;
		}
		set
		{
			advancedTimeRulesFieldSpecified = value;
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

	[SoapIgnore]
	public bool otCancelsUtSpecified
	{
		get
		{
			return otCancelsUtFieldSpecified;
		}
		set
		{
			otCancelsUtFieldSpecified = value;
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

	[SoapIgnore]
	public bool allowOverrideOverlappingSpecified
	{
		get
		{
			return allowOverrideOverlappingFieldSpecified;
		}
		set
		{
			allowOverrideOverlappingFieldSpecified = value;
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

	[SoapIgnore]
	public bool useSecondWeekendSpecified
	{
		get
		{
			return useSecondWeekendFieldSpecified;
		}
		set
		{
			useSecondWeekendFieldSpecified = value;
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

	[SoapIgnore]
	public bool utThresholdSpecified
	{
		get
		{
			return utThresholdFieldSpecified;
		}
		set
		{
			utThresholdFieldSpecified = value;
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

	[SoapIgnore]
	public bool utThresholdTypeSpecified
	{
		get
		{
			return utThresholdTypeFieldSpecified;
		}
		set
		{
			utThresholdTypeFieldSpecified = value;
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

	[SoapIgnore]
	public bool dailyOvertimeHoursSpecified
	{
		get
		{
			return dailyOvertimeHoursFieldSpecified;
		}
		set
		{
			dailyOvertimeHoursFieldSpecified = value;
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

	[SoapIgnore]
	public bool weeklyOvertimeHoursSpecified
	{
		get
		{
			return weeklyOvertimeHoursFieldSpecified;
		}
		set
		{
			weeklyOvertimeHoursFieldSpecified = value;
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

	[SoapIgnore]
	public bool balancePeriodTypeSpecified
	{
		get
		{
			return balancePeriodTypeFieldSpecified;
		}
		set
		{
			balancePeriodTypeFieldSpecified = value;
		}
	}

	public decimal balancePeriodLength
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

	[SoapIgnore]
	public bool balancePeriodLengthSpecified
	{
		get
		{
			return balancePeriodLengthFieldSpecified;
		}
		set
		{
			balancePeriodLengthFieldSpecified = value;
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

	[SoapIgnore]
	public bool balancePeriodHoursSpecified
	{
		get
		{
			return balancePeriodHoursFieldSpecified;
		}
		set
		{
			balancePeriodHoursFieldSpecified = value;
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

	[SoapIgnore]
	public bool balancePeriodStartDateSpecified
	{
		get
		{
			return balancePeriodStartDateFieldSpecified;
		}
		set
		{
			balancePeriodStartDateFieldSpecified = value;
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

	[SoapIgnore]
	public bool useWorkDayModelSpecified
	{
		get
		{
			return useWorkDayModelFieldSpecified;
		}
		set
		{
			useWorkDayModelFieldSpecified = value;
		}
	}

	public bool isMainAgreement
	{
		get
		{
			return isMainAgreementField;
		}
		set
		{
			isMainAgreementField = value;
		}
	}

	[SoapIgnore]
	public bool isMainAgreementSpecified
	{
		get
		{
			return isMainAgreementFieldSpecified;
		}
		set
		{
			isMainAgreementFieldSpecified = value;
		}
	}

	public string additionalField1
	{
		get
		{
			return additionalField1Field;
		}
		set
		{
			additionalField1Field = value;
		}
	}

	public string additionalField2
	{
		get
		{
			return additionalField2Field;
		}
		set
		{
			additionalField2Field = value;
		}
	}

	public string additionalField3
	{
		get
		{
			return additionalField3Field;
		}
		set
		{
			additionalField3Field = value;
		}
	}

	public string additionalField4
	{
		get
		{
			return additionalField4Field;
		}
		set
		{
			additionalField4Field = value;
		}
	}

	public string additionalField5
	{
		get
		{
			return additionalField5Field;
		}
		set
		{
			additionalField5Field = value;
		}
	}

	public bool useTempAvail
	{
		get
		{
			return useTempAvailField;
		}
		set
		{
			useTempAvailField = value;
		}
	}

	[SoapIgnore]
	public bool useTempAvailSpecified
	{
		get
		{
			return useTempAvailFieldSpecified;
		}
		set
		{
			useTempAvailFieldSpecified = value;
		}
	}

	public bool useTempTimeRules
	{
		get
		{
			return useTempTimeRulesField;
		}
		set
		{
			useTempTimeRulesField = value;
		}
	}

	[SoapIgnore]
	public bool useTempTimeRulesSpecified
	{
		get
		{
			return useTempTimeRulesFieldSpecified;
		}
		set
		{
			useTempTimeRulesFieldSpecified = value;
		}
	}

	public bool useTempSalary
	{
		get
		{
			return useTempSalaryField;
		}
		set
		{
			useTempSalaryField = value;
		}
	}

	[SoapIgnore]
	public bool useTempSalarySpecified
	{
		get
		{
			return useTempSalaryFieldSpecified;
		}
		set
		{
			useTempSalaryFieldSpecified = value;
		}
	}

	public bool useTempWorkTime
	{
		get
		{
			return useTempWorkTimeField;
		}
		set
		{
			useTempWorkTimeField = value;
		}
	}

	[SoapIgnore]
	public bool useTempWorkTimeSpecified
	{
		get
		{
			return useTempWorkTimeFieldSpecified;
		}
		set
		{
			useTempWorkTimeFieldSpecified = value;
		}
	}

	public bool useTempEmploymentRate
	{
		get
		{
			return useTempEmploymentRateField;
		}
		set
		{
			useTempEmploymentRateField = value;
		}
	}

	[SoapIgnore]
	public bool useTempEmploymentRateSpecified
	{
		get
		{
			return useTempEmploymentRateFieldSpecified;
		}
		set
		{
			useTempEmploymentRateFieldSpecified = value;
		}
	}

	public bool useTempNominalDaysPerWeek
	{
		get
		{
			return useTempNominalDaysPerWeekField;
		}
		set
		{
			useTempNominalDaysPerWeekField = value;
		}
	}

	[SoapIgnore]
	public bool useTempNominalDaysPerWeekSpecified
	{
		get
		{
			return useTempNominalDaysPerWeekFieldSpecified;
		}
		set
		{
			useTempNominalDaysPerWeekFieldSpecified = value;
		}
	}

	public bool useTempMonthHours
	{
		get
		{
			return useTempMonthHoursField;
		}
		set
		{
			useTempMonthHoursField = value;
		}
	}

	[SoapIgnore]
	public bool useTempMonthHoursSpecified
	{
		get
		{
			return useTempMonthHoursFieldSpecified;
		}
		set
		{
			useTempMonthHoursFieldSpecified = value;
		}
	}

	public bool useTempTandA
	{
		get
		{
			return useTempTandAField;
		}
		set
		{
			useTempTandAField = value;
		}
	}

	[SoapIgnore]
	public bool useTempTandASpecified
	{
		get
		{
			return useTempTandAFieldSpecified;
		}
		set
		{
			useTempTandAFieldSpecified = value;
		}
	}

	public bool useTemplateBalancePeriod
	{
		get
		{
			return useTemplateBalancePeriodField;
		}
		set
		{
			useTemplateBalancePeriodField = value;
		}
	}

	[SoapIgnore]
	public bool useTemplateBalancePeriodSpecified
	{
		get
		{
			return useTemplateBalancePeriodFieldSpecified;
		}
		set
		{
			useTemplateBalancePeriodFieldSpecified = value;
		}
	}

	public bool useTempCosts
	{
		get
		{
			return useTempCostsField;
		}
		set
		{
			useTempCostsField = value;
		}
	}

	[SoapIgnore]
	public bool useTempCostsSpecified
	{
		get
		{
			return useTempCostsFieldSpecified;
		}
		set
		{
			useTempCostsFieldSpecified = value;
		}
	}

	public bool useStdTimeRules
	{
		get
		{
			return useStdTimeRulesField;
		}
		set
		{
			useStdTimeRulesField = value;
		}
	}

	[SoapIgnore]
	public bool useStdTimeRulesSpecified
	{
		get
		{
			return useStdTimeRulesFieldSpecified;
		}
		set
		{
			useStdTimeRulesFieldSpecified = value;
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

	public EmploymentRate[] employmentRatesAdd
	{
		get
		{
			return employmentRatesAddField;
		}
		set
		{
			employmentRatesAddField = value;
		}
	}

	public EmploymentRate[] employmentRatesReplace
	{
		get
		{
			return employmentRatesReplaceField;
		}
		set
		{
			employmentRatesReplaceField = value;
		}
	}

	public NominalDayPerWeek[] nominalDaysPerWeekAdd
	{
		get
		{
			return nominalDaysPerWeekAddField;
		}
		set
		{
			nominalDaysPerWeekAddField = value;
		}
	}

	public NominalDayPerWeek[] nominalDaysPerWeekReplace
	{
		get
		{
			return nominalDaysPerWeekReplaceField;
		}
		set
		{
			nominalDaysPerWeekReplaceField = value;
		}
	}

	public AgreementSalary[] salariesAdd
	{
		get
		{
			return salariesAddField;
		}
		set
		{
			salariesAddField = value;
		}
	}

	public AgreementSalary[] salariesReplace
	{
		get
		{
			return salariesReplaceField;
		}
		set
		{
			salariesReplaceField = value;
		}
	}

	public SalaryAdditionByYear[] salaryAdditionsAgeBasedAdd
	{
		get
		{
			return salaryAdditionsAgeBasedAddField;
		}
		set
		{
			salaryAdditionsAgeBasedAddField = value;
		}
	}

	public SalaryAdditionByYear[] salaryAdditionsAgeBasedReplace
	{
		get
		{
			return salaryAdditionsAgeBasedReplaceField;
		}
		set
		{
			salaryAdditionsAgeBasedReplaceField = value;
		}
	}

	public bool useTemplateAgeBasedSalaryAddition
	{
		get
		{
			return useTemplateAgeBasedSalaryAdditionField;
		}
		set
		{
			useTemplateAgeBasedSalaryAdditionField = value;
		}
	}

	[SoapIgnore]
	public bool useTemplateAgeBasedSalaryAdditionSpecified
	{
		get
		{
			return useTemplateAgeBasedSalaryAdditionFieldSpecified;
		}
		set
		{
			useTemplateAgeBasedSalaryAdditionFieldSpecified = value;
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

	public SalaryAdditionByYear[] salaryAdditionsYearsWorkedBasedAdd
	{
		get
		{
			return salaryAdditionsYearsWorkedBasedAddField;
		}
		set
		{
			salaryAdditionsYearsWorkedBasedAddField = value;
		}
	}

	public SalaryAdditionByYear[] salaryAdditionsYearsWorkedBasedReplace
	{
		get
		{
			return salaryAdditionsYearsWorkedBasedReplaceField;
		}
		set
		{
			salaryAdditionsYearsWorkedBasedReplaceField = value;
		}
	}

	public bool useTemplateYearsWorkedBasedSalaryAddition
	{
		get
		{
			return useTemplateYearsWorkedBasedSalaryAdditionField;
		}
		set
		{
			useTemplateYearsWorkedBasedSalaryAdditionField = value;
		}
	}

	[SoapIgnore]
	public bool useTemplateYearsWorkedBasedSalaryAdditionSpecified
	{
		get
		{
			return useTemplateYearsWorkedBasedSalaryAdditionFieldSpecified;
		}
		set
		{
			useTemplateYearsWorkedBasedSalaryAdditionFieldSpecified = value;
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

	public SalaryAdditionByDate[] salaryAdditionsDateBasedAdd
	{
		get
		{
			return salaryAdditionsDateBasedAddField;
		}
		set
		{
			salaryAdditionsDateBasedAddField = value;
		}
	}

	public SalaryAdditionByDate[] salaryAdditionsDateBasedReplace
	{
		get
		{
			return salaryAdditionsDateBasedReplaceField;
		}
		set
		{
			salaryAdditionsDateBasedReplaceField = value;
		}
	}

	public bool useTemplateBreakCreationRules
	{
		get
		{
			return useTemplateBreakCreationRulesField;
		}
		set
		{
			useTemplateBreakCreationRulesField = value;
		}
	}

	[SoapIgnore]
	public bool useTemplateBreakCreationRulesSpecified
	{
		get
		{
			return useTemplateBreakCreationRulesFieldSpecified;
		}
		set
		{
			useTemplateBreakCreationRulesFieldSpecified = value;
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

	public string[] validationErrors
	{
		get
		{
			return validationErrorsField;
		}
		set
		{
			validationErrorsField = value;
		}
	}
}
