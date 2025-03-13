using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class OvertimeMethod
{
	private int idField;

	private bool idFieldSpecified;

	private string nameField;

	private int typeField;

	private bool typeFieldSpecified;

	private int baseField;

	private bool baseFieldSpecified;

	private int periodTypeField;

	private bool periodTypeFieldSpecified;

	private DateTime startDateField;

	private bool startDateFieldSpecified;

	private int periodLengthField;

	private bool periodLengthFieldSpecified;

	private decimal hoursField;

	private bool hoursFieldSpecified;

	private bool countUpwardsField;

	private bool countUpwardsFieldSpecified;

	private int thresholdTypeField;

	private bool thresholdTypeFieldSpecified;

	private decimal thresholdHoursField;

	private bool thresholdHoursFieldSpecified;

	private int thresholdLengthField;

	private bool thresholdLengthFieldSpecified;

	private DateTime thresholdStartDateField;

	private bool thresholdStartDateFieldSpecified;

	private int otLevelTypeField;

	private bool otLevelTypeFieldSpecified;

	private otLevel[] otLevelsField;

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

	public int type
	{
		get
		{
			return typeField;
		}
		set
		{
			typeField = value;
		}
	}

	[SoapIgnore]
	public bool typeSpecified
	{
		get
		{
			return typeFieldSpecified;
		}
		set
		{
			typeFieldSpecified = value;
		}
	}

	public int @base
	{
		get
		{
			return baseField;
		}
		set
		{
			baseField = value;
		}
	}

	[SoapIgnore]
	public bool baseSpecified
	{
		get
		{
			return baseFieldSpecified;
		}
		set
		{
			baseFieldSpecified = value;
		}
	}

	public int periodType
	{
		get
		{
			return periodTypeField;
		}
		set
		{
			periodTypeField = value;
		}
	}

	[SoapIgnore]
	public bool periodTypeSpecified
	{
		get
		{
			return periodTypeFieldSpecified;
		}
		set
		{
			periodTypeFieldSpecified = value;
		}
	}

	[SoapElement(DataType = "date")]
	public DateTime startDate
	{
		get
		{
			return startDateField;
		}
		set
		{
			startDateField = value;
		}
	}

	[SoapIgnore]
	public bool startDateSpecified
	{
		get
		{
			return startDateFieldSpecified;
		}
		set
		{
			startDateFieldSpecified = value;
		}
	}

	public int periodLength
	{
		get
		{
			return periodLengthField;
		}
		set
		{
			periodLengthField = value;
		}
	}

	[SoapIgnore]
	public bool periodLengthSpecified
	{
		get
		{
			return periodLengthFieldSpecified;
		}
		set
		{
			periodLengthFieldSpecified = value;
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

	[SoapIgnore]
	public bool hoursSpecified
	{
		get
		{
			return hoursFieldSpecified;
		}
		set
		{
			hoursFieldSpecified = value;
		}
	}

	public bool countUpwards
	{
		get
		{
			return countUpwardsField;
		}
		set
		{
			countUpwardsField = value;
		}
	}

	[SoapIgnore]
	public bool countUpwardsSpecified
	{
		get
		{
			return countUpwardsFieldSpecified;
		}
		set
		{
			countUpwardsFieldSpecified = value;
		}
	}

	public int thresholdType
	{
		get
		{
			return thresholdTypeField;
		}
		set
		{
			thresholdTypeField = value;
		}
	}

	[SoapIgnore]
	public bool thresholdTypeSpecified
	{
		get
		{
			return thresholdTypeFieldSpecified;
		}
		set
		{
			thresholdTypeFieldSpecified = value;
		}
	}

	public decimal thresholdHours
	{
		get
		{
			return thresholdHoursField;
		}
		set
		{
			thresholdHoursField = value;
		}
	}

	[SoapIgnore]
	public bool thresholdHoursSpecified
	{
		get
		{
			return thresholdHoursFieldSpecified;
		}
		set
		{
			thresholdHoursFieldSpecified = value;
		}
	}

	public int thresholdLength
	{
		get
		{
			return thresholdLengthField;
		}
		set
		{
			thresholdLengthField = value;
		}
	}

	[SoapIgnore]
	public bool thresholdLengthSpecified
	{
		get
		{
			return thresholdLengthFieldSpecified;
		}
		set
		{
			thresholdLengthFieldSpecified = value;
		}
	}

	[SoapElement(DataType = "date")]
	public DateTime thresholdStartDate
	{
		get
		{
			return thresholdStartDateField;
		}
		set
		{
			thresholdStartDateField = value;
		}
	}

	[SoapIgnore]
	public bool thresholdStartDateSpecified
	{
		get
		{
			return thresholdStartDateFieldSpecified;
		}
		set
		{
			thresholdStartDateFieldSpecified = value;
		}
	}

	public int otLevelType
	{
		get
		{
			return otLevelTypeField;
		}
		set
		{
			otLevelTypeField = value;
		}
	}

	[SoapIgnore]
	public bool otLevelTypeSpecified
	{
		get
		{
			return otLevelTypeFieldSpecified;
		}
		set
		{
			otLevelTypeFieldSpecified = value;
		}
	}

	public otLevel[] otLevels
	{
		get
		{
			return otLevelsField;
		}
		set
		{
			otLevelsField = value;
		}
	}
}
