using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class TemplateOverTime
{
	private int idField;

	private int templateIdField;

	private int weekDayField;

	private DateTime overtimeFromField;

	private DateTime overtimeToField;

	private int oTypeField;

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
	public DateTime overtimeFrom
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

	[SoapElement(DataType = "time")]
	public DateTime overtimeTo
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
