using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class ProcessLeavesRecord
{
    private int leaveIdField;

    private int leaveActionField;

    private int shiftActionField;

    private string managerCommentsField;

    private string[] validationErrorsField;

    public int leaveId
    {
        get { return leaveIdField; }
        set { leaveIdField = value; }
    }

    public int leaveAction
    {
        get { return leaveActionField; }
        set { leaveActionField = value; }
    }

    public int shiftAction
    {
        get { return shiftActionField; }
        set { shiftActionField = value; }
    }

    public string managerComments
    {
        get { return managerCommentsField; }
        set { managerCommentsField = value; }
    }

    public string[] validationErrors
    {
        get { return validationErrorsField; }
        set { validationErrorsField = value; }
    }
}
