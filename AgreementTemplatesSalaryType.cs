using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class AgreementTemplatesSalaryType
{
	private int templateIdField;

	private string externalTemplateIdField;

	private int idField;

	private int restIdField;

	private int stCodeField;

	private string salaryCodeField;

	private string localLabelField;

	private string defaultLabelField;

	private int trackerIdField;

	private int trackerOperatorField;

	private decimal trackerFactorField;

	private int trackerId2Field;

	private int trackerOperator2Field;

	private decimal trackerFactor2Field;

	private int trackerId3Field;

	private int trackerOperator3Field;

	private decimal trackerFactor3Field;

	private bool requiresApprovalField;

	private bool approvedByDefaultField;

	private int roundField;

	private int roundCeilField;

	private bool isLeaveField;

	private bool inUseField;

	private bool isActiveField;

	private int salaryTypeCategoryField;

	private decimal salaryCostField;

	private int costTypeField;

	private bool incInTotalCostField;

	private decimal minimumValueField;

	private decimal maximumValueField;

	private bool transferToPayrollField;

	private decimal utReductionField;

	private int roundingSalaryTypeIdField;

	private bool allowManualAddField;

	private string notGeneratedAtSameTimeField;

	private DateTime tsField;

	public int templateId
	{
		get
		{
			return templateIdField;
		}
		set
		{
			templateIdField = value;
		}
	}

	public string externalTemplateId
	{
		get
		{
			return externalTemplateIdField;
		}
		set
		{
			externalTemplateIdField = value;
		}
	}

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

	public int stCode
	{
		get
		{
			return stCodeField;
		}
		set
		{
			stCodeField = value;
		}
	}

	public string salaryCode
	{
		get
		{
			return salaryCodeField;
		}
		set
		{
			salaryCodeField = value;
		}
	}

	public string localLabel
	{
		get
		{
			return localLabelField;
		}
		set
		{
			localLabelField = value;
		}
	}

	public string defaultLabel
	{
		get
		{
			return defaultLabelField;
		}
		set
		{
			defaultLabelField = value;
		}
	}

	public int trackerId
	{
		get
		{
			return trackerIdField;
		}
		set
		{
			trackerIdField = value;
		}
	}

	public int trackerOperator
	{
		get
		{
			return trackerOperatorField;
		}
		set
		{
			trackerOperatorField = value;
		}
	}

	public decimal trackerFactor
	{
		get
		{
			return trackerFactorField;
		}
		set
		{
			trackerFactorField = value;
		}
	}

	public int trackerId2
	{
		get
		{
			return trackerId2Field;
		}
		set
		{
			trackerId2Field = value;
		}
	}

	public int trackerOperator2
	{
		get
		{
			return trackerOperator2Field;
		}
		set
		{
			trackerOperator2Field = value;
		}
	}

	public decimal trackerFactor2
	{
		get
		{
			return trackerFactor2Field;
		}
		set
		{
			trackerFactor2Field = value;
		}
	}

	public int trackerId3
	{
		get
		{
			return trackerId3Field;
		}
		set
		{
			trackerId3Field = value;
		}
	}

	public int trackerOperator3
	{
		get
		{
			return trackerOperator3Field;
		}
		set
		{
			trackerOperator3Field = value;
		}
	}

	public decimal trackerFactor3
	{
		get
		{
			return trackerFactor3Field;
		}
		set
		{
			trackerFactor3Field = value;
		}
	}

	public bool requiresApproval
	{
		get
		{
			return requiresApprovalField;
		}
		set
		{
			requiresApprovalField = value;
		}
	}

	public bool approvedByDefault
	{
		get
		{
			return approvedByDefaultField;
		}
		set
		{
			approvedByDefaultField = value;
		}
	}

	public int round
	{
		get
		{
			return roundField;
		}
		set
		{
			roundField = value;
		}
	}

	public int roundCeil
	{
		get
		{
			return roundCeilField;
		}
		set
		{
			roundCeilField = value;
		}
	}

	public bool isLeave
	{
		get
		{
			return isLeaveField;
		}
		set
		{
			isLeaveField = value;
		}
	}

	public bool inUse
	{
		get
		{
			return inUseField;
		}
		set
		{
			inUseField = value;
		}
	}

	public bool isActive
	{
		get
		{
			return isActiveField;
		}
		set
		{
			isActiveField = value;
		}
	}

	public int salaryTypeCategory
	{
		get
		{
			return salaryTypeCategoryField;
		}
		set
		{
			salaryTypeCategoryField = value;
		}
	}

	public decimal salaryCost
	{
		get
		{
			return salaryCostField;
		}
		set
		{
			salaryCostField = value;
		}
	}

	public int costType
	{
		get
		{
			return costTypeField;
		}
		set
		{
			costTypeField = value;
		}
	}

	public bool incInTotalCost
	{
		get
		{
			return incInTotalCostField;
		}
		set
		{
			incInTotalCostField = value;
		}
	}

	public decimal minimumValue
	{
		get
		{
			return minimumValueField;
		}
		set
		{
			minimumValueField = value;
		}
	}

	public decimal maximumValue
	{
		get
		{
			return maximumValueField;
		}
		set
		{
			maximumValueField = value;
		}
	}

	public bool transferToPayroll
	{
		get
		{
			return transferToPayrollField;
		}
		set
		{
			transferToPayrollField = value;
		}
	}

	public decimal utReduction
	{
		get
		{
			return utReductionField;
		}
		set
		{
			utReductionField = value;
		}
	}

	public int roundingSalaryTypeId
	{
		get
		{
			return roundingSalaryTypeIdField;
		}
		set
		{
			roundingSalaryTypeIdField = value;
		}
	}

	public bool allowManualAdd
	{
		get
		{
			return allowManualAddField;
		}
		set
		{
			allowManualAddField = value;
		}
	}

	public string notGeneratedAtSameTime
	{
		get
		{
			return notGeneratedAtSameTimeField;
		}
		set
		{
			notGeneratedAtSameTimeField = value;
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
