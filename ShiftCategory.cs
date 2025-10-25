using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class ShiftCategory
{
    private int idField;

    private string shiftTypeExtIdField;

    private string nameField;

    private int restIdField;

    private DateTime begTimeField;

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

    private int sectionField;

    private int costCentreField;

    private int salaryTypeField;

    private int accountNoField;

    private int projectNoField;

    private string accountNoExtCodeField;

    private string costCentreExtCodeField;

    private string projectNoExtCodeField;

    private string salaryTypeExtCodeField;

    private int onCallField;

    private bool isActiveField;

    private bool isFreeDayField;

    private bool countPunchHoursField;

    private bool countScheduleHoursField;

    private bool sharedToAllUnitsField;

    private scheduleCategoryUnit[] scheduleCategoryUnitsField;

    private DateTime tsField;

    private string shiftTypeCategoryNameField;

    private PayrollTag[] tagsField;

    private ScheduleCategorySkill[] skillsField;

    public int id
    {
        get { return idField; }
        set { idField = value; }
    }

    public string shiftTypeExtId
    {
        get { return shiftTypeExtIdField; }
        set { shiftTypeExtIdField = value; }
    }

    public string name
    {
        get { return nameField; }
        set { nameField = value; }
    }

    public int restId
    {
        get { return restIdField; }
        set { restIdField = value; }
    }

    [SoapElement(DataType = "time")]
    public DateTime begTime
    {
        get { return begTimeField; }
        set { begTimeField = value; }
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

    public int section
    {
        get { return sectionField; }
        set { sectionField = value; }
    }

    public int costCentre
    {
        get { return costCentreField; }
        set { costCentreField = value; }
    }

    public int salaryType
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

    public int onCall
    {
        get { return onCallField; }
        set { onCallField = value; }
    }

    public bool isActive
    {
        get { return isActiveField; }
        set { isActiveField = value; }
    }

    public bool isFreeDay
    {
        get { return isFreeDayField; }
        set { isFreeDayField = value; }
    }

    public bool countPunchHours
    {
        get { return countPunchHoursField; }
        set { countPunchHoursField = value; }
    }

    public bool countScheduleHours
    {
        get { return countScheduleHoursField; }
        set { countScheduleHoursField = value; }
    }

    public bool sharedToAllUnits
    {
        get { return sharedToAllUnitsField; }
        set { sharedToAllUnitsField = value; }
    }

    public scheduleCategoryUnit[] scheduleCategoryUnits
    {
        get { return scheduleCategoryUnitsField; }
        set { scheduleCategoryUnitsField = value; }
    }

    public DateTime ts
    {
        get { return tsField; }
        set { tsField = value; }
    }

    public string shiftTypeCategoryName
    {
        get { return shiftTypeCategoryNameField; }
        set { shiftTypeCategoryNameField = value; }
    }

    public PayrollTag[] tags
    {
        get { return tagsField; }
        set { tagsField = value; }
    }

    public ScheduleCategorySkill[] skills
    {
        get { return skillsField; }
        set { skillsField = value; }
    }
}
