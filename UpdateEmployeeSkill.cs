using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class UpdateEmployeeSkill
{
	private int persIdField;

	private string badgeNoField;

	private int addSkillsField;

	private bool addSkillsFieldSpecified;

	private JobSkill[] jobSkillsField;

	private string[] validationErrorsField;

	public int persId
	{
		get
		{
			return persIdField;
		}
		set
		{
			persIdField = value;
		}
	}

	public string badgeNo
	{
		get
		{
			return badgeNoField;
		}
		set
		{
			badgeNoField = value;
		}
	}

	public int addSkills
	{
		get
		{
			return addSkillsField;
		}
		set
		{
			addSkillsField = value;
		}
	}

	[SoapIgnore]
	public bool addSkillsSpecified
	{
		get
		{
			return addSkillsFieldSpecified;
		}
		set
		{
			addSkillsFieldSpecified = value;
		}
	}

	public JobSkill[] jobSkills
	{
		get
		{
			return jobSkillsField;
		}
		set
		{
			jobSkillsField = value;
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
