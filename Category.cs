using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class Category
{
    private int idField;

    private string categoryNameField;

    private string extCodeField;

    private int roleField;

    private DateTime tsField;

    public int id
    {
        get { return idField; }
        set { idField = value; }
    }

    public string categoryName
    {
        get { return categoryNameField; }
        set { categoryNameField = value; }
    }

    public string extCode
    {
        get { return extCodeField; }
        set { extCodeField = value; }
    }

    public int role
    {
        get { return roleField; }
        set { roleField = value; }
    }

    public DateTime ts
    {
        get { return tsField; }
        set { tsField = value; }
    }
}
