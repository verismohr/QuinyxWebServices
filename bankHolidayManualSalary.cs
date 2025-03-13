using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class bankHolidayManualSalary
{
	private int idField;

	private int salTypeStCode1Field;

	private int functionTypeField;

	private int timeIntervalTypeField;

	private decimal multiFactorField;

	private int salTypeStCode2Field;

	private int ruleConditionField;

	private int ruleOperatorField;

	private int ruleSalaryTypeStCodeField;

	private decimal ruleWorkedHrsField;

	private string startTimeField;

	private string endTimeField;

	private decimal minMinutesField;

	private decimal maxMinutesField;

	private string refTypeField;

	private string commentField;

	private int parentRuleIdField;

	private bool inheritParentField;

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

	public int salTypeStCode1
	{
		get
		{
			return salTypeStCode1Field;
		}
		set
		{
			salTypeStCode1Field = value;
		}
	}

	public int functionType
	{
		get
		{
			return functionTypeField;
		}
		set
		{
			functionTypeField = value;
		}
	}

	public int timeIntervalType
	{
		get
		{
			return timeIntervalTypeField;
		}
		set
		{
			timeIntervalTypeField = value;
		}
	}

	public decimal multiFactor
	{
		get
		{
			return multiFactorField;
		}
		set
		{
			multiFactorField = value;
		}
	}

	public int salTypeStCode2
	{
		get
		{
			return salTypeStCode2Field;
		}
		set
		{
			salTypeStCode2Field = value;
		}
	}

	public int ruleCondition
	{
		get
		{
			return ruleConditionField;
		}
		set
		{
			ruleConditionField = value;
		}
	}

	public int ruleOperator
	{
		get
		{
			return ruleOperatorField;
		}
		set
		{
			ruleOperatorField = value;
		}
	}

	public int ruleSalaryTypeStCode
	{
		get
		{
			return ruleSalaryTypeStCodeField;
		}
		set
		{
			ruleSalaryTypeStCodeField = value;
		}
	}

	public decimal ruleWorkedHrs
	{
		get
		{
			return ruleWorkedHrsField;
		}
		set
		{
			ruleWorkedHrsField = value;
		}
	}

	public string startTime
	{
		get
		{
			return startTimeField;
		}
		set
		{
			startTimeField = value;
		}
	}

	public string endTime
	{
		get
		{
			return endTimeField;
		}
		set
		{
			endTimeField = value;
		}
	}

	public decimal minMinutes
	{
		get
		{
			return minMinutesField;
		}
		set
		{
			minMinutesField = value;
		}
	}

	public decimal maxMinutes
	{
		get
		{
			return maxMinutesField;
		}
		set
		{
			maxMinutesField = value;
		}
	}

	public string refType
	{
		get
		{
			return refTypeField;
		}
		set
		{
			refTypeField = value;
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

	public int parentRuleId
	{
		get
		{
			return parentRuleIdField;
		}
		set
		{
			parentRuleIdField = value;
		}
	}

	public bool inheritParent
	{
		get
		{
			return inheritParentField;
		}
		set
		{
			inheritParentField = value;
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
