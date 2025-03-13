using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class UpdateShiftType
{
	private string nameField;

	private int idField;

	private string shiftTypeExtIdField;

	private decimal costHourlyField;

	private string timeStartField;

	private string timeEndField;

	private int sectionIdField;

	private string breakStartField;

	private string breakEndField;

	private string breakStart2Field;

	private string breakEnd2Field;

	private string breakStart3Field;

	private string breakEnd3Field;

	private string breakStart4Field;

	private string breakEnd4Field;

	private string commentField;

	private int shiftTypeCatIdField;

	private Skill[] skillsField;

	private int productiveTimeField;

	private int costCentreIdField;

	private bool costCentreIdFieldSpecified;

	private string costCentreExtCodeField;

	private int projectIdField;

	private bool projectIdFieldSpecified;

	private string projectExtCodeField;

	private int accountIdField;

	private bool accountIdFieldSpecified;

	private string accountExtCodeField;

	private int bgColorField;

	private bool bgColorFieldSpecified;

	private int textColorField;

	private bool textColorFieldSpecified;

	private bool useColorsField;

	private bool useColorsFieldSpecified;

	private decimal costUT1Field;

	private bool costUT1FieldSpecified;

	private decimal costUT2Field;

	private bool costUT2FieldSpecified;

	private decimal costUT3Field;

	private bool costUT3FieldSpecified;

	private decimal costUT4Field;

	private bool costUT4FieldSpecified;

	private decimal costUT5Field;

	private bool costUT5FieldSpecified;

	private decimal costUT6Field;

	private bool costUT6FieldSpecified;

	private decimal costUT7Field;

	private bool costUT7FieldSpecified;

	private decimal costUT8Field;

	private bool costUT8FieldSpecified;

	private bool isActiveField;

	private bool isActiveFieldSpecified;

	private bool isFreeDayField;

	private bool isFreeDayFieldSpecified;

	private bool countPunchHoursField;

	private bool countPunchHoursFieldSpecified;

	private bool countScheduleHoursField;

	private bool countScheduleHoursFieldSpecified;

	private Task[] tasksField;

	private bool sharedToAllUnitsField;

	private bool sharedToAllUnitsFieldSpecified;

	private bool replaceField;

	private bool replaceFieldSpecified;

	private scheduleCategoryUnit[] scheduleCategoryUnitsField;

	private Tag[] tagsField;

	private string[] validationErrorsField;

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

	public string shiftTypeExtId
	{
		get
		{
			return shiftTypeExtIdField;
		}
		set
		{
			shiftTypeExtIdField = value;
		}
	}

	public decimal costHourly
	{
		get
		{
			return costHourlyField;
		}
		set
		{
			costHourlyField = value;
		}
	}

	public string timeStart
	{
		get
		{
			return timeStartField;
		}
		set
		{
			timeStartField = value;
		}
	}

	public string timeEnd
	{
		get
		{
			return timeEndField;
		}
		set
		{
			timeEndField = value;
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

	public string breakStart
	{
		get
		{
			return breakStartField;
		}
		set
		{
			breakStartField = value;
		}
	}

	public string breakEnd
	{
		get
		{
			return breakEndField;
		}
		set
		{
			breakEndField = value;
		}
	}

	public string breakStart2
	{
		get
		{
			return breakStart2Field;
		}
		set
		{
			breakStart2Field = value;
		}
	}

	public string breakEnd2
	{
		get
		{
			return breakEnd2Field;
		}
		set
		{
			breakEnd2Field = value;
		}
	}

	public string breakStart3
	{
		get
		{
			return breakStart3Field;
		}
		set
		{
			breakStart3Field = value;
		}
	}

	public string breakEnd3
	{
		get
		{
			return breakEnd3Field;
		}
		set
		{
			breakEnd3Field = value;
		}
	}

	public string breakStart4
	{
		get
		{
			return breakStart4Field;
		}
		set
		{
			breakStart4Field = value;
		}
	}

	public string breakEnd4
	{
		get
		{
			return breakEnd4Field;
		}
		set
		{
			breakEnd4Field = value;
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

	public int shiftTypeCatId
	{
		get
		{
			return shiftTypeCatIdField;
		}
		set
		{
			shiftTypeCatIdField = value;
		}
	}

	public Skill[] skills
	{
		get
		{
			return skillsField;
		}
		set
		{
			skillsField = value;
		}
	}

	public int productiveTime
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

	public int bgColor
	{
		get
		{
			return bgColorField;
		}
		set
		{
			bgColorField = value;
		}
	}

	[SoapIgnore]
	public bool bgColorSpecified
	{
		get
		{
			return bgColorFieldSpecified;
		}
		set
		{
			bgColorFieldSpecified = value;
		}
	}

	public int textColor
	{
		get
		{
			return textColorField;
		}
		set
		{
			textColorField = value;
		}
	}

	[SoapIgnore]
	public bool textColorSpecified
	{
		get
		{
			return textColorFieldSpecified;
		}
		set
		{
			textColorFieldSpecified = value;
		}
	}

	public bool useColors
	{
		get
		{
			return useColorsField;
		}
		set
		{
			useColorsField = value;
		}
	}

	[SoapIgnore]
	public bool useColorsSpecified
	{
		get
		{
			return useColorsFieldSpecified;
		}
		set
		{
			useColorsFieldSpecified = value;
		}
	}

	public decimal costUT1
	{
		get
		{
			return costUT1Field;
		}
		set
		{
			costUT1Field = value;
		}
	}

	[SoapIgnore]
	public bool costUT1Specified
	{
		get
		{
			return costUT1FieldSpecified;
		}
		set
		{
			costUT1FieldSpecified = value;
		}
	}

	public decimal costUT2
	{
		get
		{
			return costUT2Field;
		}
		set
		{
			costUT2Field = value;
		}
	}

	[SoapIgnore]
	public bool costUT2Specified
	{
		get
		{
			return costUT2FieldSpecified;
		}
		set
		{
			costUT2FieldSpecified = value;
		}
	}

	public decimal costUT3
	{
		get
		{
			return costUT3Field;
		}
		set
		{
			costUT3Field = value;
		}
	}

	[SoapIgnore]
	public bool costUT3Specified
	{
		get
		{
			return costUT3FieldSpecified;
		}
		set
		{
			costUT3FieldSpecified = value;
		}
	}

	public decimal costUT4
	{
		get
		{
			return costUT4Field;
		}
		set
		{
			costUT4Field = value;
		}
	}

	[SoapIgnore]
	public bool costUT4Specified
	{
		get
		{
			return costUT4FieldSpecified;
		}
		set
		{
			costUT4FieldSpecified = value;
		}
	}

	public decimal costUT5
	{
		get
		{
			return costUT5Field;
		}
		set
		{
			costUT5Field = value;
		}
	}

	[SoapIgnore]
	public bool costUT5Specified
	{
		get
		{
			return costUT5FieldSpecified;
		}
		set
		{
			costUT5FieldSpecified = value;
		}
	}

	public decimal costUT6
	{
		get
		{
			return costUT6Field;
		}
		set
		{
			costUT6Field = value;
		}
	}

	[SoapIgnore]
	public bool costUT6Specified
	{
		get
		{
			return costUT6FieldSpecified;
		}
		set
		{
			costUT6FieldSpecified = value;
		}
	}

	public decimal costUT7
	{
		get
		{
			return costUT7Field;
		}
		set
		{
			costUT7Field = value;
		}
	}

	[SoapIgnore]
	public bool costUT7Specified
	{
		get
		{
			return costUT7FieldSpecified;
		}
		set
		{
			costUT7FieldSpecified = value;
		}
	}

	public decimal costUT8
	{
		get
		{
			return costUT8Field;
		}
		set
		{
			costUT8Field = value;
		}
	}

	[SoapIgnore]
	public bool costUT8Specified
	{
		get
		{
			return costUT8FieldSpecified;
		}
		set
		{
			costUT8FieldSpecified = value;
		}
	}

	public bool isActive
	{
		get
		{
			return isActiveField;
		}
		set
		{
			isActiveField = value;
		}
	}

	[SoapIgnore]
	public bool isActiveSpecified
	{
		get
		{
			return isActiveFieldSpecified;
		}
		set
		{
			isActiveFieldSpecified = value;
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

	public bool countPunchHours
	{
		get
		{
			return countPunchHoursField;
		}
		set
		{
			countPunchHoursField = value;
		}
	}

	[SoapIgnore]
	public bool countPunchHoursSpecified
	{
		get
		{
			return countPunchHoursFieldSpecified;
		}
		set
		{
			countPunchHoursFieldSpecified = value;
		}
	}

	public bool countScheduleHours
	{
		get
		{
			return countScheduleHoursField;
		}
		set
		{
			countScheduleHoursField = value;
		}
	}

	[SoapIgnore]
	public bool countScheduleHoursSpecified
	{
		get
		{
			return countScheduleHoursFieldSpecified;
		}
		set
		{
			countScheduleHoursFieldSpecified = value;
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

	public bool sharedToAllUnits
	{
		get
		{
			return sharedToAllUnitsField;
		}
		set
		{
			sharedToAllUnitsField = value;
		}
	}

	[SoapIgnore]
	public bool sharedToAllUnitsSpecified
	{
		get
		{
			return sharedToAllUnitsFieldSpecified;
		}
		set
		{
			sharedToAllUnitsFieldSpecified = value;
		}
	}

	public bool replace
	{
		get
		{
			return replaceField;
		}
		set
		{
			replaceField = value;
		}
	}

	[SoapIgnore]
	public bool replaceSpecified
	{
		get
		{
			return replaceFieldSpecified;
		}
		set
		{
			replaceFieldSpecified = value;
		}
	}

	public scheduleCategoryUnit[] scheduleCategoryUnits
	{
		get
		{
			return scheduleCategoryUnitsField;
		}
		set
		{
			scheduleCategoryUnitsField = value;
		}
	}

	public Tag[] tags
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
