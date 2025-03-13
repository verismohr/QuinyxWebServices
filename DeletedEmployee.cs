using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class DeletedEmployee
{
	private int persIdField;

	private int unitIdField;

	private string badgeNoField;

	private DateTime deletedField;

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

	public int unitId
	{
		get
		{
			return unitIdField;
		}
		set
		{
			unitIdField = value;
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

	public DateTime deleted
	{
		get
		{
			return deletedField;
		}
		set
		{
			deletedField = value;
		}
	}
}
