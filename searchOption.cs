using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class searchOption
{
	private string extTransferIdField;

	private DateTime fromDateField;

	private DateTime toDateField;

	private int[] userIdsField;

	private string[] badgeNosField;

	private int[] unitIdsField;

	private string[] extUnitIdsField;

	private int includeSalariesOptionsField;

	private bool includeSalariesOptionsFieldSpecified;

	private string[] unitGroupsField;

	private int[] costCentresField;

	private string[] extCostCentresField;

	private int[] sectionIdsField;

	private string[] extSectionIdsField;

	private int[] staffCategoriesField;

	private int[] skillsField;

	private bool includeNotFullyApprovedField;

	private bool includeNotFullyApprovedFieldSpecified;

	private string payrollSystemField;

	private bool isPreliminaryField;

	private bool isPreliminaryFieldSpecified;

	private bool lockSalaryPeriodField;

	private bool lockSalaryPeriodFieldSpecified;

	private bool uploadFileToServerField;

	private bool uploadFileToServerFieldSpecified;

	public string extTransferId
	{
		get
		{
			return extTransferIdField;
		}
		set
		{
			extTransferIdField = value;
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

	public int[] userIds
	{
		get
		{
			return userIdsField;
		}
		set
		{
			userIdsField = value;
		}
	}

	public string[] badgeNos
	{
		get
		{
			return badgeNosField;
		}
		set
		{
			badgeNosField = value;
		}
	}

	public int[] unitIds
	{
		get
		{
			return unitIdsField;
		}
		set
		{
			unitIdsField = value;
		}
	}

	public string[] extUnitIds
	{
		get
		{
			return extUnitIdsField;
		}
		set
		{
			extUnitIdsField = value;
		}
	}

	public int includeSalariesOptions
	{
		get
		{
			return includeSalariesOptionsField;
		}
		set
		{
			includeSalariesOptionsField = value;
		}
	}

	[SoapIgnore]
	public bool includeSalariesOptionsSpecified
	{
		get
		{
			return includeSalariesOptionsFieldSpecified;
		}
		set
		{
			includeSalariesOptionsFieldSpecified = value;
		}
	}

	public string[] unitGroups
	{
		get
		{
			return unitGroupsField;
		}
		set
		{
			unitGroupsField = value;
		}
	}

	public int[] costCentres
	{
		get
		{
			return costCentresField;
		}
		set
		{
			costCentresField = value;
		}
	}

	public string[] extCostCentres
	{
		get
		{
			return extCostCentresField;
		}
		set
		{
			extCostCentresField = value;
		}
	}

	public int[] sectionIds
	{
		get
		{
			return sectionIdsField;
		}
		set
		{
			sectionIdsField = value;
		}
	}

	public string[] extSectionIds
	{
		get
		{
			return extSectionIdsField;
		}
		set
		{
			extSectionIdsField = value;
		}
	}

	public int[] staffCategories
	{
		get
		{
			return staffCategoriesField;
		}
		set
		{
			staffCategoriesField = value;
		}
	}

	public int[] skills
	{
		get
		{
			return skillsField;
		}
		set
		{
			skillsField = value;
		}
	}

	public bool includeNotFullyApproved
	{
		get
		{
			return includeNotFullyApprovedField;
		}
		set
		{
			includeNotFullyApprovedField = value;
		}
	}

	[SoapIgnore]
	public bool includeNotFullyApprovedSpecified
	{
		get
		{
			return includeNotFullyApprovedFieldSpecified;
		}
		set
		{
			includeNotFullyApprovedFieldSpecified = value;
		}
	}

	public string payrollSystem
	{
		get
		{
			return payrollSystemField;
		}
		set
		{
			payrollSystemField = value;
		}
	}

	public bool isPreliminary
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

	public bool lockSalaryPeriod
	{
		get
		{
			return lockSalaryPeriodField;
		}
		set
		{
			lockSalaryPeriodField = value;
		}
	}

	[SoapIgnore]
	public bool lockSalaryPeriodSpecified
	{
		get
		{
			return lockSalaryPeriodFieldSpecified;
		}
		set
		{
			lockSalaryPeriodFieldSpecified = value;
		}
	}

	public bool uploadFileToServer
	{
		get
		{
			return uploadFileToServerField;
		}
		set
		{
			uploadFileToServerField = value;
		}
	}

	[SoapIgnore]
	public bool uploadFileToServerSpecified
	{
		get
		{
			return uploadFileToServerFieldSpecified;
		}
		set
		{
			uploadFileToServerFieldSpecified = value;
		}
	}
}
