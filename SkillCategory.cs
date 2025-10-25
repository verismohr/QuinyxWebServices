using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class SkillCategory
{
    private int scatIdField;

    private string scatShortnameField;

    private string scatNameField;

    private Skill[] skillsField;

    private DateTime tsField;

    public int scatId
    {
        get { return scatIdField; }
        set { scatIdField = value; }
    }

    public string scatShortname
    {
        get { return scatShortnameField; }
        set { scatShortnameField = value; }
    }

    public string scatName
    {
        get { return scatNameField; }
        set { scatNameField = value; }
    }

    public Skill[] skills
    {
        get { return skillsField; }
        set { skillsField = value; }
    }

    public DateTime ts
    {
        get { return tsField; }
        set { tsField = value; }
    }
}
