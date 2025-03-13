using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class ttFirstToExpireBalanceResultItem
{
	private int userIdField;

	private string badgeNoField;

	private int timeTrackerIdField;

	private int periodField;

	private decimal balanceField;

	private decimal statutoryField;

	private decimal nonStatutoryField;

	private string dateField;

	private string[] validationErrorsField;

	public int userId
	{
		get
		{
			return userIdField;
		}
		set
		{
			userIdField = value;
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

	public int timeTrackerId
	{
		get
		{
			return timeTrackerIdField;
		}
		set
		{
			timeTrackerIdField = value;
		}
	}

	public int period
	{
		get
		{
			return periodField;
		}
		set
		{
			periodField = value;
		}
	}

	public decimal balance
	{
		get
		{
			return balanceField;
		}
		set
		{
			balanceField = value;
		}
	}

	public decimal statutory
	{
		get
		{
			return statutoryField;
		}
		set
		{
			statutoryField = value;
		}
	}

	public decimal nonStatutory
	{
		get
		{
			return nonStatutoryField;
		}
		set
		{
			nonStatutoryField = value;
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
