using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class SalaryCostLimit
{
	private DateTime fromDateField;

	private decimal limitField;

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

	public decimal limit
	{
		get
		{
			return limitField;
		}
		set
		{
			limitField = value;
		}
	}
}
