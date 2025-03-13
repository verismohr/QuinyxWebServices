using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class Portrait
{
	private string portraitField;

	private DateTime tsField;

	public string portrait
	{
		get
		{
			return portraitField;
		}
		set
		{
			portraitField = value;
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
