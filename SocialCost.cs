using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class SocialCost
{
	private int typeField;

	private int fromAgeField;

	private int toAgeField;

	private int startOnField;

	private decimal costPercentField;

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

	public int fromAge
	{
		get
		{
			return fromAgeField;
		}
		set
		{
			fromAgeField = value;
		}
	}

	public int toAge
	{
		get
		{
			return toAgeField;
		}
		set
		{
			toAgeField = value;
		}
	}

	public int startOn
	{
		get
		{
			return startOnField;
		}
		set
		{
			startOnField = value;
		}
	}

	public decimal costPercent
	{
		get
		{
			return costPercentField;
		}
		set
		{
			costPercentField = value;
		}
	}
}
