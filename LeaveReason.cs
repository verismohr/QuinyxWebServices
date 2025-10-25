using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class LeaveReason
{
    private int idField;

    private string nameField;

    private string extCodeField;

    private string confirmationTextField;

    private int salaryBaseField;

    private string abbrCodeField;

    private DateTime tsField;

    public int id
    {
        get { return idField; }
        set { idField = value; }
    }

    public string name
    {
        get { return nameField; }
        set { nameField = value; }
    }

    public string extCode
    {
        get { return extCodeField; }
        set { extCodeField = value; }
    }

    public string confirmationText
    {
        get { return confirmationTextField; }
        set { confirmationTextField = value; }
    }

    public int salaryBase
    {
        get { return salaryBaseField; }
        set { salaryBaseField = value; }
    }

    public string abbrCode
    {
        get { return abbrCodeField; }
        set { abbrCodeField = value; }
    }

    public DateTime ts
    {
        get { return tsField; }
        set { tsField = value; }
    }
}
