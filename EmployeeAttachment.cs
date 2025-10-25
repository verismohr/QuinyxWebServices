using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class EmployeeAttachment
{
    private int employeeIdField;

    private FileAttachment[] attachmentsField;

    private string[] validationErrorsField;

    public int employeeId
    {
        get { return employeeIdField; }
        set { employeeIdField = value; }
    }

    public FileAttachment[] attachments
    {
        get { return attachmentsField; }
        set { attachmentsField = value; }
    }

    public string[] validationErrors
    {
        get { return validationErrorsField; }
        set { validationErrorsField = value; }
    }
}
