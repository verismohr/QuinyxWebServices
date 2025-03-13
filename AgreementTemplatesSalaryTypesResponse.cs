using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class AgreementTemplatesSalaryTypesResponse
{
	private AgreementTemplatesSalaryType[] agreementTemplatesSalaryTypesField;

	private string[] validationErrorsField;

	public AgreementTemplatesSalaryType[] agreementTemplatesSalaryTypes
	{
		get
		{
			return agreementTemplatesSalaryTypesField;
		}
		set
		{
			agreementTemplatesSalaryTypesField = value;
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
