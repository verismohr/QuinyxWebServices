using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class BankHoliday
{
    private DateTime dateField;

    private string descriptionField;

    [SoapElement(DataType = "date")]
    public DateTime date
    {
        get { return dateField; }
        set { dateField = value; }
    }

    public string description
    {
        get { return descriptionField; }
        set { descriptionField = value; }
    }
}
