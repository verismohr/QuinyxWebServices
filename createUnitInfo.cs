using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class createUnitInfo
{
	private int idField;

	private bool idFieldSpecified;

	private string extApplicationIdField;

	private string nameField;

	private string aPI_keyField;

	private string[] validationErrorsField;

	public int id
	{
		get
		{
			return idField;
		}
		set
		{
			idField = value;
		}
	}

	[SoapIgnore]
	public bool idSpecified
	{
		get
		{
			return idFieldSpecified;
		}
		set
		{
			idFieldSpecified = value;
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

	public string API_key
	{
		get
		{
			return aPI_keyField;
		}
		set
		{
			aPI_keyField = value;
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
