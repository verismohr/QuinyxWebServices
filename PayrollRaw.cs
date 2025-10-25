using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class PayrollRaw
{
    private int idField;

    private string empNameField;

    private int restIdField;

    private string badgeNoField;

    private string socsecNoField;

    private string cardNoField;

    private string punchIdField;

    private string punchDateField;

    private string punchInField;

    private string punchOutField;

    private decimal hoursField;

    private string costCentreField;

    private string projectNoField;

    private string accountNoField;

    private string salaryTypeField;

    private string begTimeField;

    private string endTimeField;

    private decimal shiftHoursField;

    private decimal punchHoursField;

    private string pTypeField;

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

    public string punchId
    {
        get { return punchIdField; }
        set { punchIdField = value; }
    }

    public string punchDate
    {
        get { return punchDateField; }
        set { punchDateField = value; }
    }

    public string punchIn
    {
        get { return punchInField; }
        set { punchInField = value; }
    }

    public string punchOut
    {
        get { return punchOutField; }
        set { punchOutField = value; }
    }

    public decimal hours
    {
        get { return hoursField; }
        set { hoursField = value; }
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

    public string salaryType
    {
        get { return salaryTypeField; }
        set { salaryTypeField = value; }
    }

    public string begTime
    {
        get { return begTimeField; }
        set { begTimeField = value; }
    }

    public string endTime
    {
        get { return endTimeField; }
        set { endTimeField = value; }
    }

    public decimal shiftHours
    {
        get { return shiftHoursField; }
        set { shiftHoursField = value; }
    }

    public decimal punchHours
    {
        get { return punchHoursField; }
        set { punchHoursField = value; }
    }

    public string pType
    {
        get { return pTypeField; }
        set { pTypeField = value; }
    }
}
