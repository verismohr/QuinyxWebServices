using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class FileAttachment
{
	private string fileNameField;

	private string fileContentField;

	private int fileIdField;

	private bool fileIdFieldSpecified;

	private string[] validationErrorsField;

	public string fileName
	{
		get
		{
			return fileNameField;
		}
		set
		{
			fileNameField = value;
		}
	}

	public string fileContent
	{
		get
		{
			return fileContentField;
		}
		set
		{
			fileContentField = value;
		}
	}

	public int fileId
	{
		get
		{
			return fileIdField;
		}
		set
		{
			fileIdField = value;
		}
	}

	[SoapIgnore]
	public bool fileIdSpecified
	{
		get
		{
			return fileIdFieldSpecified;
		}
		set
		{
			fileIdFieldSpecified = value;
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
