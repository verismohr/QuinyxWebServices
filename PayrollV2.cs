using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class PayrollV2
{
    private int idField;

    private string empNameField;

    private int restIdField;

    private string badgeNoField;

    private string socsecNoField;

    private string cardNoField;

    private int pTypeField;

    private DateTime dateField;

    private string salTypeField;

    private string inField;

    private string outField;

    private decimal hoursField;

    private bool salaryMgrAttestField;

    private bool salaryMgrAttestFieldSpecified;

    private bool transactionEmpAttestField;

    private bool transactionEmpAttestFieldSpecified;

    private bool transactionMgrAttestField;

    private bool transactionMgrAttestFieldSpecified;

    private bool transactionCustAttestField;

    private bool transactionCustAttestFieldSpecified;

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

    private DateTime punchDateField;

    private int orgScheduleIdField;

    private int leaveAppIdField;

    private DateTime segmentStartDateField;

    private bool productiveTimeField;

    private decimal netCostField;

    private bool netCostFieldSpecified;

    private decimal absenceCostField;

    private bool absenceCostFieldSpecified;

    private decimal socialCostField;

    private bool socialCostFieldSpecified;

    private decimal totalCostField;

    private bool totalCostFieldSpecified;

    private PayrollTag[] tagsField;

    private int stCodeField;

    private bool stCodeFieldSpecified;

    public int id
    {
        get { return idField; }
        set { idField = value; }
    }

    public string empName
    {
        get { return empNameField; }
        set { empNameField = value; }
    }

    public int restId
    {
        get { return restIdField; }
        set { restIdField = value; }
    }

    public string badgeNo
    {
        get { return badgeNoField; }
        set { badgeNoField = value; }
    }

    public string socsecNo
    {
        get { return socsecNoField; }
        set { socsecNoField = value; }
    }

    public string cardNo
    {
        get { return cardNoField; }
        set { cardNoField = value; }
    }

    public int pType
    {
        get { return pTypeField; }
        set { pTypeField = value; }
    }

    [SoapElement(DataType = "date")]
    public DateTime date
    {
        get { return dateField; }
        set { dateField = value; }
    }

    public string salType
    {
        get { return salTypeField; }
        set { salTypeField = value; }
    }

    public string @in
    {
        get { return inField; }
        set { inField = value; }
    }

    public string @out
    {
        get { return outField; }
        set { outField = value; }
    }

    public decimal hours
    {
        get { return hoursField; }
        set { hoursField = value; }
    }

    public bool salaryMgrAttest
    {
        get { return salaryMgrAttestField; }
        set { salaryMgrAttestField = value; }
    }

    [SoapIgnore]
    public bool salaryMgrAttestSpecified
    {
        get { return salaryMgrAttestFieldSpecified; }
        set { salaryMgrAttestFieldSpecified = value; }
    }

    public bool transactionEmpAttest
    {
        get { return transactionEmpAttestField; }
        set { transactionEmpAttestField = value; }
    }

    [SoapIgnore]
    public bool transactionEmpAttestSpecified
    {
        get { return transactionEmpAttestFieldSpecified; }
        set { transactionEmpAttestFieldSpecified = value; }
    }

    public bool transactionMgrAttest
    {
        get { return transactionMgrAttestField; }
        set { transactionMgrAttestField = value; }
    }

    [SoapIgnore]
    public bool transactionMgrAttestSpecified
    {
        get { return transactionMgrAttestFieldSpecified; }
        set { transactionMgrAttestFieldSpecified = value; }
    }

    public bool transactionCustAttest
    {
        get { return transactionCustAttestField; }
        set { transactionCustAttestField = value; }
    }

    [SoapIgnore]
    public bool transactionCustAttestSpecified
    {
        get { return transactionCustAttestFieldSpecified; }
        set { transactionCustAttestFieldSpecified = value; }
    }

    public string costCentre
    {
        get { return costCentreField; }
        set { costCentreField = value; }
    }

    public string projectNo
    {
        get { return projectNoField; }
        set { projectNoField = value; }
    }

    public string accountNo
    {
        get { return accountNoField; }
        set { accountNoField = value; }
    }

    public string agrmntAdditionalField1
    {
        get { return agrmntAdditionalField1Field; }
        set { agrmntAdditionalField1Field = value; }
    }

    public string agrmntAdditionalField2
    {
        get { return agrmntAdditionalField2Field; }
        set { agrmntAdditionalField2Field = value; }
    }

    public string agrmntAdditionalField3
    {
        get { return agrmntAdditionalField3Field; }
        set { agrmntAdditionalField3Field = value; }
    }

    public string agrmntAdditionalField4
    {
        get { return agrmntAdditionalField4Field; }
        set { agrmntAdditionalField4Field = value; }
    }

    public string agrmntAdditionalField5
    {
        get { return agrmntAdditionalField5Field; }
        set { agrmntAdditionalField5Field = value; }
    }

    public string externalInfo1
    {
        get { return externalInfo1Field; }
        set { externalInfo1Field = value; }
    }

    public string externalInfo2
    {
        get { return externalInfo2Field; }
        set { externalInfo2Field = value; }
    }

    public string externalInfo3
    {
        get { return externalInfo3Field; }
        set { externalInfo3Field = value; }
    }

    public string decisionNo
    {
        get { return decisionNoField; }
        set { decisionNoField = value; }
    }

    public string customerNo
    {
        get { return customerNoField; }
        set { customerNoField = value; }
    }

    public int teamId
    {
        get { return teamIdField; }
        set { teamIdField = value; }
    }

    public string teamExtCode
    {
        get { return teamExtCodeField; }
        set { teamExtCodeField = value; }
    }

    public int scheduleId
    {
        get { return scheduleIdField; }
        set { scheduleIdField = value; }
    }

    public int punchId
    {
        get { return punchIdField; }
        set { punchIdField = value; }
    }

    [SoapElement(DataType = "date")]
    public DateTime punchDate
    {
        get { return punchDateField; }
        set { punchDateField = value; }
    }

    public int orgScheduleId
    {
        get { return orgScheduleIdField; }
        set { orgScheduleIdField = value; }
    }

    public int leaveAppId
    {
        get { return leaveAppIdField; }
        set { leaveAppIdField = value; }
    }

    [SoapElement(DataType = "date")]
    public DateTime segmentStartDate
    {
        get { return segmentStartDateField; }
        set { segmentStartDateField = value; }
    }

    public bool productiveTime
    {
        get { return productiveTimeField; }
        set { productiveTimeField = value; }
    }

    public decimal netCost
    {
        get { return netCostField; }
        set { netCostField = value; }
    }

    [SoapIgnore]
    public bool netCostSpecified
    {
        get { return netCostFieldSpecified; }
        set { netCostFieldSpecified = value; }
    }

    public decimal absenceCost
    {
        get { return absenceCostField; }
        set { absenceCostField = value; }
    }

    [SoapIgnore]
    public bool absenceCostSpecified
    {
        get { return absenceCostFieldSpecified; }
        set { absenceCostFieldSpecified = value; }
    }

    public decimal socialCost
    {
        get { return socialCostField; }
        set { socialCostField = value; }
    }

    [SoapIgnore]
    public bool socialCostSpecified
    {
        get { return socialCostFieldSpecified; }
        set { socialCostFieldSpecified = value; }
    }

    public decimal totalCost
    {
        get { return totalCostField; }
        set { totalCostField = value; }
    }

    [SoapIgnore]
    public bool totalCostSpecified
    {
        get { return totalCostFieldSpecified; }
        set { totalCostFieldSpecified = value; }
    }

    public PayrollTag[] tags
    {
        get { return tagsField; }
        set { tagsField = value; }
    }

    public int stCode
    {
        get { return stCodeField; }
        set { stCodeField = value; }
    }

    [SoapIgnore]
    public bool stCodeSpecified
    {
        get { return stCodeFieldSpecified; }
        set { stCodeFieldSpecified = value; }
    }
}
