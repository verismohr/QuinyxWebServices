using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class TemplateRedDay
{
    private int idField;

    private int templateIdField;

    private DateTime redDateField;

    private string descriptionField;

    private DateTime tsField;

    public int id
    {
        get { return idField; }
        set { idField = value; }
    }

    public int templateId
    {
        get { return templateIdField; }
        set { templateIdField = value; }
    }

    [SoapElement(DataType = "date")]
    public DateTime redDate
    {
        get { return redDateField; }
        set { redDateField = value; }
    }

    public string description
    {
        get { return descriptionField; }
        set { descriptionField = value; }
    }

    public DateTime ts
    {
        get { return tsField; }
        set { tsField = value; }
    }
}
