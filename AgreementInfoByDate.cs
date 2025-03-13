using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class AgreementInfoByDate
{
	private string badgeNoField;

	private int agreementIdField;

	private string extAgreementIdField;

	private int agreementUnitIdField;

	private string agreementUnitNameField;

	private int agreementTemplateIdField;

	private string agreementTemplateNameField;

	private decimal employmentRateField;

	private decimal additionByWorkedYearsField;

	private decimal additionByAgeField;

	private decimal additionByPersonalAdjustmentField;

	private decimal hourlySalaryField;

	private decimal monthlySalaryField;

	private bool monthlySalaryFieldSpecified;

	private decimal calculatedSalaryField;

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

	public int agreementId
	{
		get
		{
			return agreementIdField;
		}
		set
		{
			agreementIdField = value;
		}
	}

	public string extAgreementId
	{
		get
		{
			return extAgreementIdField;
		}
		set
		{
			extAgreementIdField = value;
		}
	}

	public int agreementUnitId
	{
		get
		{
			return agreementUnitIdField;
		}
		set
		{
			agreementUnitIdField = value;
		}
	}

	public string agreementUnitName
	{
		get
		{
			return agreementUnitNameField;
		}
		set
		{
			agreementUnitNameField = value;
		}
	}

	public int agreementTemplateId
	{
		get
		{
			return agreementTemplateIdField;
		}
		set
		{
			agreementTemplateIdField = value;
		}
	}

	public string agreementTemplateName
	{
		get
		{
			return agreementTemplateNameField;
		}
		set
		{
			agreementTemplateNameField = value;
		}
	}

	public decimal employmentRate
	{
		get
		{
			return employmentRateField;
		}
		set
		{
			employmentRateField = value;
		}
	}

	public decimal additionByWorkedYears
	{
		get
		{
			return additionByWorkedYearsField;
		}
		set
		{
			additionByWorkedYearsField = value;
		}
	}

	public decimal additionByAge
	{
		get
		{
			return additionByAgeField;
		}
		set
		{
			additionByAgeField = value;
		}
	}

	public decimal additionByPersonalAdjustment
	{
		get
		{
			return additionByPersonalAdjustmentField;
		}
		set
		{
			additionByPersonalAdjustmentField = value;
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

	public decimal calculatedSalary
	{
		get
		{
			return calculatedSalaryField;
		}
		set
		{
			calculatedSalaryField = value;
		}
	}
}
