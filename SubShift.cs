using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class SubShift
{
    private int idField;

    private bool idFieldSpecified;

    private int categoryIdField;

    private bool categoryIdFieldSpecified;

    private string categoryNameField;

    private string begTimeField;

    private string endTimeField;

    private int sectionField;

    private bool sectionFieldSpecified;

    private int projectNoField;

    private bool projectNoFieldSpecified;

    private int costCentreField;

    private bool costCentreFieldSpecified;

    private ShiftCategoriesTag[] tagsField;

    public int id
    {
        get { return idField; }
        set { idField = value; }
    }

    [SoapIgnore]
    public bool idSpecified
    {
        get { return idFieldSpecified; }
        set { idFieldSpecified = value; }
    }

    public int categoryId
    {
        get { return categoryIdField; }
        set { categoryIdField = value; }
    }

    [SoapIgnore]
    public bool categoryIdSpecified
    {
        get { return categoryIdFieldSpecified; }
        set { categoryIdFieldSpecified = value; }
    }

    public string categoryName
    {
        get { return categoryNameField; }
        set { categoryNameField = value; }
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

    public int section
    {
        get { return sectionField; }
        set { sectionField = value; }
    }

    [SoapIgnore]
    public bool sectionSpecified
    {
        get { return sectionFieldSpecified; }
        set { sectionFieldSpecified = value; }
    }

    public int projectNo
    {
        get { return projectNoField; }
        set { projectNoField = value; }
    }

    [SoapIgnore]
    public bool projectNoSpecified
    {
        get { return projectNoFieldSpecified; }
        set { projectNoFieldSpecified = value; }
    }

    public int costCentre
    {
        get { return costCentreField; }
        set { costCentreField = value; }
    }

    [SoapIgnore]
    public bool costCentreSpecified
    {
        get { return costCentreFieldSpecified; }
        set { costCentreFieldSpecified = value; }
    }

    public ShiftCategoriesTag[] tags
    {
        get { return tagsField; }
        set { tagsField = value; }
    }
}
