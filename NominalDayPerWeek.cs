using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class NominalDayPerWeek
{
	private DateTime fromDateField;

	private int nominalDaysPerWeekField;

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

	public int nominalDaysPerWeek
	{
		get
		{
			return nominalDaysPerWeekField;
		}
		set
		{
			nominalDaysPerWeekField = value;
		}
	}
}
