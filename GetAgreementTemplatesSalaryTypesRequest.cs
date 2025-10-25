using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class GetAgreementTemplatesSalaryTypesRequest
{
    private int templateIdField;

    private bool templateIdFieldSpecified;

    private string externalTemplateIdField;

    private bool onlyActiveField;

    private bool onlyActiveFieldSpecified;

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

    public string externalTemplateId
    {
        get { return externalTemplateIdField; }
        set { externalTemplateIdField = value; }
    }

    public bool onlyActive
    {
        get { return onlyActiveField; }
        set { onlyActiveField = value; }
    }

    [SoapIgnore]
    public bool onlyActiveSpecified
    {
        get { return onlyActiveFieldSpecified; }
        set { onlyActiveFieldSpecified = value; }
    }
}
