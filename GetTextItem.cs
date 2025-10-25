using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class GetTextItem
{
    private int idField;

    private string tagField;

    private string ttextField;

    private string extCodeField;

    private string showInWebpunchField;

    private bool checkedField;

    private bool checkedFieldSpecified;

    private string[] validationErrorsField;

    public int id
    {
        get { return idField; }
        set { idField = value; }
    }

    public string tag
    {
        get { return tagField; }
        set { tagField = value; }
    }

    public string ttext
    {
        get { return ttextField; }
        set { ttextField = value; }
    }

    public string extCode
    {
        get { return extCodeField; }
        set { extCodeField = value; }
    }

    public string showInWebpunch
    {
        get { return showInWebpunchField; }
        set { showInWebpunchField = value; }
    }

    public bool @checked
    {
        get { return checkedField; }
        set { checkedField = value; }
    }

    [SoapIgnore]
    public bool checkedSpecified
    {
        get { return checkedFieldSpecified; }
        set { checkedFieldSpecified = value; }
    }

    public string[] validationErrors
    {
        get { return validationErrorsField; }
        set { validationErrorsField = value; }
    }
}
