using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class Tag
{
    private string categoryExternalIdField;

    private string tagExternalIdField;

    public string categoryExternalId
    {
        get { return categoryExternalIdField; }
        set { categoryExternalIdField = value; }
    }

    public string tagExternalId
    {
        get { return tagExternalIdField; }
        set { tagExternalIdField = value; }
    }
}
