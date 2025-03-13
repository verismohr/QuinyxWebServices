using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class AgreementSalary
{
	private DateTime fromDateField;

	private bool fromDateFieldSpecified;

	private decimal hourlySalaryField;

	private bool hourlySalaryFieldSpecified;

	private decimal monthlySalaryField;

	private bool monthlySalaryFieldSpecified;

	private decimal monthlyHoursDivisorField;

	private bool monthlyHoursDivisorFieldSpecified;

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

	public decimal hourlySalary
	{
		get
		{
			return hourlySalaryField;
		}
		set
		{
			hourlySalaryField = value;
		}
	}

	[SoapIgnore]
	public bool hourlySalarySpecified
	{
		get
		{
			return hourlySalaryFieldSpecified;
		}
		set
		{
			hourlySalaryFieldSpecified = value;
		}
	}

	public decimal monthlySalary
	{
		get
		{
			return monthlySalaryField;
		}
		set
		{
			monthlySalaryField = value;
		}
	}

	[SoapIgnore]
	public bool monthlySalarySpecified
	{
		get
		{
			return monthlySalaryFieldSpecified;
		}
		set
		{
			monthlySalaryFieldSpecified = value;
		}
	}

	public decimal monthlyHoursDivisor
	{
		get
		{
			return monthlyHoursDivisorField;
		}
		set
		{
			monthlyHoursDivisorField = value;
		}
	}

	[SoapIgnore]
	public bool monthlyHoursDivisorSpecified
	{
		get
		{
			return monthlyHoursDivisorFieldSpecified;
		}
		set
		{
			monthlyHoursDivisorFieldSpecified = value;
		}
	}
}
