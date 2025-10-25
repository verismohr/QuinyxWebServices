using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class TransferStatus
{
    private string extTransferIdField;

    private string statusField;

    private string[] validationErrorsField;

    public string extTransferId
    {
        get { return extTransferIdField; }
        set { extTransferIdField = value; }
    }

    public string status
    {
        get { return statusField; }
        set { statusField = value; }
    }

    public string[] validationErrors
    {
        get { return validationErrorsField; }
        set { validationErrorsField = value; }
    }
}
