using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class AvailabilityTimePeriod
{
	private int weekDayField;

	private string availfromField;

	private string availtoField;

	private int weekNoField;

	public int weekDay
	{
		get
		{
			return weekDayField;
		}
		set
		{
			weekDayField = value;
		}
	}

	public string availfrom
	{
		get
		{
			return availfromField;
		}
		set
		{
			availfromField = value;
		}
	}

	public string availto
	{
		get
		{
			return availtoField;
		}
		set
		{
			availtoField = value;
		}
	}

	public int weekNo
	{
		get
		{
			return weekNoField;
		}
		set
		{
			weekNoField = value;
		}
	}
}
