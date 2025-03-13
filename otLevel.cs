using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class otLevel
{
	private decimal hoursField;

	private bool hoursFieldSpecified;

	private int overtimeTypeField;

	private bool overtimeTypeFieldSpecified;

	public decimal hours
	{
		get
		{
			return hoursField;
		}
		set
		{
			hoursField = value;
		}
	}

	[SoapIgnore]
	public bool hoursSpecified
	{
		get
		{
			return hoursFieldSpecified;
		}
		set
		{
			hoursFieldSpecified = value;
		}
	}

	public int overtimeType
	{
		get
		{
			return overtimeTypeField;
		}
		set
		{
			overtimeTypeField = value;
		}
	}

	[SoapIgnore]
	public bool overtimeTypeSpecified
	{
		get
		{
			return overtimeTypeFieldSpecified;
		}
		set
		{
			overtimeTypeFieldSpecified = value;
		}
	}
}
