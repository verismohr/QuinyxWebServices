using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class UnitKeyV2
{
	private int idField;

	private int groupIdField;

	private bool groupIdFieldSpecified;

	private string extGroupIdField;

	private string nameField;

	private string extUnitIdField;

	private string aPI_keyField;

	private string extApplicationIdField;

	private int districtIdField;

	private bool districtIdFieldSpecified;

	private int costCentreField;

	private bool costCentreFieldSpecified;

	private string costCentreExtCodeField;

	private string[] validationErrorsField;

	private string companyNoField;

	private int districtGroupIdField;

	private bool districtGroupIdFieldSpecified;

	private string districtExtGroupIdField;

	private DateTime publishedToField;

	private bool publishedToFieldSpecified;

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

	public int groupId
	{
		get
		{
			return groupIdField;
		}
		set
		{
			groupIdField = value;
		}
	}

	[SoapIgnore]
	public bool groupIdSpecified
	{
		get
		{
			return groupIdFieldSpecified;
		}
		set
		{
			groupIdFieldSpecified = value;
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

	public string extUnitId
	{
		get
		{
			return extUnitIdField;
		}
		set
		{
			extUnitIdField = value;
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

	public string companyNo
	{
		get
		{
			return companyNoField;
		}
		set
		{
			companyNoField = value;
		}
	}

	public int districtGroupId
	{
		get
		{
			return districtGroupIdField;
		}
		set
		{
			districtGroupIdField = value;
		}
	}

	[SoapIgnore]
	public bool districtGroupIdSpecified
	{
		get
		{
			return districtGroupIdFieldSpecified;
		}
		set
		{
			districtGroupIdFieldSpecified = value;
		}
	}

	public string districtExtGroupId
	{
		get
		{
			return districtExtGroupIdField;
		}
		set
		{
			districtExtGroupIdField = value;
		}
	}

	[SoapElement(DataType = "date")]
	public DateTime publishedTo
	{
		get
		{
			return publishedToField;
		}
		set
		{
			publishedToField = value;
		}
	}

	[SoapIgnore]
	public bool publishedToSpecified
	{
		get
		{
			return publishedToFieldSpecified;
		}
		set
		{
			publishedToFieldSpecified = value;
		}
	}
}
