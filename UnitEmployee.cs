using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class UnitEmployee
{
	private string api_keyField;

	private string unitNameField;

	private string extApplicationIdField;

	private string badgeNoField;

	private int employeeIdField;

	private string emailField;

	public string api_key
	{
		get
		{
			return api_keyField;
		}
		set
		{
			api_keyField = value;
		}
	}

	public string unitName
	{
		get
		{
			return unitNameField;
		}
		set
		{
			unitNameField = value;
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

	public int employeeId
	{
		get
		{
			return employeeIdField;
		}
		set
		{
			employeeIdField = value;
		}
	}

	public string email
	{
		get
		{
			return emailField;
		}
		set
		{
			emailField = value;
		}
	}
}
