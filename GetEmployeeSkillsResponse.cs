using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class GetEmployeeSkillsResponse
{
	private string[] validationErrorsField;

	private employeeSkill[] employeesSkillsField;

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

	public employeeSkill[] employeesSkills
	{
		get
		{
			return employeesSkillsField;
		}
		set
		{
			employeesSkillsField = value;
		}
	}
}
