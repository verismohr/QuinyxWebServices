using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class ScheduleV3
{
	private int restIdField;

	private DateTime begDateField;

	private DateTime begTimeField;

	private DateTime endDateField;

	private DateTime endTimeField;

	private int breakTypeField;

	private DateTime begBreakField;

	private DateTime endBreakField;

	private DateTime begBreak2Field;

	private DateTime endBreak2Field;

	private DateTime begBreak3Field;

	private DateTime endBreak3Field;

	private DateTime begBreak4Field;

	private DateTime endBreak4Field;

	private int persIdField;

	private string badgeNoField;

	private int statusField;

	private int grabbAbleField;

	private int grabbIdField;

	private int approvedField;

	private int managerIdField;

	private int categoryIdField;

	private string categoryNameField;

	private string commentField;

	private int sectionField;

	private string sectionNameField;

	private decimal hoursField;

	private int fixSchedIdField;

	private int shiftChangedField;

	private int costCentreField;

	private int accountNoField;

	private int projectNoField;

	private string unitNameField;

	private string accountNoExtCodeField;

	private string costCentreExtCodeField;

	private string projectNoExtCodeField;

	private string salaryTypeExtCodeField;

	private string decisionNoField;

	private string customerNoField;

	private string agrmntAdditionalField1Field;

	private string agrmntAdditionalField2Field;

	private string agrmntAdditionalField3Field;

	private string agrmntAdditionalField4Field;

	private string agrmntAdditionalField5Field;

	private DateTime agrmntPeriodStartField;

	private int agrmntPeriodTypeField;

	private int agrmntPeriodLengthField;

	private decimal agrmntWorkingHoursField;

	private int udf_value_idField;

	private int orgScheduleIdField;

	private int leaveIdField;

	private string leaveExtCodeField;

	private bool productiveTimeField;

	private string shiftTypeExtCodeField;

	private DateTime tsField;

	private int scheduleIdField;

	private bool scheduleIdFieldSpecified;

	private int leaveReasonIdField;

	private bool leaveReasonIdFieldSpecified;

	private int absenceScheduleIdField;

	private bool absenceScheduleIdFieldSpecified;

	private int agreementIdField;

	private int agreementTemplateIdField;

	private bool hourlyEmployedField;

	private bool absenceShiftField;

	private decimal unassignedShiftCostField;

	private bool unassignedShiftCostFieldSpecified;

	private decimal netCostField;

	private bool netCostFieldSpecified;

	private decimal absenceCostField;

	private bool absenceCostFieldSpecified;

	private decimal socialCostField;

	private bool socialCostFieldSpecified;

	private decimal totalCostField;

	private bool totalCostFieldSpecified;

	private ShiftRequest[] shiftRequestsField;

	private int fixSchedOwnerEmployeeIdField;

	private bool fixSchedOwnerEmployeeIdFieldSpecified;

	private string fixSchedOwnerBadgeNoField;

	private bool approvedLeaveField;

	private bool approvedLeaveFieldSpecified;

	private bool countAsScheduledHoursField;

	private bool countAsScheduledHoursFieldSpecified;

	private bool approvedLeaveByEmployeeField;

	private bool approvedLeaveByEmployeeFieldSpecified;

	private SubShift[] subShiftsField;

	private ShiftCategoriesTag[] tagsField;

	private string extScheduleIdField;

	private int dayCountField;

	private bool countAsWorkedHoursField;

	private bool countAsWorkedHoursFieldSpecified;

	private bool isFreeDayField;

	private bool isFreeDayFieldSpecified;

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

	[SoapElement(DataType = "date")]
	public DateTime begDate
	{
		get
		{
			return begDateField;
		}
		set
		{
			begDateField = value;
		}
	}

	[SoapElement(DataType = "time")]
	public DateTime begTime
	{
		get
		{
			return begTimeField;
		}
		set
		{
			begTimeField = value;
		}
	}

	[SoapElement(DataType = "date")]
	public DateTime endDate
	{
		get
		{
			return endDateField;
		}
		set
		{
			endDateField = value;
		}
	}

	[SoapElement(DataType = "time")]
	public DateTime endTime
	{
		get
		{
			return endTimeField;
		}
		set
		{
			endTimeField = value;
		}
	}

	public int breakType
	{
		get
		{
			return breakTypeField;
		}
		set
		{
			breakTypeField = value;
		}
	}

	[SoapElement(DataType = "time")]
	public DateTime begBreak
	{
		get
		{
			return begBreakField;
		}
		set
		{
			begBreakField = value;
		}
	}

	[SoapElement(DataType = "time")]
	public DateTime endBreak
	{
		get
		{
			return endBreakField;
		}
		set
		{
			endBreakField = value;
		}
	}

	[SoapElement(DataType = "time")]
	public DateTime begBreak2
	{
		get
		{
			return begBreak2Field;
		}
		set
		{
			begBreak2Field = value;
		}
	}

	[SoapElement(DataType = "time")]
	public DateTime endBreak2
	{
		get
		{
			return endBreak2Field;
		}
		set
		{
			endBreak2Field = value;
		}
	}

	[SoapElement(DataType = "time")]
	public DateTime begBreak3
	{
		get
		{
			return begBreak3Field;
		}
		set
		{
			begBreak3Field = value;
		}
	}

	[SoapElement(DataType = "time")]
	public DateTime endBreak3
	{
		get
		{
			return endBreak3Field;
		}
		set
		{
			endBreak3Field = value;
		}
	}

	[SoapElement(DataType = "time")]
	public DateTime begBreak4
	{
		get
		{
			return begBreak4Field;
		}
		set
		{
			begBreak4Field = value;
		}
	}

	[SoapElement(DataType = "time")]
	public DateTime endBreak4
	{
		get
		{
			return endBreak4Field;
		}
		set
		{
			endBreak4Field = value;
		}
	}

	public int persId
	{
		get
		{
			return persIdField;
		}
		set
		{
			persIdField = value;
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

	public int status
	{
		get
		{
			return statusField;
		}
		set
		{
			statusField = value;
		}
	}

	public int grabbAble
	{
		get
		{
			return grabbAbleField;
		}
		set
		{
			grabbAbleField = value;
		}
	}

	public int grabbId
	{
		get
		{
			return grabbIdField;
		}
		set
		{
			grabbIdField = value;
		}
	}

	public int approved
	{
		get
		{
			return approvedField;
		}
		set
		{
			approvedField = value;
		}
	}

	public int managerId
	{
		get
		{
			return managerIdField;
		}
		set
		{
			managerIdField = value;
		}
	}

	public int categoryId
	{
		get
		{
			return categoryIdField;
		}
		set
		{
			categoryIdField = value;
		}
	}

	public string categoryName
	{
		get
		{
			return categoryNameField;
		}
		set
		{
			categoryNameField = value;
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

	public int section
	{
		get
		{
			return sectionField;
		}
		set
		{
			sectionField = value;
		}
	}

	public string sectionName
	{
		get
		{
			return sectionNameField;
		}
		set
		{
			sectionNameField = value;
		}
	}

	public decimal hours
	{
		get
		{
			return hoursField;
		}
		set
		{
			hoursField = value;
		}
	}

	public int fixSchedId
	{
		get
		{
			return fixSchedIdField;
		}
		set
		{
			fixSchedIdField = value;
		}
	}

	public int shiftChanged
	{
		get
		{
			return shiftChangedField;
		}
		set
		{
			shiftChangedField = value;
		}
	}

	public int costCentre
	{
		get
		{
			return costCentreField;
		}
		set
		{
			costCentreField = value;
		}
	}

	public int accountNo
	{
		get
		{
			return accountNoField;
		}
		set
		{
			accountNoField = value;
		}
	}

	public int projectNo
	{
		get
		{
			return projectNoField;
		}
		set
		{
			projectNoField = value;
		}
	}

	public string unitName
	{
		get
		{
			return unitNameField;
		}
		set
		{
			unitNameField = value;
		}
	}

	public string accountNoExtCode
	{
		get
		{
			return accountNoExtCodeField;
		}
		set
		{
			accountNoExtCodeField = value;
		}
	}

	public string costCentreExtCode
	{
		get
		{
			return costCentreExtCodeField;
		}
		set
		{
			costCentreExtCodeField = value;
		}
	}

	public string projectNoExtCode
	{
		get
		{
			return projectNoExtCodeField;
		}
		set
		{
			projectNoExtCodeField = value;
		}
	}

	public string salaryTypeExtCode
	{
		get
		{
			return salaryTypeExtCodeField;
		}
		set
		{
			salaryTypeExtCodeField = value;
		}
	}

	public string decisionNo
	{
		get
		{
			return decisionNoField;
		}
		set
		{
			decisionNoField = value;
		}
	}

	public string customerNo
	{
		get
		{
			return customerNoField;
		}
		set
		{
			customerNoField = value;
		}
	}

	public string agrmntAdditionalField1
	{
		get
		{
			return agrmntAdditionalField1Field;
		}
		set
		{
			agrmntAdditionalField1Field = value;
		}
	}

	public string agrmntAdditionalField2
	{
		get
		{
			return agrmntAdditionalField2Field;
		}
		set
		{
			agrmntAdditionalField2Field = value;
		}
	}

	public string agrmntAdditionalField3
	{
		get
		{
			return agrmntAdditionalField3Field;
		}
		set
		{
			agrmntAdditionalField3Field = value;
		}
	}

	public string agrmntAdditionalField4
	{
		get
		{
			return agrmntAdditionalField4Field;
		}
		set
		{
			agrmntAdditionalField4Field = value;
		}
	}

	public string agrmntAdditionalField5
	{
		get
		{
			return agrmntAdditionalField5Field;
		}
		set
		{
			agrmntAdditionalField5Field = value;
		}
	}

	[SoapElement(DataType = "date")]
	public DateTime agrmntPeriodStart
	{
		get
		{
			return agrmntPeriodStartField;
		}
		set
		{
			agrmntPeriodStartField = value;
		}
	}

	public int agrmntPeriodType
	{
		get
		{
			return agrmntPeriodTypeField;
		}
		set
		{
			agrmntPeriodTypeField = value;
		}
	}

	public int agrmntPeriodLength
	{
		get
		{
			return agrmntPeriodLengthField;
		}
		set
		{
			agrmntPeriodLengthField = value;
		}
	}

	public decimal agrmntWorkingHours
	{
		get
		{
			return agrmntWorkingHoursField;
		}
		set
		{
			agrmntWorkingHoursField = value;
		}
	}

	public int udf_value_id
	{
		get
		{
			return udf_value_idField;
		}
		set
		{
			udf_value_idField = value;
		}
	}

	public int orgScheduleId
	{
		get
		{
			return orgScheduleIdField;
		}
		set
		{
			orgScheduleIdField = value;
		}
	}

	public int leaveId
	{
		get
		{
			return leaveIdField;
		}
		set
		{
			leaveIdField = value;
		}
	}

	public string leaveExtCode
	{
		get
		{
			return leaveExtCodeField;
		}
		set
		{
			leaveExtCodeField = value;
		}
	}

	public bool productiveTime
	{
		get
		{
			return productiveTimeField;
		}
		set
		{
			productiveTimeField = value;
		}
	}

	public string shiftTypeExtCode
	{
		get
		{
			return shiftTypeExtCodeField;
		}
		set
		{
			shiftTypeExtCodeField = value;
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

	public int scheduleId
	{
		get
		{
			return scheduleIdField;
		}
		set
		{
			scheduleIdField = value;
		}
	}

	[SoapIgnore]
	public bool scheduleIdSpecified
	{
		get
		{
			return scheduleIdFieldSpecified;
		}
		set
		{
			scheduleIdFieldSpecified = value;
		}
	}

	public int leaveReasonId
	{
		get
		{
			return leaveReasonIdField;
		}
		set
		{
			leaveReasonIdField = value;
		}
	}

	[SoapIgnore]
	public bool leaveReasonIdSpecified
	{
		get
		{
			return leaveReasonIdFieldSpecified;
		}
		set
		{
			leaveReasonIdFieldSpecified = value;
		}
	}

	public int absenceScheduleId
	{
		get
		{
			return absenceScheduleIdField;
		}
		set
		{
			absenceScheduleIdField = value;
		}
	}

	[SoapIgnore]
	public bool absenceScheduleIdSpecified
	{
		get
		{
			return absenceScheduleIdFieldSpecified;
		}
		set
		{
			absenceScheduleIdFieldSpecified = value;
		}
	}

	public int agreementId
	{
		get
		{
			return agreementIdField;
		}
		set
		{
			agreementIdField = value;
		}
	}

	public int agreementTemplateId
	{
		get
		{
			return agreementTemplateIdField;
		}
		set
		{
			agreementTemplateIdField = value;
		}
	}

	public bool hourlyEmployed
	{
		get
		{
			return hourlyEmployedField;
		}
		set
		{
			hourlyEmployedField = value;
		}
	}

	public bool absenceShift
	{
		get
		{
			return absenceShiftField;
		}
		set
		{
			absenceShiftField = value;
		}
	}

	public decimal unassignedShiftCost
	{
		get
		{
			return unassignedShiftCostField;
		}
		set
		{
			unassignedShiftCostField = value;
		}
	}

	[SoapIgnore]
	public bool unassignedShiftCostSpecified
	{
		get
		{
			return unassignedShiftCostFieldSpecified;
		}
		set
		{
			unassignedShiftCostFieldSpecified = value;
		}
	}

	public decimal netCost
	{
		get
		{
			return netCostField;
		}
		set
		{
			netCostField = value;
		}
	}

	[SoapIgnore]
	public bool netCostSpecified
	{
		get
		{
			return netCostFieldSpecified;
		}
		set
		{
			netCostFieldSpecified = value;
		}
	}

	public decimal absenceCost
	{
		get
		{
			return absenceCostField;
		}
		set
		{
			absenceCostField = value;
		}
	}

	[SoapIgnore]
	public bool absenceCostSpecified
	{
		get
		{
			return absenceCostFieldSpecified;
		}
		set
		{
			absenceCostFieldSpecified = value;
		}
	}

	public decimal socialCost
	{
		get
		{
			return socialCostField;
		}
		set
		{
			socialCostField = value;
		}
	}

	[SoapIgnore]
	public bool socialCostSpecified
	{
		get
		{
			return socialCostFieldSpecified;
		}
		set
		{
			socialCostFieldSpecified = value;
		}
	}

	public decimal totalCost
	{
		get
		{
			return totalCostField;
		}
		set
		{
			totalCostField = value;
		}
	}

	[SoapIgnore]
	public bool totalCostSpecified
	{
		get
		{
			return totalCostFieldSpecified;
		}
		set
		{
			totalCostFieldSpecified = value;
		}
	}

	public ShiftRequest[] shiftRequests
	{
		get
		{
			return shiftRequestsField;
		}
		set
		{
			shiftRequestsField = value;
		}
	}

	public int fixSchedOwnerEmployeeId
	{
		get
		{
			return fixSchedOwnerEmployeeIdField;
		}
		set
		{
			fixSchedOwnerEmployeeIdField = value;
		}
	}

	[SoapIgnore]
	public bool fixSchedOwnerEmployeeIdSpecified
	{
		get
		{
			return fixSchedOwnerEmployeeIdFieldSpecified;
		}
		set
		{
			fixSchedOwnerEmployeeIdFieldSpecified = value;
		}
	}

	public string fixSchedOwnerBadgeNo
	{
		get
		{
			return fixSchedOwnerBadgeNoField;
		}
		set
		{
			fixSchedOwnerBadgeNoField = value;
		}
	}

	public bool approvedLeave
	{
		get
		{
			return approvedLeaveField;
		}
		set
		{
			approvedLeaveField = value;
		}
	}

	[SoapIgnore]
	public bool approvedLeaveSpecified
	{
		get
		{
			return approvedLeaveFieldSpecified;
		}
		set
		{
			approvedLeaveFieldSpecified = value;
		}
	}

	public bool countAsScheduledHours
	{
		get
		{
			return countAsScheduledHoursField;
		}
		set
		{
			countAsScheduledHoursField = value;
		}
	}

	[SoapIgnore]
	public bool countAsScheduledHoursSpecified
	{
		get
		{
			return countAsScheduledHoursFieldSpecified;
		}
		set
		{
			countAsScheduledHoursFieldSpecified = value;
		}
	}

	public bool approvedLeaveByEmployee
	{
		get
		{
			return approvedLeaveByEmployeeField;
		}
		set
		{
			approvedLeaveByEmployeeField = value;
		}
	}

	[SoapIgnore]
	public bool approvedLeaveByEmployeeSpecified
	{
		get
		{
			return approvedLeaveByEmployeeFieldSpecified;
		}
		set
		{
			approvedLeaveByEmployeeFieldSpecified = value;
		}
	}

	public SubShift[] subShifts
	{
		get
		{
			return subShiftsField;
		}
		set
		{
			subShiftsField = value;
		}
	}

	public ShiftCategoriesTag[] tags
	{
		get
		{
			return tagsField;
		}
		set
		{
			tagsField = value;
		}
	}

	public string extScheduleId
	{
		get
		{
			return extScheduleIdField;
		}
		set
		{
			extScheduleIdField = value;
		}
	}

	public int dayCount
	{
		get
		{
			return dayCountField;
		}
		set
		{
			dayCountField = value;
		}
	}

	public bool countAsWorkedHours
	{
		get
		{
			return countAsWorkedHoursField;
		}
		set
		{
			countAsWorkedHoursField = value;
		}
	}

	[SoapIgnore]
	public bool countAsWorkedHoursSpecified
	{
		get
		{
			return countAsWorkedHoursFieldSpecified;
		}
		set
		{
			countAsWorkedHoursFieldSpecified = value;
		}
	}

	public bool isFreeDay
	{
		get
		{
			return isFreeDayField;
		}
		set
		{
			isFreeDayField = value;
		}
	}

	[SoapIgnore]
	public bool isFreeDaySpecified
	{
		get
		{
			return isFreeDayFieldSpecified;
		}
		set
		{
			isFreeDayFieldSpecified = value;
		}
	}
}
