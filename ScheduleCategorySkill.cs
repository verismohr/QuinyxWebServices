using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class ScheduleCategorySkill
{
	private string scatNameField;

	private string skillDescriptionField;

	public string scatName
	{
		get
		{
			return scatNameField;
		}
		set
		{
			scatNameField = value;
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
}
