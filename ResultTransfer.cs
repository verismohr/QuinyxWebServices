using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class ResultTransfer
{
    private string extTransferIdField;

    private string urlField;

    private string statusField;

    public string extTransferId
    {
        get { return extTransferIdField; }
        set { extTransferIdField = value; }
    }

    public string url
    {
        get { return urlField; }
        set { urlField = value; }
    }

    public string status
    {
        get { return statusField; }
        set { statusField = value; }
    }
}
