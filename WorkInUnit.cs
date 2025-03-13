using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class WorkInUnit
{
	private int restIdField;

	private bool restIdFieldSpecified;

	private string extUnitIdField;

	private bool rollOutShiftEnabledField;

	private bool rollOutShiftEnabledFieldSpecified;

	public int restId
	{
		get
		{
			return restIdField;
		}
		set
		{
			restIdField = value;
		}
	}

	[SoapIgnore]
	public bool restIdSpecified
	{
		get
		{
			return restIdFieldSpecified;
		}
		set
		{
			restIdFieldSpecified = value;
		}
	}

	public string extUnitId
	{
		get
		{
			return extUnitIdField;
		}
		set
		{
			extUnitIdField = value;
		}
	}

	public bool rollOutShiftEnabled
	{
		get
		{
			return rollOutShiftEnabledField;
		}
		set
		{
			rollOutShiftEnabledField = value;
		}
	}

	[SoapIgnore]
	public bool rollOutShiftEnabledSpecified
	{
		get
		{
			return rollOutShiftEnabledFieldSpecified;
		}
		set
		{
			rollOutShiftEnabledFieldSpecified = value;
		}
	}
}
