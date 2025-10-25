using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class Geo
{
    private decimal latitudeField;

    private decimal longitudeField;

    private int radiusField;

    private string commentField;

    public decimal latitude
    {
        get { return latitudeField; }
        set { latitudeField = value; }
    }

    public decimal longitude
    {
        get { return longitudeField; }
        set { longitudeField = value; }
    }

    public int radius
    {
        get { return radiusField; }
        set { radiusField = value; }
    }

    public string comment
    {
        get { return commentField; }
        set { commentField = value; }
    }
}
