using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class TimePunch
{
	private int idField;

	private string employeeNameField;

	private int restIdField;

	private string badgeNoField;

	private string socsecNoField;

	private string cardNoField;

	private DateTime punchInField;

	private DateTime punchOutField;

	private DateTime orgPunchInField;

	private bool orgPunchInFieldSpecified;

	private DateTime orgPunchOutField;

	private bool orgPunchOutFieldSpecified;

	private decimal hoursField;

	private bool approvedByEmployeeField;

	private bool approvedByEmployeeFieldSpecified;

	private bool approvedByManagerField;

	private bool approvedByManagerFieldSpecified;

	private bool approvedByCustomerField;

	private bool approvedByCustomerFieldSpecified;

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

	private int scheduleIdField;

	private bool scheduleIdFieldSpecified;

	private bool transferredToPayrollField;

	private bool transferredToPayrollFieldSpecified;

	private bool deletedField;

	private bool deletedFieldSpecified;

	private bool productiveTimeField;

	private bool productiveTimeFieldSpecified;

	private bool isOpenField;

	private bool isOpenFieldSpecified;

	private string commentField;

	private string managerCommentField;

	private int employeeIdField;

	private bool employeeIdFieldSpecified;

	private int shiftCategoryIdField;

	private bool shiftCategoryIdFieldSpecified;

	private string extShiftCategoryIdField;

	private string shiftCategoryNameField;

	private int subShiftReferenceField;

	private bool subShiftReferenceFieldSpecified;

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

	public string employeeName
	{
		get
		{
			return employeeNameField;
		}
		set
		{
			employeeNameField = value;
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

	public DateTime punchIn
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

	public DateTime punchOut
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

	public DateTime orgPunchIn
	{
		get
		{
			return orgPunchInField;
		}
		set
		{
			orgPunchInField = value;
		}
	}

	[SoapIgnore]
	public bool orgPunchInSpecified
	{
		get
		{
			return orgPunchInFieldSpecified;
		}
		set
		{
			orgPunchInFieldSpecified = value;
		}
	}

	public DateTime orgPunchOut
	{
		get
		{
			return orgPunchOutField;
		}
		set
		{
			orgPunchOutField = value;
		}
	}

	[SoapIgnore]
	public bool orgPunchOutSpecified
	{
		get
		{
			return orgPunchOutFieldSpecified;
		}
		set
		{
			orgPunchOutFieldSpecified = value;
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

	[SoapIgnore]
	public bool approvedByEmployeeSpecified
	{
		get
		{
			return approvedByEmployeeFieldSpecified;
		}
		set
		{
			approvedByEmployeeFieldSpecified = value;
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

	[SoapIgnore]
	public bool approvedByManagerSpecified
	{
		get
		{
			return approvedByManagerFieldSpecified;
		}
		set
		{
			approvedByManagerFieldSpecified = value;
		}
	}

	public bool approvedByCustomer
	{
		get
		{
			return approvedByCustomerField;
		}
		set
		{
			approvedByCustomerField = value;
		}
	}

	[SoapIgnore]
	public bool approvedByCustomerSpecified
	{
		get
		{
			return approvedByCustomerFieldSpecified;
		}
		set
		{
			approvedByCustomerFieldSpecified = value;
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

	[SoapIgnore]
	public bool scheduleIdSpecified
	{
		get
		{
			return scheduleIdFieldSpecified;
		}
		set
		{
			scheduleIdFieldSpecified = value;
		}
	}

	public bool transferredToPayroll
	{
		get
		{
			return transferredToPayrollField;
		}
		set
		{
			transferredToPayrollField = value;
		}
	}

	[SoapIgnore]
	public bool transferredToPayrollSpecified
	{
		get
		{
			return transferredToPayrollFieldSpecified;
		}
		set
		{
			transferredToPayrollFieldSpecified = value;
		}
	}

	public bool deleted
	{
		get
		{
			return deletedField;
		}
		set
		{
			deletedField = value;
		}
	}

	[SoapIgnore]
	public bool deletedSpecified
	{
		get
		{
			return deletedFieldSpecified;
		}
		set
		{
			deletedFieldSpecified = value;
		}
	}

	public bool productiveTime
	{
		get
		{
			return productiveTimeField;
		}
		set
		{
			productiveTimeField = value;
		}
	}

	[SoapIgnore]
	public bool productiveTimeSpecified
	{
		get
		{
			return productiveTimeFieldSpecified;
		}
		set
		{
			productiveTimeFieldSpecified = value;
		}
	}

	public bool isOpen
	{
		get
		{
			return isOpenField;
		}
		set
		{
			isOpenField = value;
		}
	}

	[SoapIgnore]
	public bool isOpenSpecified
	{
		get
		{
			return isOpenFieldSpecified;
		}
		set
		{
			isOpenFieldSpecified = value;
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

	public string managerComment
	{
		get
		{
			return managerCommentField;
		}
		set
		{
			managerCommentField = value;
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

	public int shiftCategoryId
	{
		get
		{
			return shiftCategoryIdField;
		}
		set
		{
			shiftCategoryIdField = value;
		}
	}

	[SoapIgnore]
	public bool shiftCategoryIdSpecified
	{
		get
		{
			return shiftCategoryIdFieldSpecified;
		}
		set
		{
			shiftCategoryIdFieldSpecified = value;
		}
	}

	public string extShiftCategoryId
	{
		get
		{
			return extShiftCategoryIdField;
		}
		set
		{
			extShiftCategoryIdField = value;
		}
	}

	public string shiftCategoryName
	{
		get
		{
			return shiftCategoryNameField;
		}
		set
		{
			shiftCategoryNameField = value;
		}
	}

	public int subShiftReference
	{
		get
		{
			return subShiftReferenceField;
		}
		set
		{
			subShiftReferenceField = value;
		}
	}

	[SoapIgnore]
	public bool subShiftReferenceSpecified
	{
		get
		{
			return subShiftReferenceFieldSpecified;
		}
		set
		{
			subShiftReferenceFieldSpecified = value;
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
