using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class TemplateShift
{
	private int idField;

	private int templateIdField;

	private int weekDayField;

	private DateTime availfromField;

	private DateTime availtoField;

	private int altWeekDayField;

	private DateTime tsField;

	public int id
	{
		get
		{
			return idField;
		}
		set
		{
			idField = value;
		}
	}

	public int templateId
	{
		get
		{
			return templateIdField;
		}
		set
		{
			templateIdField = value;
		}
	}

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

	[SoapElement(DataType = "time")]
	public DateTime availfrom
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

	[SoapElement(DataType = "time")]
	public DateTime availto
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

	public int altWeekDay
	{
		get
		{
			return altWeekDayField;
		}
		set
		{
			altWeekDayField = value;
		}
	}

	public DateTime ts
	{
		get
		{
			return tsField;
		}
		set
		{
			tsField = value;
		}
	}
}
