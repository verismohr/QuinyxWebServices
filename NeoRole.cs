using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class NeoRole
{
    private string idField;

    private string extNeoRoleIdField;

    private string nameField;

    public string id
    {
        get { return idField; }
        set { idField = value; }
    }

    public string extNeoRoleId
    {
        get { return extNeoRoleIdField; }
        set { extNeoRoleIdField = value; }
    }

    public string name
    {
        get { return nameField; }
        set { nameField = value; }
    }
}
