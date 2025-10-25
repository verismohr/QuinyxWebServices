using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class GetAgreementTemplatesV2
{
    private int templateIdField;

    private bool templateIdFieldSpecified;

    private string extTemplateIdField;

    private string modifiedAfterField;

    public int templateId
    {
        get { return templateIdField; }
        set { templateIdField = value; }
    }

    [SoapIgnore]
    public bool templateIdSpecified
    {
        get { return templateIdFieldSpecified; }
        set { templateIdFieldSpecified = value; }
    }

    public string extTemplateId
    {
        get { return extTemplateIdField; }
        set { extTemplateIdField = value; }
    }

    public string modifiedAfter
    {
        get { return modifiedAfterField; }
        set { modifiedAfterField = value; }
    }
}
