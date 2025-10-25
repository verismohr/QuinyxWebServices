using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class Schedule
{
    private int idField;

    private int restIdField;

    private DateTime begDateField;

    private DateTime begTimeField;

    private DateTime endDateField;

    private DateTime endTimeField;

    private int breakTypeField;

    private DateTime begBreakField;

    private DateTime endBreakField;

    private DateTime begBreak2Field;

    private DateTime endBreak2Field;

    private DateTime begBreak3Field;

    private DateTime endBreak3Field;

    private DateTime begBreak4Field;

    private DateTime endBreak4Field;

    private int persIdField;

    private string badgeNoField;

    private int statusField;

    private int grabbAbleField;

    private int grabbIdField;

    private int approvedField;

    private int managerIdField;

    private int categoryIdField;

    private string categoryNameField;

    private string commentField;

    private int sectionField;

    private string sectionNameField;

    private decimal costEstimateField;

    private decimal hoursField;

    private int fixSchedIdField;

    private int shiftChangedField;

    private int costCentreField;

    private int? salaryTypeField;

    private int accountNoField;

    private int projectNoField;

    private string unitNameField;

    private string accountNoExtCodeField;

    private string costCentreExtCodeField;

    private string projectNoExtCodeField;

    private string salaryTypeExtCodeField;

    private string decisionNoField;

    private string customerNoField;

    private string agrmntAdditionalField1Field;

    private string agrmntAdditionalField2Field;

    private string agrmntAdditionalField3Field;

    private string agrmntAdditionalField4Field;

    private string agrmntAdditionalField5Field;

    private DateTime agrmntPeriodStartField;

    private int agrmntPeriodTypeField;

    private int agrmntPeriodLengthField;

    private decimal agrmntWorkingHoursField;

    private int udf_value_idField;

    private int orgScheduleIdField;

    private int unAssignedField;

    private int leaveIdField;

    private string leaveExtCodeField;

    private bool productiveTimeField;

    private string shiftTypeExtCodeField;

    private DateTime tsField;

    public int id
    {
        get { return idField; }
        set { idField = value; }
    }

    public int restId
    {
        get { return restIdField; }
        set { restIdField = value; }
    }

    [SoapElement(DataType = "date")]
    public DateTime begDate
    {
        get { return begDateField; }
        set { begDateField = value; }
    }

    [SoapElement(DataType = "time")]
    public DateTime begTime
    {
        get { return begTimeField; }
        set { begTimeField = value; }
    }

    [SoapElement(DataType = "date")]
    public DateTime endDate
    {
        get { return endDateField; }
        set { endDateField = value; }
    }

    [SoapElement(DataType = "time")]
    public DateTime endTime
    {
        get { return endTimeField; }
        set { endTimeField = value; }
    }

    public int breakType
    {
        get { return breakTypeField; }
        set { breakTypeField = value; }
    }

    [SoapElement(DataType = "time")]
    public DateTime begBreak
    {
        get { return begBreakField; }
        set { begBreakField = value; }
    }

    [SoapElement(DataType = "time")]
    public DateTime endBreak
    {
        get { return endBreakField; }
        set { endBreakField = value; }
    }

    [SoapElement(DataType = "time")]
    public DateTime begBreak2
    {
        get { return begBreak2Field; }
        set { begBreak2Field = value; }
    }

    [SoapElement(DataType = "time")]
    public DateTime endBreak2
    {
        get { return endBreak2Field; }
        set { endBreak2Field = value; }
    }

    [SoapElement(DataType = "time")]
    public DateTime begBreak3
    {
        get { return begBreak3Field; }
        set { begBreak3Field = value; }
    }

    [SoapElement(DataType = "time")]
    public DateTime endBreak3
    {
        get { return endBreak3Field; }
        set { endBreak3Field = value; }
    }

    [SoapElement(DataType = "time")]
    public DateTime begBreak4
    {
        get { return begBreak4Field; }
        set { begBreak4Field = value; }
    }

    [SoapElement(DataType = "time")]
    public DateTime endBreak4
    {
        get { return endBreak4Field; }
        set { endBreak4Field = value; }
    }

    public int persId
    {
        get { return persIdField; }
        set { persIdField = value; }
    }

    public string badgeNo
    {
        get { return badgeNoField; }
        set { badgeNoField = value; }
    }

    public int status
    {
        get { return statusField; }
        set { statusField = value; }
    }

    public int grabbAble
    {
        get { return grabbAbleField; }
        set { grabbAbleField = value; }
    }

    public int grabbId
    {
        get { return grabbIdField; }
        set { grabbIdField = value; }
    }

    public int approved
    {
        get { return approvedField; }
        set { approvedField = value; }
    }

    public int managerId
    {
        get { return managerIdField; }
        set { managerIdField = value; }
    }

    public int categoryId
    {
        get { return categoryIdField; }
        set { categoryIdField = value; }
    }

    public string categoryName
    {
        get { return categoryNameField; }
        set { categoryNameField = value; }
    }

    public string comment
    {
        get { return commentField; }
        set { commentField = value; }
    }

    public int section
    {
        get { return sectionField; }
        set { sectionField = value; }
    }

    public string sectionName
    {
        get { return sectionNameField; }
        set { sectionNameField = value; }
    }

    public decimal costEstimate
    {
        get { return costEstimateField; }
        set { costEstimateField = value; }
    }

    public decimal hours
    {
        get { return hoursField; }
        set { hoursField = value; }
    }

    public int fixSchedId
    {
        get { return fixSchedIdField; }
        set { fixSchedIdField = value; }
    }

    public int shiftChanged
    {
        get { return shiftChangedField; }
        set { shiftChangedField = value; }
    }

    public int costCentre
    {
        get { return costCentreField; }
        set { costCentreField = value; }
    }

    [SoapElement(IsNullable = true)]
    public int? salaryType
    {
        get { return salaryTypeField; }
        set { salaryTypeField = value; }
    }

    public int accountNo
    {
        get { return accountNoField; }
        set { accountNoField = value; }
    }

    public int projectNo
    {
        get { return projectNoField; }
        set { projectNoField = value; }
    }

    public string unitName
    {
        get { return unitNameField; }
        set { unitNameField = value; }
    }

    public string accountNoExtCode
    {
        get { return accountNoExtCodeField; }
        set { accountNoExtCodeField = value; }
    }

    public string costCentreExtCode
    {
        get { return costCentreExtCodeField; }
        set { costCentreExtCodeField = value; }
    }

    public string projectNoExtCode
    {
        get { return projectNoExtCodeField; }
        set { projectNoExtCodeField = value; }
    }

    public string salaryTypeExtCode
    {
        get { return salaryTypeExtCodeField; }
        set { salaryTypeExtCodeField = value; }
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

    [SoapElement(DataType = "date")]
    public DateTime agrmntPeriodStart
    {
        get { return agrmntPeriodStartField; }
        set { agrmntPeriodStartField = value; }
    }

    public int agrmntPeriodType
    {
        get { return agrmntPeriodTypeField; }
        set { agrmntPeriodTypeField = value; }
    }

    public int agrmntPeriodLength
    {
        get { return agrmntPeriodLengthField; }
        set { agrmntPeriodLengthField = value; }
    }

    public decimal agrmntWorkingHours
    {
        get { return agrmntWorkingHoursField; }
        set { agrmntWorkingHoursField = value; }
    }

    public int udf_value_id
    {
        get { return udf_value_idField; }
        set { udf_value_idField = value; }
    }

    public int orgScheduleId
    {
        get { return orgScheduleIdField; }
        set { orgScheduleIdField = value; }
    }

    public int unAssigned
    {
        get { return unAssignedField; }
        set { unAssignedField = value; }
    }

    public int leaveId
    {
        get { return leaveIdField; }
        set { leaveIdField = value; }
    }

    public string leaveExtCode
    {
        get { return leaveExtCodeField; }
        set { leaveExtCodeField = value; }
    }

    public bool productiveTime
    {
        get { return productiveTimeField; }
        set { productiveTimeField = value; }
    }

    public string shiftTypeExtCode
    {
        get { return shiftTypeExtCodeField; }
        set { shiftTypeExtCodeField = value; }
    }

    public DateTime ts
    {
        get { return tsField; }
        set { tsField = value; }
    }
}
