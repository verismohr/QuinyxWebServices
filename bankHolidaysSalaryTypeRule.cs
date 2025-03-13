using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class bankHolidaysSalaryTypeRule
{
	private string stCodeField;

	private string fromTimeField;

	private int fromTypeField;

	private string toTimeField;

	private int toTypeField;

	private decimal amountField;

	private int amountTypeField;

	private bool hasWorkRequirementField;

	private int workRequirementField;

	private bool hasShiftRequirementField;

	private int shiftRequirementField;

	private int leaveTypeIdField;

	private bool hasAlternateSalaryField;

	private decimal alternateAmountField;

	private int alternateStCodeField;

	private string alternateFromTimeField;

	private int alternateFromTypeField;

	private string alternateToTimeField;

	private int alternateToTypeField;

	private bool replaceBaseSalariesField;

	private bool replaceUTSalariesField;

	private bool replaceATSalariesField;

	private bool replaceOTSalariesField;

	private string leaveReasonsField;

	private bool replaceSickLeaveSalariesField;

	private string eligibilityRuleIdsField;

	private string[] validationErrorsField;

	public string stCode
	{
		get
		{
			return stCodeField;
		}
		set
		{
			stCodeField = value;
		}
	}

	public string fromTime
	{
		get
		{
			return fromTimeField;
		}
		set
		{
			fromTimeField = value;
		}
	}

	public int fromType
	{
		get
		{
			return fromTypeField;
		}
		set
		{
			fromTypeField = value;
		}
	}

	public string toTime
	{
		get
		{
			return toTimeField;
		}
		set
		{
			toTimeField = value;
		}
	}

	public int toType
	{
		get
		{
			return toTypeField;
		}
		set
		{
			toTypeField = value;
		}
	}

	public decimal amount
	{
		get
		{
			return amountField;
		}
		set
		{
			amountField = value;
		}
	}

	public int amountType
	{
		get
		{
			return amountTypeField;
		}
		set
		{
			amountTypeField = value;
		}
	}

	public bool hasWorkRequirement
	{
		get
		{
			return hasWorkRequirementField;
		}
		set
		{
			hasWorkRequirementField = value;
		}
	}

	public int workRequirement
	{
		get
		{
			return workRequirementField;
		}
		set
		{
			workRequirementField = value;
		}
	}

	public bool hasShiftRequirement
	{
		get
		{
			return hasShiftRequirementField;
		}
		set
		{
			hasShiftRequirementField = value;
		}
	}

	public int shiftRequirement
	{
		get
		{
			return shiftRequirementField;
		}
		set
		{
			shiftRequirementField = value;
		}
	}

	public int leaveTypeId
	{
		get
		{
			return leaveTypeIdField;
		}
		set
		{
			leaveTypeIdField = value;
		}
	}

	public bool hasAlternateSalary
	{
		get
		{
			return hasAlternateSalaryField;
		}
		set
		{
			hasAlternateSalaryField = value;
		}
	}

	public decimal alternateAmount
	{
		get
		{
			return alternateAmountField;
		}
		set
		{
			alternateAmountField = value;
		}
	}

	public int alternateStCode
	{
		get
		{
			return alternateStCodeField;
		}
		set
		{
			alternateStCodeField = value;
		}
	}

	public string alternateFromTime
	{
		get
		{
			return alternateFromTimeField;
		}
		set
		{
			alternateFromTimeField = value;
		}
	}

	public int alternateFromType
	{
		get
		{
			return alternateFromTypeField;
		}
		set
		{
			alternateFromTypeField = value;
		}
	}

	public string alternateToTime
	{
		get
		{
			return alternateToTimeField;
		}
		set
		{
			alternateToTimeField = value;
		}
	}

	public int alternateToType
	{
		get
		{
			return alternateToTypeField;
		}
		set
		{
			alternateToTypeField = value;
		}
	}

	public bool replaceBaseSalaries
	{
		get
		{
			return replaceBaseSalariesField;
		}
		set
		{
			replaceBaseSalariesField = value;
		}
	}

	public bool replaceUTSalaries
	{
		get
		{
			return replaceUTSalariesField;
		}
		set
		{
			replaceUTSalariesField = value;
		}
	}

	public bool replaceATSalaries
	{
		get
		{
			return replaceATSalariesField;
		}
		set
		{
			replaceATSalariesField = value;
		}
	}

	public bool replaceOTSalaries
	{
		get
		{
			return replaceOTSalariesField;
		}
		set
		{
			replaceOTSalariesField = value;
		}
	}

	public string leaveReasons
	{
		get
		{
			return leaveReasonsField;
		}
		set
		{
			leaveReasonsField = value;
		}
	}

	public bool replaceSickLeaveSalaries
	{
		get
		{
			return replaceSickLeaveSalariesField;
		}
		set
		{
			replaceSickLeaveSalariesField = value;
		}
	}

	public string eligibilityRuleIds
	{
		get
		{
			return eligibilityRuleIdsField;
		}
		set
		{
			eligibilityRuleIdsField = value;
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
