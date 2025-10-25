using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class moveEmployee
{
    private string badgeNoField;

    private string unitExtCodeField;

    private string newUnitStartDateField;

    private string oldUnitEndShareDateField;

    private string sharableOnNewUnitFromField;

    private string sectionField;

    private string costCentreField;

    private string reportingToField;

    private string moveIdField;

    private string[] validationErrorsField;

    public string badgeNo
    {
        get { return badgeNoField; }
        set { badgeNoField = value; }
    }

    public string unitExtCode
    {
        get { return unitExtCodeField; }
        set { unitExtCodeField = value; }
    }

    public string newUnitStartDate
    {
        get { return newUnitStartDateField; }
        set { newUnitStartDateField = value; }
    }

    public string oldUnitEndShareDate
    {
        get { return oldUnitEndShareDateField; }
        set { oldUnitEndShareDateField = value; }
    }

    public string sharableOnNewUnitFrom
    {
        get { return sharableOnNewUnitFromField; }
        set { sharableOnNewUnitFromField = value; }
    }

    public string section
    {
        get { return sectionField; }
        set { sectionField = value; }
    }

    public string costCentre
    {
        get { return costCentreField; }
        set { costCentreField = value; }
    }

    public string reportingTo
    {
        get { return reportingToField; }
        set { reportingToField = value; }
    }

    public string moveId
    {
        get { return moveIdField; }
        set { moveIdField = value; }
    }

    public string[] validationErrors
    {
        get { return validationErrorsField; }
        set { validationErrorsField = value; }
    }
}
