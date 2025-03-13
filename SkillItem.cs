using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class SkillItem
{
	private int skillIdField;

	private bool skillIdFieldSpecified;

	private string extSkillIdField;

	private string skillDescriptionField;

	private string skillCategoryIdField;

	private DateTime tsField;

	private bool tsFieldSpecified;

	private string[] validationErrorsField;

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

	public string skillCategoryId
	{
		get
		{
			return skillCategoryIdField;
		}
		set
		{
			skillCategoryIdField = value;
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

	[SoapIgnore]
	public bool tsSpecified
	{
		get
		{
			return tsFieldSpecified;
		}
		set
		{
			tsFieldSpecified = value;
		}
	}

	public string[] validationErrors
	{
		get
		{
			return validationErrorsField;
		}
		set
		{
			validationErrorsField = value;
		}
	}
}
