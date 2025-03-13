using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class getLeaveApplicationsV2Request
{
	private int employeeIdField;

	private bool employeeIdFieldSpecified;

	private string badgeNoField;

	private int sectionIdField;

	private bool sectionIdFieldSpecified;

	private DateTime fromDateField;

	private bool fromDateFieldSpecified;

	private DateTime toDateField;

	private bool toDateFieldSpecified;

	private string modifiedAfterField;

	private bool allUnitsField;

	private bool allUnitsFieldSpecified;

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

	[SoapIgnore]
	public bool sectionIdSpecified
	{
		get
		{
			return sectionIdFieldSpecified;
		}
		set
		{
			sectionIdFieldSpecified = value;
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

	public string modifiedAfter
	{
		get
		{
			return modifiedAfterField;
		}
		set
		{
			modifiedAfterField = value;
		}
	}

	public bool allUnits
	{
		get
		{
			return allUnitsField;
		}
		set
		{
			allUnitsField = value;
		}
	}

	[SoapIgnore]
	public bool allUnitsSpecified
	{
		get
		{
			return allUnitsFieldSpecified;
		}
		set
		{
			allUnitsFieldSpecified = value;
		}
	}
}
