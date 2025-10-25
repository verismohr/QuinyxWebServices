using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class NeoGroup
{
    private int idField;

    private string extGroupIdField;

    private string nameField;

    private string typeField;

    private string belongsToField;

    public int id
    {
        get { return idField; }
        set { idField = value; }
    }

    public string extGroupId
    {
        get { return extGroupIdField; }
        set { extGroupIdField = value; }
    }

    public string name
    {
        get { return nameField; }
        set { nameField = value; }
    }

    public string type
    {
        get { return typeField; }
        set { typeField = value; }
    }

    public string belongsTo
    {
        get { return belongsToField; }
        set { belongsToField = value; }
    }
}
