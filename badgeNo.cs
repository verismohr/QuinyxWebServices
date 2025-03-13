using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class badgeNo
{
	private string badgeNo1Field;

	[SoapElement("badgeNo")]
	public string badgeNo1
	{
		get
		{
			return badgeNo1Field;
		}
		set
		{
			badgeNo1Field = value;
		}
	}
}
