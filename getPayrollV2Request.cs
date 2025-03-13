using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class getPayrollV2Request
{
	private DateTime fromDateField;

	private DateTime toDateField;

	private bool attestField;

	private string pSalTypeField;

	private bool empInUnitOnlyField;

	private int employeeIdField;

	private string badgeNoField;

	private bool isTransferingToPayrollField;

	private bool isTransferingToPayrollFieldSpecified;

	private int approvedSalaryStatusField;

	private bool approvedSalaryStatusFieldSpecified;

	private bool includeCostsField;

	private bool includeCostsFieldSpecified;

	private int costCalculationTypeField;

	private bool costCalculationTypeFieldSpecified;

	private bool includeTagsField;

	private bool includeTagsFieldSpecified;

	private bool includeStCodeField;

	private bool includeStCodeFieldSpecified;

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

	public bool attest
	{
		get
		{
			return attestField;
		}
		set
		{
			attestField = value;
		}
	}

	public string pSalType
	{
		get
		{
			return pSalTypeField;
		}
		set
		{
			pSalTypeField = value;
		}
	}

	public bool empInUnitOnly
	{
		get
		{
			return empInUnitOnlyField;
		}
		set
		{
			empInUnitOnlyField = value;
		}
	}

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

	public bool isTransferingToPayroll
	{
		get
		{
			return isTransferingToPayrollField;
		}
		set
		{
			isTransferingToPayrollField = value;
		}
	}

	[SoapIgnore]
	public bool isTransferingToPayrollSpecified
	{
		get
		{
			return isTransferingToPayrollFieldSpecified;
		}
		set
		{
			isTransferingToPayrollFieldSpecified = value;
		}
	}

	public int approvedSalaryStatus
	{
		get
		{
			return approvedSalaryStatusField;
		}
		set
		{
			approvedSalaryStatusField = value;
		}
	}

	[SoapIgnore]
	public bool approvedSalaryStatusSpecified
	{
		get
		{
			return approvedSalaryStatusFieldSpecified;
		}
		set
		{
			approvedSalaryStatusFieldSpecified = value;
		}
	}

	public bool includeCosts
	{
		get
		{
			return includeCostsField;
		}
		set
		{
			includeCostsField = value;
		}
	}

	[SoapIgnore]
	public bool includeCostsSpecified
	{
		get
		{
			return includeCostsFieldSpecified;
		}
		set
		{
			includeCostsFieldSpecified = value;
		}
	}

	public int costCalculationType
	{
		get
		{
			return costCalculationTypeField;
		}
		set
		{
			costCalculationTypeField = value;
		}
	}

	[SoapIgnore]
	public bool costCalculationTypeSpecified
	{
		get
		{
			return costCalculationTypeFieldSpecified;
		}
		set
		{
			costCalculationTypeFieldSpecified = value;
		}
	}

	public bool includeTags
	{
		get
		{
			return includeTagsField;
		}
		set
		{
			includeTagsField = value;
		}
	}

	[SoapIgnore]
	public bool includeTagsSpecified
	{
		get
		{
			return includeTagsFieldSpecified;
		}
		set
		{
			includeTagsFieldSpecified = value;
		}
	}

	public bool includeStCode
	{
		get
		{
			return includeStCodeField;
		}
		set
		{
			includeStCodeField = value;
		}
	}

	[SoapIgnore]
	public bool includeStCodeSpecified
	{
		get
		{
			return includeStCodeFieldSpecified;
		}
		set
		{
			includeStCodeFieldSpecified = value;
		}
	}
}
