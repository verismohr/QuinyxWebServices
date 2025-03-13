using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class standardBankHoliday
{
	private int idField;

	private string redDateField;

	private string descriptionField;

	private int oTypeField;

	private decimal reduxBefRedDayField;

	private int reduxBefRedDayTypeField;

	private decimal reduxRedDayField;

	private int reduxRedDayTypeField;

	private int countAsScheduledHoursField;

	private string countAsScheduledFromField;

	private string countAsScheduledToField;

	private int canScheduleTwoYearsField;

	private string[] noDatesField;

	private bankHolidaysSalaryTypeRule[] salaryTypeRulesField;

	private bankHolidayManualSalary[] manualSalariesField;

	private standardOvertime[] overtimesField;

	private int validityField;

	private int createLeaveIfScheduledField;

	private int createLeaveReasonIdField;

	private string onlyTheseUnitGroupsField;

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

	public string redDate
	{
		get
		{
			return redDateField;
		}
		set
		{
			redDateField = value;
		}
	}

	public string description
	{
		get
		{
			return descriptionField;
		}
		set
		{
			descriptionField = value;
		}
	}

	public int oType
	{
		get
		{
			return oTypeField;
		}
		set
		{
			oTypeField = value;
		}
	}

	public decimal reduxBefRedDay
	{
		get
		{
			return reduxBefRedDayField;
		}
		set
		{
			reduxBefRedDayField = value;
		}
	}

	public int reduxBefRedDayType
	{
		get
		{
			return reduxBefRedDayTypeField;
		}
		set
		{
			reduxBefRedDayTypeField = value;
		}
	}

	public decimal reduxRedDay
	{
		get
		{
			return reduxRedDayField;
		}
		set
		{
			reduxRedDayField = value;
		}
	}

	public int reduxRedDayType
	{
		get
		{
			return reduxRedDayTypeField;
		}
		set
		{
			reduxRedDayTypeField = value;
		}
	}

	public int countAsScheduledHours
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

	public string countAsScheduledFrom
	{
		get
		{
			return countAsScheduledFromField;
		}
		set
		{
			countAsScheduledFromField = value;
		}
	}

	public string countAsScheduledTo
	{
		get
		{
			return countAsScheduledToField;
		}
		set
		{
			countAsScheduledToField = value;
		}
	}

	public int canScheduleTwoYears
	{
		get
		{
			return canScheduleTwoYearsField;
		}
		set
		{
			canScheduleTwoYearsField = value;
		}
	}

	public string[] noDates
	{
		get
		{
			return noDatesField;
		}
		set
		{
			noDatesField = value;
		}
	}

	public bankHolidaysSalaryTypeRule[] salaryTypeRules
	{
		get
		{
			return salaryTypeRulesField;
		}
		set
		{
			salaryTypeRulesField = value;
		}
	}

	public bankHolidayManualSalary[] manualSalaries
	{
		get
		{
			return manualSalariesField;
		}
		set
		{
			manualSalariesField = value;
		}
	}

	public standardOvertime[] overtimes
	{
		get
		{
			return overtimesField;
		}
		set
		{
			overtimesField = value;
		}
	}

	public int validity
	{
		get
		{
			return validityField;
		}
		set
		{
			validityField = value;
		}
	}

	public int createLeaveIfScheduled
	{
		get
		{
			return createLeaveIfScheduledField;
		}
		set
		{
			createLeaveIfScheduledField = value;
		}
	}

	public int createLeaveReasonId
	{
		get
		{
			return createLeaveReasonIdField;
		}
		set
		{
			createLeaveReasonIdField = value;
		}
	}

	public string onlyTheseUnitGroups
	{
		get
		{
			return onlyTheseUnitGroupsField;
		}
		set
		{
			onlyTheseUnitGroupsField = value;
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
