using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class standardOvertime
{
	private string overtimeFromField;

	private string overtimeToField;

	private int oTypeField;

	private decimal firstHoursField;

	private int firstTypeField;

	private string firstBegField;

	private string firstEndField;

	private int isAdditionalSalaryTypeField;

	private int replaceBaseSalariesField;

	private string[] validationErrorsField;

	public string overtimeFrom
	{
		get
		{
			return overtimeFromField;
		}
		set
		{
			overtimeFromField = value;
		}
	}

	public string overtimeTo
	{
		get
		{
			return overtimeToField;
		}
		set
		{
			overtimeToField = value;
		}
	}

	public int oType
	{
		get
		{
			return oTypeField;
		}
		set
		{
			oTypeField = value;
		}
	}

	public decimal firstHours
	{
		get
		{
			return firstHoursField;
		}
		set
		{
			firstHoursField = value;
		}
	}

	public int firstType
	{
		get
		{
			return firstTypeField;
		}
		set
		{
			firstTypeField = value;
		}
	}

	public string firstBeg
	{
		get
		{
			return firstBegField;
		}
		set
		{
			firstBegField = value;
		}
	}

	public string firstEnd
	{
		get
		{
			return firstEndField;
		}
		set
		{
			firstEndField = value;
		}
	}

	public int isAdditionalSalaryType
	{
		get
		{
			return isAdditionalSalaryTypeField;
		}
		set
		{
			isAdditionalSalaryTypeField = value;
		}
	}

	public int replaceBaseSalaries
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
