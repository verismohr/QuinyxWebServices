using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class punchRounding
{
	private int typeField;

	private int punchPartField;

	private int insideShiftField;

	private bool insideShiftFieldSpecified;

	private int roundingRuleField;

	private bool roundingRuleFieldSpecified;

	private decimal minutesField;

	public int type
	{
		get
		{
			return typeField;
		}
		set
		{
			typeField = value;
		}
	}

	public int punchPart
	{
		get
		{
			return punchPartField;
		}
		set
		{
			punchPartField = value;
		}
	}

	public int insideShift
	{
		get
		{
			return insideShiftField;
		}
		set
		{
			insideShiftField = value;
		}
	}

	[SoapIgnore]
	public bool insideShiftSpecified
	{
		get
		{
			return insideShiftFieldSpecified;
		}
		set
		{
			insideShiftFieldSpecified = value;
		}
	}

	public int roundingRule
	{
		get
		{
			return roundingRuleField;
		}
		set
		{
			roundingRuleField = value;
		}
	}

	[SoapIgnore]
	public bool roundingRuleSpecified
	{
		get
		{
			return roundingRuleFieldSpecified;
		}
		set
		{
			roundingRuleFieldSpecified = value;
		}
	}

	public decimal minutes
	{
		get
		{
			return minutesField;
		}
		set
		{
			minutesField = value;
		}
	}
}
