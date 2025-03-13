using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class EmploymentRate
{
	private DateTime fromDateField;

	private decimal rateField;

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

	public decimal rate
	{
		get
		{
			return rateField;
		}
		set
		{
			rateField = value;
		}
	}
}
