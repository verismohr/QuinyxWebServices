using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class PunchValidation
{
	private string badgeNumberField;

	private string cardNumberField;

	private DateTime? punchInField;

	private DateTime? punchOutField;

	private int punchIdField;

	private int shiftIdField;

	private string statusField;

	private string[] validationErrorsField;

	public string badgeNumber
	{
		get
		{
			return badgeNumberField;
		}
		set
		{
			badgeNumberField = value;
		}
	}

	public string cardNumber
	{
		get
		{
			return cardNumberField;
		}
		set
		{
			cardNumberField = value;
		}
	}

	[SoapElement(IsNullable = true)]
	public DateTime? punchIn
	{
		get
		{
			return punchInField;
		}
		set
		{
			punchInField = value;
		}
	}

	[SoapElement(IsNullable = true)]
	public DateTime? punchOut
	{
		get
		{
			return punchOutField;
		}
		set
		{
			punchOutField = value;
		}
	}

	public int punchId
	{
		get
		{
			return punchIdField;
		}
		set
		{
			punchIdField = value;
		}
	}

	public int shiftId
	{
		get
		{
			return shiftIdField;
		}
		set
		{
			shiftIdField = value;
		}
	}

	public string status
	{
		get
		{
			return statusField;
		}
		set
		{
			statusField = value;
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
