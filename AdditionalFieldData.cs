using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class AdditionalFieldData
{
	private string keyField;

	private string valueField;

	public string key
	{
		get
		{
			return keyField;
		}
		set
		{
			keyField = value;
		}
	}

	public string value
	{
		get
		{
			return valueField;
		}
		set
		{
			valueField = value;
		}
	}
}
