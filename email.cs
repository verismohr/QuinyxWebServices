using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class email
{
    private string email1Field;

    [SoapElement("email")]
    public string email1
    {
        get { return email1Field; }
        set { email1Field = value; }
    }
}
