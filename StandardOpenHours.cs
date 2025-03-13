using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class StandardOpenHours
{
	private int dayOfWeekField;

	private bool dayOfWeekFieldSpecified;

	private string timeStartField;

	private string timeEndField;

	private string dateStartField;

	public int dayOfWeek
	{
		get
		{
			return dayOfWeekField;
		}
		set
		{
			dayOfWeekField = value;
		}
	}

	[SoapIgnore]
	public bool dayOfWeekSpecified
	{
		get
		{
			return dayOfWeekFieldSpecified;
		}
		set
		{
			dayOfWeekFieldSpecified = value;
		}
	}

	public string timeStart
	{
		get
		{
			return timeStartField;
		}
		set
		{
			timeStartField = value;
		}
	}

	public string timeEnd
	{
		get
		{
			return timeEndField;
		}
		set
		{
			timeEndField = value;
		}
	}

	public string dateStart
	{
		get
		{
			return dateStartField;
		}
		set
		{
			dateStartField = value;
		}
	}
}
