using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class AgreementTemplatesV2Response
{
	private AgreementTemplateV2[] agreementTemplatesField;

	private string[] validationErrorsField;

	public AgreementTemplateV2[] agreementTemplates
	{
		get
		{
			return agreementTemplatesField;
		}
		set
		{
			agreementTemplatesField = value;
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
