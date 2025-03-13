using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class getTimePunchesRequest
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

	private bool transferredToPayrollField;

	private bool transferredToPayrollFieldSpecified;

	private bool notTransferredToPayrollField;

	private bool notTransferredToPayrollFieldSpecified;

	private bool approvedField;

	private bool approvedFieldSpecified;

	private bool unapprovedField;

	private bool unapprovedFieldSpecified;

	private bool deletedField;

	private bool deletedFieldSpecified;

	private bool activeField;

	private bool activeFieldSpecified;

	private bool allUnitsField;

	private bool allUnitsFieldSpecified;

	private string modifiedAfterField;

	private int employeeUnitModeField;

	private bool employeeUnitModeFieldSpecified;

	private bool shiftTaskInfoField;

	private bool shiftTaskInfoFieldSpecified;

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

	public bool transferredToPayroll
	{
		get
		{
			return transferredToPayrollField;
		}
		set
		{
			transferredToPayrollField = value;
		}
	}

	[SoapIgnore]
	public bool transferredToPayrollSpecified
	{
		get
		{
			return transferredToPayrollFieldSpecified;
		}
		set
		{
			transferredToPayrollFieldSpecified = value;
		}
	}

	public bool notTransferredToPayroll
	{
		get
		{
			return notTransferredToPayrollField;
		}
		set
		{
			notTransferredToPayrollField = value;
		}
	}

	[SoapIgnore]
	public bool notTransferredToPayrollSpecified
	{
		get
		{
			return notTransferredToPayrollFieldSpecified;
		}
		set
		{
			notTransferredToPayrollFieldSpecified = value;
		}
	}

	public bool approved
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

	[SoapIgnore]
	public bool approvedSpecified
	{
		get
		{
			return approvedFieldSpecified;
		}
		set
		{
			approvedFieldSpecified = value;
		}
	}

	public bool unapproved
	{
		get
		{
			return unapprovedField;
		}
		set
		{
			unapprovedField = value;
		}
	}

	[SoapIgnore]
	public bool unapprovedSpecified
	{
		get
		{
			return unapprovedFieldSpecified;
		}
		set
		{
			unapprovedFieldSpecified = value;
		}
	}

	public bool deleted
	{
		get
		{
			return deletedField;
		}
		set
		{
			deletedField = value;
		}
	}

	[SoapIgnore]
	public bool deletedSpecified
	{
		get
		{
			return deletedFieldSpecified;
		}
		set
		{
			deletedFieldSpecified = value;
		}
	}

	public bool active
	{
		get
		{
			return activeField;
		}
		set
		{
			activeField = value;
		}
	}

	[SoapIgnore]
	public bool activeSpecified
	{
		get
		{
			return activeFieldSpecified;
		}
		set
		{
			activeFieldSpecified = value;
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

	public int employeeUnitMode
	{
		get
		{
			return employeeUnitModeField;
		}
		set
		{
			employeeUnitModeField = value;
		}
	}

	[SoapIgnore]
	public bool employeeUnitModeSpecified
	{
		get
		{
			return employeeUnitModeFieldSpecified;
		}
		set
		{
			employeeUnitModeFieldSpecified = value;
		}
	}

	public bool shiftTaskInfo
	{
		get
		{
			return shiftTaskInfoField;
		}
		set
		{
			shiftTaskInfoField = value;
		}
	}

	[SoapIgnore]
	public bool shiftTaskInfoSpecified
	{
		get
		{
			return shiftTaskInfoFieldSpecified;
		}
		set
		{
			shiftTaskInfoFieldSpecified = value;
		}
	}
}
