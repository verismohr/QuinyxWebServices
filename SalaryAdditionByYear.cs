using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class SalaryAdditionByYear
{
	private decimal fromField;

	private decimal salaryAdditionField;

	public decimal from
	{
		get
		{
			return fromField;
		}
		set
		{
			fromField = value;
		}
	}

	public decimal salaryAddition
	{
		get
		{
			return salaryAdditionField;
		}
		set
		{
			salaryAdditionField = value;
		}
	}
}
