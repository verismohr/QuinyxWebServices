using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class Role
{
    private int idField;

    private string nameField;

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
}
