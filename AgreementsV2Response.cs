using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class AgreementsV2Response
{
	private AgreementV2[] agreementsField;

	private string[] validationErrorsField;

	public AgreementV2[] agreements
	{
		get
		{
			return agreementsField;
		}
		set
		{
			agreementsField = value;
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
