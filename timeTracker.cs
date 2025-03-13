using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class timeTracker
{
	private string badgeNoField;

	private int userIdField;

	private int timeTrackerIdField;

	private int periodField;

	private bool periodFieldSpecified;

	private int operationField;

	private decimal valueField;

	private string dateField;

	private bool replaceTimeTrackerField;

	private bool replaceTimeTrackerFieldSpecified;

	private string[] validationErrorsField;

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

	public int userId
	{
		get
		{
			return userIdField;
		}
		set
		{
			userIdField = value;
		}
	}

	public int timeTrackerId
	{
		get
		{
			return timeTrackerIdField;
		}
		set
		{
			timeTrackerIdField = value;
		}
	}

	public int period
	{
		get
		{
			return periodField;
		}
		set
		{
			periodField = value;
		}
	}

	[SoapIgnore]
	public bool periodSpecified
	{
		get
		{
			return periodFieldSpecified;
		}
		set
		{
			periodFieldSpecified = value;
		}
	}

	public int operation
	{
		get
		{
			return operationField;
		}
		set
		{
			operationField = value;
		}
	}

	public decimal value
	{
		get
		{
			return valueField;
		}
		set
		{
			valueField = value;
		}
	}

	public string date
	{
		get
		{
			return dateField;
		}
		set
		{
			dateField = value;
		}
	}

	public bool replaceTimeTracker
	{
		get
		{
			return replaceTimeTrackerField;
		}
		set
		{
			replaceTimeTrackerField = value;
		}
	}

	[SoapIgnore]
	public bool replaceTimeTrackerSpecified
	{
		get
		{
			return replaceTimeTrackerFieldSpecified;
		}
		set
		{
			replaceTimeTrackerFieldSpecified = value;
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
