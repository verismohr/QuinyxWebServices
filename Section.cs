using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class Section
{
	private int idField;

	private bool idFieldSpecified;

	private string extSectionIdField;

	private string extGroupIdField;

	private int restIdField;

	private bool restIdFieldSpecified;

	private string nameField;

	private int managerIdField;

	private bool managerIdFieldSpecified;

	private int managerGroupIdField;

	private bool managerGroupIdFieldSpecified;

	private int costCentreField;

	private bool costCentreFieldSpecified;

	private string costCentreExtCodeField;

	private DateTime tsField;

	private bool tsFieldSpecified;

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

	public string extSectionId
	{
		get
		{
			return extSectionIdField;
		}
		set
		{
			extSectionIdField = value;
		}
	}

	public string extGroupId
	{
		get
		{
			return extGroupIdField;
		}
		set
		{
			extGroupIdField = value;
		}
	}

	public int restId
	{
		get
		{
			return restIdField;
		}
		set
		{
			restIdField = value;
		}
	}

	[SoapIgnore]
	public bool restIdSpecified
	{
		get
		{
			return restIdFieldSpecified;
		}
		set
		{
			restIdFieldSpecified = value;
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

	public int managerId
	{
		get
		{
			return managerIdField;
		}
		set
		{
			managerIdField = value;
		}
	}

	[SoapIgnore]
	public bool managerIdSpecified
	{
		get
		{
			return managerIdFieldSpecified;
		}
		set
		{
			managerIdFieldSpecified = value;
		}
	}

	public int managerGroupId
	{
		get
		{
			return managerGroupIdField;
		}
		set
		{
			managerGroupIdField = value;
		}
	}

	[SoapIgnore]
	public bool managerGroupIdSpecified
	{
		get
		{
			return managerGroupIdFieldSpecified;
		}
		set
		{
			managerGroupIdFieldSpecified = value;
		}
	}

	public int costCentre
	{
		get
		{
			return costCentreField;
		}
		set
		{
			costCentreField = value;
		}
	}

	[SoapIgnore]
	public bool costCentreSpecified
	{
		get
		{
			return costCentreFieldSpecified;
		}
		set
		{
			costCentreFieldSpecified = value;
		}
	}

	public string costCentreExtCode
	{
		get
		{
			return costCentreExtCodeField;
		}
		set
		{
			costCentreExtCodeField = value;
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

	[SoapIgnore]
	public bool tsSpecified
	{
		get
		{
			return tsFieldSpecified;
		}
		set
		{
			tsFieldSpecified = value;
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
