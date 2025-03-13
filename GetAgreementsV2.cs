using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class GetAgreementsV2
{
	private int agreementIdField;

	private bool agreementIdFieldSpecified;

	private string extAgreementIdField;

	private int sectionIdField;

	private bool sectionIdFieldSpecified;

	private int employeeIdField;

	private bool employeeIdFieldSpecified;

	private string badgeNoField;

	private string fromDateField;

	private string toDateField;

	private string modifiedAfterField;

	public int agreementId
	{
		get
		{
			return agreementIdField;
		}
		set
		{
			agreementIdField = value;
		}
	}

	[SoapIgnore]
	public bool agreementIdSpecified
	{
		get
		{
			return agreementIdFieldSpecified;
		}
		set
		{
			agreementIdFieldSpecified = value;
		}
	}

	public string extAgreementId
	{
		get
		{
			return extAgreementIdField;
		}
		set
		{
			extAgreementIdField = value;
		}
	}

	public int sectionId
	{
		get
		{
			return sectionIdField;
		}
		set
		{
			sectionIdField = value;
		}
	}

	[SoapIgnore]
	public bool sectionIdSpecified
	{
		get
		{
			return sectionIdFieldSpecified;
		}
		set
		{
			sectionIdFieldSpecified = value;
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

	[SoapIgnore]
	public bool employeeIdSpecified
	{
		get
		{
			return employeeIdFieldSpecified;
		}
		set
		{
			employeeIdFieldSpecified = value;
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

	public string fromDate
	{
		get
		{
			return fromDateField;
		}
		set
		{
			fromDateField = value;
		}
	}

	public string toDate
	{
		get
		{
			return toDateField;
		}
		set
		{
			toDateField = value;
		}
	}

	public string modifiedAfter
	{
		get
		{
			return modifiedAfterField;
		}
		set
		{
			modifiedAfterField = value;
		}
	}
}
