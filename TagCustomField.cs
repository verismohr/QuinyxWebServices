using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class TagCustomField
{
	private string labelField;

	private string valueField;

	public string label
	{
		get
		{
			return labelField;
		}
		set
		{
			labelField = value;
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
