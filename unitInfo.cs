using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class unitInfo
{
	private string nameField;

	private string extApplicationIdField;

	private int districtIdField;

	private bool districtIdFieldSpecified;

	public string name
	{
		get
		{
			return nameField;
		}
		set
		{
			nameField = value;
		}
	}

	public string extApplicationId
	{
		get
		{
			return extApplicationIdField;
		}
		set
		{
			extApplicationIdField = value;
		}
	}

	public int districtId
	{
		get
		{
			return districtIdField;
		}
		set
		{
			districtIdField = value;
		}
	}

	[SoapIgnore]
	public bool districtIdSpecified
	{
		get
		{
			return districtIdFieldSpecified;
		}
		set
		{
			districtIdFieldSpecified = value;
		}
	}
}
