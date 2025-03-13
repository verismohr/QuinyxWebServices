using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class Xtrawork
{
	private DateTime fromDateField;

	private string fromTimeField;

	private DateTime toDateField;

	private string toTimeField;

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

	public string fromTime
	{
		get
		{
			return fromTimeField;
		}
		set
		{
			fromTimeField = value;
		}
	}

	[SoapElement(DataType = "date")]
	public DateTime toDate
	{
		get
		{
			return toDateField;
		}
		set
		{
			toDateField = value;
		}
	}

	public string toTime
	{
		get
		{
			return toTimeField;
		}
		set
		{
			toTimeField = value;
		}
	}
}
