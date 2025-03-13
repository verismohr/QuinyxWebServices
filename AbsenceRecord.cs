using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class AbsenceRecord
{
	private int idField;

	private int persIdField;

	private string badgeNoField;

	private int leaveIdField;

	private string leaveExtCodeField;

	private string fromDateField;

	private string fromTimeField;

	private string toDateField;

	private string toTimeField;

	private int isPreliminaryField;

	private bool isPreliminaryFieldSpecified;

	private int approvedPaymentField;

	private bool approvedPaymentFieldSpecified;

	private string sickLevelField;

	private int shiftActionField;

	private bool shiftActionFieldSpecified;

	private int overlapActionField;

	private bool overlapActionFieldSpecified;

	private string managerCommentsField;

	private string leaveReasonField;

	private int decisionIdField;

	private bool decisionIdFieldSpecified;

	private string decisionNoField;

	private string customerNoField;

	private int teamIdField;

	private bool teamIdFieldSpecified;

	private string teamExtCodeField;

	private string externalInfo1Field;

	private string externalInfo2Field;

	private string externalInfo3Field;

	private bool useDefaultAbsenceScheduleField;

	private bool useDefaultAbsenceScheduleFieldSpecified;

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

	public int leaveId
	{
		get
		{
			return leaveIdField;
		}
		set
		{
			leaveIdField = value;
		}
	}

	public string leaveExtCode
	{
		get
		{
			return leaveExtCodeField;
		}
		set
		{
			leaveExtCodeField = value;
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

	public string fromTime
	{
		get
		{
			return fromTimeField;
		}
		set
		{
			fromTimeField = value;
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

	public string toTime
	{
		get
		{
			return toTimeField;
		}
		set
		{
			toTimeField = value;
		}
	}

	public int isPreliminary
	{
		get
		{
			return isPreliminaryField;
		}
		set
		{
			isPreliminaryField = value;
		}
	}

	[SoapIgnore]
	public bool isPreliminarySpecified
	{
		get
		{
			return isPreliminaryFieldSpecified;
		}
		set
		{
			isPreliminaryFieldSpecified = value;
		}
	}

	public int approvedPayment
	{
		get
		{
			return approvedPaymentField;
		}
		set
		{
			approvedPaymentField = value;
		}
	}

	[SoapIgnore]
	public bool approvedPaymentSpecified
	{
		get
		{
			return approvedPaymentFieldSpecified;
		}
		set
		{
			approvedPaymentFieldSpecified = value;
		}
	}

	public string sickLevel
	{
		get
		{
			return sickLevelField;
		}
		set
		{
			sickLevelField = value;
		}
	}

	public int shiftAction
	{
		get
		{
			return shiftActionField;
		}
		set
		{
			shiftActionField = value;
		}
	}

	[SoapIgnore]
	public bool shiftActionSpecified
	{
		get
		{
			return shiftActionFieldSpecified;
		}
		set
		{
			shiftActionFieldSpecified = value;
		}
	}

	public int overlapAction
	{
		get
		{
			return overlapActionField;
		}
		set
		{
			overlapActionField = value;
		}
	}

	[SoapIgnore]
	public bool overlapActionSpecified
	{
		get
		{
			return overlapActionFieldSpecified;
		}
		set
		{
			overlapActionFieldSpecified = value;
		}
	}

	public string managerComments
	{
		get
		{
			return managerCommentsField;
		}
		set
		{
			managerCommentsField = value;
		}
	}

	public string leaveReason
	{
		get
		{
			return leaveReasonField;
		}
		set
		{
			leaveReasonField = value;
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

	[SoapIgnore]
	public bool decisionIdSpecified
	{
		get
		{
			return decisionIdFieldSpecified;
		}
		set
		{
			decisionIdFieldSpecified = value;
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

	[SoapIgnore]
	public bool teamIdSpecified
	{
		get
		{
			return teamIdFieldSpecified;
		}
		set
		{
			teamIdFieldSpecified = value;
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

	public bool useDefaultAbsenceSchedule
	{
		get
		{
			return useDefaultAbsenceScheduleField;
		}
		set
		{
			useDefaultAbsenceScheduleField = value;
		}
	}

	[SoapIgnore]
	public bool useDefaultAbsenceScheduleSpecified
	{
		get
		{
			return useDefaultAbsenceScheduleFieldSpecified;
		}
		set
		{
			useDefaultAbsenceScheduleFieldSpecified = value;
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
