using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class Shift
{
	private string scheduleIdField;

	private DateTime begDateField;

	private DateTime endDateField;

	private string begTimeField;

	private string endTimeField;

	private string begBreakField;

	private string endBreakField;

	private string begBreak2Field;

	private string endBreak2Field;

	private string begBreak3Field;

	private string endBreak3Field;

	private string begBreak4Field;

	private string endBreak4Field;

	private string persIdField;

	private string badgeNoField;

	private string shiftCategoryIdField;

	private int agreementIdField;

	private string extScheduleIdField;

	private int deleteShiftField;

	private int sectionIdField;

	private string extSectionIdField;

	private string commentField;

	private bool countsAsScheduledHoursField;

	private bool countsAsScheduledHoursFieldSpecified;

	private bool isFreeDayField;

	private bool isFreeDayFieldSpecified;

	private string shiftTypeExtCodeField;

	private int costCentreIdField;

	private bool costCentreIdFieldSpecified;

	private string costCentreExtCodeField;

	private int projectIdField;

	private bool projectIdFieldSpecified;

	private string projectExtCodeField;

	private int accountIdField;

	private bool accountIdFieldSpecified;

	private string accountExtCodeField;

	private bool replaceTasksField;

	private bool replaceTasksFieldSpecified;

	private Task[] tasksField;

	private bool applyShiftTypeRulesField;

	private bool applyShiftTypeRulesFieldSpecified;

	private string[] validationErrorsField;

	public string scheduleId
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

	public string begTime
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

	public string endTime
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

	public string begBreak
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

	public string endBreak
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

	public string begBreak2
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

	public string endBreak2
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

	public string begBreak3
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

	public string endBreak3
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

	public string begBreak4
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

	public string endBreak4
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

	public string persId
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

	public string shiftCategoryId
	{
		get
		{
			return shiftCategoryIdField;
		}
		set
		{
			shiftCategoryIdField = value;
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

	public int deleteShift
	{
		get
		{
			return deleteShiftField;
		}
		set
		{
			deleteShiftField = value;
		}
	}

	public int sectionId
	{
		get
		{
			return sectionIdField;
		}
		set
		{
			sectionIdField = value;
		}
	}

	public string extSectionId
	{
		get
		{
			return extSectionIdField;
		}
		set
		{
			extSectionIdField = value;
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

	public bool countsAsScheduledHours
	{
		get
		{
			return countsAsScheduledHoursField;
		}
		set
		{
			countsAsScheduledHoursField = value;
		}
	}

	[SoapIgnore]
	public bool countsAsScheduledHoursSpecified
	{
		get
		{
			return countsAsScheduledHoursFieldSpecified;
		}
		set
		{
			countsAsScheduledHoursFieldSpecified = value;
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

	public int costCentreId
	{
		get
		{
			return costCentreIdField;
		}
		set
		{
			costCentreIdField = value;
		}
	}

	[SoapIgnore]
	public bool costCentreIdSpecified
	{
		get
		{
			return costCentreIdFieldSpecified;
		}
		set
		{
			costCentreIdFieldSpecified = value;
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

	public int projectId
	{
		get
		{
			return projectIdField;
		}
		set
		{
			projectIdField = value;
		}
	}

	[SoapIgnore]
	public bool projectIdSpecified
	{
		get
		{
			return projectIdFieldSpecified;
		}
		set
		{
			projectIdFieldSpecified = value;
		}
	}

	public string projectExtCode
	{
		get
		{
			return projectExtCodeField;
		}
		set
		{
			projectExtCodeField = value;
		}
	}

	public int accountId
	{
		get
		{
			return accountIdField;
		}
		set
		{
			accountIdField = value;
		}
	}

	[SoapIgnore]
	public bool accountIdSpecified
	{
		get
		{
			return accountIdFieldSpecified;
		}
		set
		{
			accountIdFieldSpecified = value;
		}
	}

	public string accountExtCode
	{
		get
		{
			return accountExtCodeField;
		}
		set
		{
			accountExtCodeField = value;
		}
	}

	public bool replaceTasks
	{
		get
		{
			return replaceTasksField;
		}
		set
		{
			replaceTasksField = value;
		}
	}

	[SoapIgnore]
	public bool replaceTasksSpecified
	{
		get
		{
			return replaceTasksFieldSpecified;
		}
		set
		{
			replaceTasksFieldSpecified = value;
		}
	}

	public Task[] tasks
	{
		get
		{
			return tasksField;
		}
		set
		{
			tasksField = value;
		}
	}

	public bool applyShiftTypeRules
	{
		get
		{
			return applyShiftTypeRulesField;
		}
		set
		{
			applyShiftTypeRulesField = value;
		}
	}

	[SoapIgnore]
	public bool applyShiftTypeRulesSpecified
	{
		get
		{
			return applyShiftTypeRulesFieldSpecified;
		}
		set
		{
			applyShiftTypeRulesFieldSpecified = value;
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
