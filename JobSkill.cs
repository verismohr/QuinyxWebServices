using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class JobSkill
{
	private int skillIdField;

	private bool skillIdFieldSpecified;

	private string extSkillIdField;

	private int skillExpiresField;

	private DateTime skillExpiringDateField;

	public int skillId
	{
		get
		{
			return skillIdField;
		}
		set
		{
			skillIdField = value;
		}
	}

	[SoapIgnore]
	public bool skillIdSpecified
	{
		get
		{
			return skillIdFieldSpecified;
		}
		set
		{
			skillIdFieldSpecified = value;
		}
	}

	public string extSkillId
	{
		get
		{
			return extSkillIdField;
		}
		set
		{
			extSkillIdField = value;
		}
	}

	public int skillExpires
	{
		get
		{
			return skillExpiresField;
		}
		set
		{
			skillExpiresField = value;
		}
	}

	public DateTime skillExpiringDate
	{
		get
		{
			return skillExpiringDateField;
		}
		set
		{
			skillExpiringDateField = value;
		}
	}
}
