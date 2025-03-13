using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class LeaveApplicationV2
{
	private int idField;

	private string headerField;

	private string bodytextField;

	private DateTime senddateField;

	private int fromPersIdField;

	private string fromBadgeNoField;

	private int? toPersIdField;

	private int beenViewedField;

	private string leaveReasonField;

	private string oldLeaveReasonField;

	private DateTime fromDateField;

	private DateTime fromTimeField;

	private DateTime toDateField;

	private DateTime toTimeField;

	private int restIdField;

	private string extCodeField;

	private decimal estHoursField;

	private decimal estSalaryField;

	private decimal sickLevelField;

	private int isPreliminaryField;

	private string externalInfo1Field;

	private string externalInfo2Field;

	private string externalInfo3Field;

	private bool approvedByManagerField;

	private bool approvedByEmployeeField;

	private DateTime tsField;

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

	public string header
	{
		get
		{
			return headerField;
		}
		set
		{
			headerField = value;
		}
	}

	public string bodytext
	{
		get
		{
			return bodytextField;
		}
		set
		{
			bodytextField = value;
		}
	}

	public DateTime senddate
	{
		get
		{
			return senddateField;
		}
		set
		{
			senddateField = value;
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

	public string fromBadgeNo
	{
		get
		{
			return fromBadgeNoField;
		}
		set
		{
			fromBadgeNoField = value;
		}
	}

	[SoapElement(IsNullable = true)]
	public int? toPersId
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

	public int beenViewed
	{
		get
		{
			return beenViewedField;
		}
		set
		{
			beenViewedField = value;
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

	public string oldLeaveReason
	{
		get
		{
			return oldLeaveReasonField;
		}
		set
		{
			oldLeaveReasonField = value;
		}
	}

	[SoapElement(DataType = "date")]
	public DateTime fromDate
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

	[SoapElement(DataType = "time")]
	public DateTime fromTime
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

	[SoapElement(DataType = "date")]
	public DateTime toDate
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

	[SoapElement(DataType = "time")]
	public DateTime toTime
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

	public decimal estHours
	{
		get
		{
			return estHoursField;
		}
		set
		{
			estHoursField = value;
		}
	}

	public decimal estSalary
	{
		get
		{
			return estSalaryField;
		}
		set
		{
			estSalaryField = value;
		}
	}

	public decimal sickLevel
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

	public bool approvedByManager
	{
		get
		{
			return approvedByManagerField;
		}
		set
		{
			approvedByManagerField = value;
		}
	}

	public bool approvedByEmployee
	{
		get
		{
			return approvedByEmployeeField;
		}
		set
		{
			approvedByEmployeeField = value;
		}
	}

	public DateTime ts
	{
		get
		{
			return tsField;
		}
		set
		{
			tsField = value;
		}
	}
}
