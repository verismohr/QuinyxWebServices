using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class SalaryAdditionByDate
{
	private DateTime fromDateField;

	private decimal salaryAdditionField;

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
