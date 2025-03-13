using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class UpdateTimePunch
{
	private int idField;

	private int persIdField;

	private string badgeNoField;

	private string cardNoField;

	private string punchDateField;

	private string punchInField;

	private string punchOutField;

	private string commentField;

	private int costCentreCodeField;

	private int auth1Field;

	private int bossAuthField;

	private string mgrCommentField;

	private int shiftReferenceField;

	private int projectCodeField;

	private int salaryTypeField;

	private string salaryTypeExtCodeField;

	private string externalInfo1Field;

	private string externalInfo2Field;

	private string externalInfo3Field;

	private int payOverTimeField;

	private int decisionIdField;

	private string decisionNoField;

	private string customerNoField;

	private int teamIdField;

	private string teamExtCodeField;

	private int updateActionField;

	private bool applyRoundingField;

	private bool applyRoundingFieldSpecified;

	private int agreementIdField;

	private bool agreementIdFieldSpecified;

	private int payUTField;

	private bool payUTFieldSpecified;

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

	public int persId
	{
		get
		{
			return persIdField;
		}
		set
		{
			persIdField = value;
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

	public string cardNo
	{
		get
		{
			return cardNoField;
		}
		set
		{
			cardNoField = value;
		}
	}

	public string punchDate
	{
		get
		{
			return punchDateField;
		}
		set
		{
			punchDateField = value;
		}
	}

	public string punchIn
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

	public string punchOut
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

	public string comment
	{
		get
		{
			return commentField;
		}
		set
		{
			commentField = value;
		}
	}

	public int costCentreCode
	{
		get
		{
			return costCentreCodeField;
		}
		set
		{
			costCentreCodeField = value;
		}
	}

	public int auth1
	{
		get
		{
			return auth1Field;
		}
		set
		{
			auth1Field = value;
		}
	}

	public int bossAuth
	{
		get
		{
			return bossAuthField;
		}
		set
		{
			bossAuthField = value;
		}
	}

	public string mgrComment
	{
		get
		{
			return mgrCommentField;
		}
		set
		{
			mgrCommentField = value;
		}
	}

	public int shiftReference
	{
		get
		{
			return shiftReferenceField;
		}
		set
		{
			shiftReferenceField = value;
		}
	}

	public int projectCode
	{
		get
		{
			return projectCodeField;
		}
		set
		{
			projectCodeField = value;
		}
	}

	public int salaryType
	{
		get
		{
			return salaryTypeField;
		}
		set
		{
			salaryTypeField = value;
		}
	}

	public string salaryTypeExtCode
	{
		get
		{
			return salaryTypeExtCodeField;
		}
		set
		{
			salaryTypeExtCodeField = value;
		}
	}

	public string externalInfo1
	{
		get
		{
			return externalInfo1Field;
		}
		set
		{
			externalInfo1Field = value;
		}
	}

	public string externalInfo2
	{
		get
		{
			return externalInfo2Field;
		}
		set
		{
			externalInfo2Field = value;
		}
	}

	public string externalInfo3
	{
		get
		{
			return externalInfo3Field;
		}
		set
		{
			externalInfo3Field = value;
		}
	}

	public int payOverTime
	{
		get
		{
			return payOverTimeField;
		}
		set
		{
			payOverTimeField = value;
		}
	}

	public int decisionId
	{
		get
		{
			return decisionIdField;
		}
		set
		{
			decisionIdField = value;
		}
	}

	public string decisionNo
	{
		get
		{
			return decisionNoField;
		}
		set
		{
			decisionNoField = value;
		}
	}

	public string customerNo
	{
		get
		{
			return customerNoField;
		}
		set
		{
			customerNoField = value;
		}
	}

	public int teamId
	{
		get
		{
			return teamIdField;
		}
		set
		{
			teamIdField = value;
		}
	}

	public string teamExtCode
	{
		get
		{
			return teamExtCodeField;
		}
		set
		{
			teamExtCodeField = value;
		}
	}

	public int updateAction
	{
		get
		{
			return updateActionField;
		}
		set
		{
			updateActionField = value;
		}
	}

	public bool applyRounding
	{
		get
		{
			return applyRoundingField;
		}
		set
		{
			applyRoundingField = value;
		}
	}

	[SoapIgnore]
	public bool applyRoundingSpecified
	{
		get
		{
			return applyRoundingFieldSpecified;
		}
		set
		{
			applyRoundingFieldSpecified = value;
		}
	}

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

	public int payUT
	{
		get
		{
			return payUTField;
		}
		set
		{
			payUTField = value;
		}
	}

	[SoapIgnore]
	public bool payUTSpecified
	{
		get
		{
			return payUTFieldSpecified;
		}
		set
		{
			payUTFieldSpecified = value;
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
