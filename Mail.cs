using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class Mail
{
	private int toPersIdField;

	private int sendToManagerTypeField;

	private string subjectField;

	private string msgField;

	private int fromPersIdField;

	private MailAttachment[] attachmentsField;

	private bool attachmentsArePayslipsField;

	private bool attachmentsArePayslipsFieldSpecified;

	private int allowfromPersIdOutsideOfUnitField;

	private bool allowfromPersIdOutsideOfUnitFieldSpecified;

	private int isMarkedAsImportantField;

	private bool isMarkedAsImportantFieldSpecified;

	private string[] validationErrorsField;

	public int toPersId
	{
		get
		{
			return toPersIdField;
		}
		set
		{
			toPersIdField = value;
		}
	}

	public int sendToManagerType
	{
		get
		{
			return sendToManagerTypeField;
		}
		set
		{
			sendToManagerTypeField = value;
		}
	}

	public string subject
	{
		get
		{
			return subjectField;
		}
		set
		{
			subjectField = value;
		}
	}

	public string msg
	{
		get
		{
			return msgField;
		}
		set
		{
			msgField = value;
		}
	}

	public int fromPersId
	{
		get
		{
			return fromPersIdField;
		}
		set
		{
			fromPersIdField = value;
		}
	}

	public MailAttachment[] attachments
	{
		get
		{
			return attachmentsField;
		}
		set
		{
			attachmentsField = value;
		}
	}

	public bool attachmentsArePayslips
	{
		get
		{
			return attachmentsArePayslipsField;
		}
		set
		{
			attachmentsArePayslipsField = value;
		}
	}

	[SoapIgnore]
	public bool attachmentsArePayslipsSpecified
	{
		get
		{
			return attachmentsArePayslipsFieldSpecified;
		}
		set
		{
			attachmentsArePayslipsFieldSpecified = value;
		}
	}

	public int allowfromPersIdOutsideOfUnit
	{
		get
		{
			return allowfromPersIdOutsideOfUnitField;
		}
		set
		{
			allowfromPersIdOutsideOfUnitField = value;
		}
	}

	[SoapIgnore]
	public bool allowfromPersIdOutsideOfUnitSpecified
	{
		get
		{
			return allowfromPersIdOutsideOfUnitFieldSpecified;
		}
		set
		{
			allowfromPersIdOutsideOfUnitFieldSpecified = value;
		}
	}

	public int isMarkedAsImportant
	{
		get
		{
			return isMarkedAsImportantField;
		}
		set
		{
			isMarkedAsImportantField = value;
		}
	}

	[SoapIgnore]
	public bool isMarkedAsImportantSpecified
	{
		get
		{
			return isMarkedAsImportantFieldSpecified;
		}
		set
		{
			isMarkedAsImportantFieldSpecified = value;
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
