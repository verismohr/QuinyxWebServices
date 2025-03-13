using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class EmployeeTime
{
	private string badgeNoField;

	private string dateField;

	private decimal workedHoursField;

	private decimal leaveHoursField;

	private string leaveReasonField;

	private string costCentreField;

	private string lastPunchOutField;

	private string agreementNameField;

	private string lastModifiedField;

	private string costCentreHomeUnitField;

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

	public decimal workedHours
	{
		get
		{
			return workedHoursField;
		}
		set
		{
			workedHoursField = value;
		}
	}

	public decimal leaveHours
	{
		get
		{
			return leaveHoursField;
		}
		set
		{
			leaveHoursField = value;
		}
	}

	public string leaveReason
	{
		get
		{
			return leaveReasonField;
		}
		set
		{
			leaveReasonField = value;
		}
	}

	public string costCentre
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

	public string lastPunchOut
	{
		get
		{
			return lastPunchOutField;
		}
		set
		{
			lastPunchOutField = value;
		}
	}

	public string agreementName
	{
		get
		{
			return agreementNameField;
		}
		set
		{
			agreementNameField = value;
		}
	}

	public string lastModified
	{
		get
		{
			return lastModifiedField;
		}
		set
		{
			lastModifiedField = value;
		}
	}

	public string costCentreHomeUnit
	{
		get
		{
			return costCentreHomeUnitField;
		}
		set
		{
			costCentreHomeUnitField = value;
		}
	}
}
