using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class MailAttachment
{
    private string fileNameField;

    private string fileContentField;

    public string fileName
    {
        get { return fileNameField; }
        set { fileNameField = value; }
    }

    public string fileContent
    {
        get { return fileContentField; }
        set { fileContentField = value; }
    }
}
