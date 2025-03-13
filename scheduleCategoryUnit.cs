using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class scheduleCategoryUnit
{
	private string externalUnitIdField;

	private int unitIdField;

	private bool unitIdFieldSpecified;

	private bool visibleInWebpunchField;

	public string externalUnitId
	{
		get
		{
			return externalUnitIdField;
		}
		set
		{
			externalUnitIdField = value;
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

	[SoapIgnore]
	public bool unitIdSpecified
	{
		get
		{
			return unitIdFieldSpecified;
		}
		set
		{
			unitIdFieldSpecified = value;
		}
	}

	public bool visibleInWebpunch
	{
		get
		{
			return visibleInWebpunchField;
		}
		set
		{
			visibleInWebpunchField = value;
		}
	}
}
