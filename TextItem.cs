using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class TextItem
{
	private int idField;

	private bool idFieldSpecified;

	private string tagField;

	private string ttextField;

	private string extCodeField;

	private bool showInWebpunchField;

	private bool showInWebpunchFieldSpecified;

	private bool checkedField;

	private bool checkedFieldSpecified;

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

	public string tag
	{
		get
		{
			return tagField;
		}
		set
		{
			tagField = value;
		}
	}

	public string ttext
	{
		get
		{
			return ttextField;
		}
		set
		{
			ttextField = value;
		}
	}

	public string extCode
	{
		get
		{
			return extCodeField;
		}
		set
		{
			extCodeField = value;
		}
	}

	public bool showInWebpunch
	{
		get
		{
			return showInWebpunchField;
		}
		set
		{
			showInWebpunchField = value;
		}
	}

	[SoapIgnore]
	public bool showInWebpunchSpecified
	{
		get
		{
			return showInWebpunchFieldSpecified;
		}
		set
		{
			showInWebpunchFieldSpecified = value;
		}
	}

	public bool @checked
	{
		get
		{
			return checkedField;
		}
		set
		{
			checkedField = value;
		}
	}

	[SoapIgnore]
	public bool checkedSpecified
	{
		get
		{
			return checkedFieldSpecified;
		}
		set
		{
			checkedFieldSpecified = value;
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
