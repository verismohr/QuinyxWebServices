using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class BreakCalculationRule
{
	private int weekdayField;

	private bool weekdayFieldSpecified;

	private decimal hoursField;

	private int breakMinutesField;

	private int breakTypeField;

	private bool breakTypeFieldSpecified;

	private int distributeField;

	private int noOfBreaksField;

	private decimal afterHoursField;

	private bool afterHoursFieldSpecified;

	public int weekday
	{
		get
		{
			return weekdayField;
		}
		set
		{
			weekdayField = value;
		}
	}

	[SoapIgnore]
	public bool weekdaySpecified
	{
		get
		{
			return weekdayFieldSpecified;
		}
		set
		{
			weekdayFieldSpecified = value;
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

	public int breakMinutes
	{
		get
		{
			return breakMinutesField;
		}
		set
		{
			breakMinutesField = value;
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

	[SoapIgnore]
	public bool breakTypeSpecified
	{
		get
		{
			return breakTypeFieldSpecified;
		}
		set
		{
			breakTypeFieldSpecified = value;
		}
	}

	public int distribute
	{
		get
		{
			return distributeField;
		}
		set
		{
			distributeField = value;
		}
	}

	public int noOfBreaks
	{
		get
		{
			return noOfBreaksField;
		}
		set
		{
			noOfBreaksField = value;
		}
	}

	public decimal afterHours
	{
		get
		{
			return afterHoursField;
		}
		set
		{
			afterHoursField = value;
		}
	}

	[SoapIgnore]
	public bool afterHoursSpecified
	{
		get
		{
			return afterHoursFieldSpecified;
		}
		set
		{
			afterHoursFieldSpecified = value;
		}
	}
}
