using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class Payroll
{
	private int idField;

	private string empNameField;

	private int restIdField;

	private string badgeNoField;

	private string socsecNoField;

	private string cardNoField;

	private int pTypeField;

	private string dateField;

	private string salTypeField;

	private string inField;

	private string outField;

	private decimal hoursField;

	private string costCentreField;

	private string projectNoField;

	private string accountNoField;

	private string agrmntAdditionalField1Field;

	private string agrmntAdditionalField2Field;

	private string agrmntAdditionalField3Field;

	private string agrmntAdditionalField4Field;

	private string agrmntAdditionalField5Field;

	private string externalInfo1Field;

	private string externalInfo2Field;

	private string externalInfo3Field;

	private string decisionNoField;

	private string customerNoField;

	private int teamIdField;

	private string teamExtCodeField;

	private int scheduleIdField;

	private int punchIdField;

	private string punchDateField;

	private int orgScheduleIdField;

	private int leaveAppIdField;

	private string segmentStartDateField;

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

	public string empName
	{
		get
		{
			return empNameField;
		}
		set
		{
			empNameField = value;
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

	public string socsecNo
	{
		get
		{
			return socsecNoField;
		}
		set
		{
			socsecNoField = value;
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

	public int pType
	{
		get
		{
			return pTypeField;
		}
		set
		{
			pTypeField = value;
		}
	}

	public string date
	{
		get
		{
			return dateField;
		}
		set
		{
			dateField = value;
		}
	}

	public string salType
	{
		get
		{
			return salTypeField;
		}
		set
		{
			salTypeField = value;
		}
	}

	public string @in
	{
		get
		{
			return inField;
		}
		set
		{
			inField = value;
		}
	}

	public string @out
	{
		get
		{
			return outField;
		}
		set
		{
			outField = value;
		}
	}

	public decimal hours
	{
		get
		{
			return hoursField;
		}
		set
		{
			hoursField = value;
		}
	}

	public string costCentre
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

	public string projectNo
	{
		get
		{
			return projectNoField;
		}
		set
		{
			projectNoField = value;
		}
	}

	public string accountNo
	{
		get
		{
			return accountNoField;
		}
		set
		{
			accountNoField = value;
		}
	}

	public string agrmntAdditionalField1
	{
		get
		{
			return agrmntAdditionalField1Field;
		}
		set
		{
			agrmntAdditionalField1Field = value;
		}
	}

	public string agrmntAdditionalField2
	{
		get
		{
			return agrmntAdditionalField2Field;
		}
		set
		{
			agrmntAdditionalField2Field = value;
		}
	}

	public string agrmntAdditionalField3
	{
		get
		{
			return agrmntAdditionalField3Field;
		}
		set
		{
			agrmntAdditionalField3Field = value;
		}
	}

	public string agrmntAdditionalField4
	{
		get
		{
			return agrmntAdditionalField4Field;
		}
		set
		{
			agrmntAdditionalField4Field = value;
		}
	}

	public string agrmntAdditionalField5
	{
		get
		{
			return agrmntAdditionalField5Field;
		}
		set
		{
			agrmntAdditionalField5Field = value;
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

	public int scheduleId
	{
		get
		{
			return scheduleIdField;
		}
		set
		{
			scheduleIdField = value;
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

	public int orgScheduleId
	{
		get
		{
			return orgScheduleIdField;
		}
		set
		{
			orgScheduleIdField = value;
		}
	}

	public int leaveAppId
	{
		get
		{
			return leaveAppIdField;
		}
		set
		{
			leaveAppIdField = value;
		}
	}

	public string segmentStartDate
	{
		get
		{
			return segmentStartDateField;
		}
		set
		{
			segmentStartDateField = value;
		}
	}
}
