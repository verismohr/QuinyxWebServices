using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class ShiftCategoriesTag
{
	private string tagCategoryNameField;

	private string tagCategoryExternalIdField;

	private string tagNameField;

	private string tagCodeField;

	private string tagExternalIdField;

	private TagCustomField[] customFieldsField;

	public string tagCategoryName
	{
		get
		{
			return tagCategoryNameField;
		}
		set
		{
			tagCategoryNameField = value;
		}
	}

	public string tagCategoryExternalId
	{
		get
		{
			return tagCategoryExternalIdField;
		}
		set
		{
			tagCategoryExternalIdField = value;
		}
	}

	public string tagName
	{
		get
		{
			return tagNameField;
		}
		set
		{
			tagNameField = value;
		}
	}

	public string tagCode
	{
		get
		{
			return tagCodeField;
		}
		set
		{
			tagCodeField = value;
		}
	}

	public string tagExternalId
	{
		get
		{
			return tagExternalIdField;
		}
		set
		{
			tagExternalIdField = value;
		}
	}

	public TagCustomField[] customFields
	{
		get
		{
			return customFieldsField;
		}
		set
		{
			customFieldsField = value;
		}
	}
}
