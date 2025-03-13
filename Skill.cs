using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class Skill
{
	private int skillIdField;

	private string skillDescriptionField;

	private DateTime tsField;

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

	public string skillDescription
	{
		get
		{
			return skillDescriptionField;
		}
		set
		{
			skillDescriptionField = value;
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
