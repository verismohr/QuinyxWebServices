using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class Unit
{
    private int idField;

    private string extUnitIdField;

    private int groupIdField;

    private bool groupIdFieldSpecified;

    private string extGroupIdField;

    private string nameField;

    private string extApplicationIdField;

    private int managerIdField;

    private string managerBadgeNoField;

    private int managerGroupIdField;

    private decimal maxHourDayField;

    private decimal maxHourWeekField;

    private int minShiftField;

    private int minRestField;

    private DateTime publishedToField;

    private string currencyField;

    private int noBreaksField;

    private int premium1Field;

    private int premium2Field;

    private int businessBreakField;

    private bool businessBreakFieldSpecified;

    private int costCentreField;

    private string costCentreExtCodeField;

    private int districtIdField;

    private string countryField;

    private string addressField;

    private string zipCodeField;

    private string cityField;

    private string municipalityField;

    private int nextBadgeNoField;

    private string timeZoneField;

    private bool ssoLoginOnlyField;

    private Geo[] geosField;

    private DateTime tsField;

    private StandardOpenHours[] standardOpenHoursField;

    private DeviatingOpenHours[] deviatingOpenHoursField;

    private string[] validationErrorsField;

    public int id
    {
        get { return idField; }
        set { idField = value; }
    }

    public string extUnitId
    {
        get { return extUnitIdField; }
        set { extUnitIdField = value; }
    }

    public int groupId
    {
        get { return groupIdField; }
        set { groupIdField = value; }
    }

    [SoapIgnore]
    public bool groupIdSpecified
    {
        get { return groupIdFieldSpecified; }
        set { groupIdFieldSpecified = value; }
    }

    public string extGroupId
    {
        get { return extGroupIdField; }
        set { extGroupIdField = value; }
    }

    public string name
    {
        get { return nameField; }
        set { nameField = value; }
    }

    public string extApplicationId
    {
        get { return extApplicationIdField; }
        set { extApplicationIdField = value; }
    }

    public int managerId
    {
        get { return managerIdField; }
        set { managerIdField = value; }
    }

    public string managerBadgeNo
    {
        get { return managerBadgeNoField; }
        set { managerBadgeNoField = value; }
    }

    public int managerGroupId
    {
        get { return managerGroupIdField; }
        set { managerGroupIdField = value; }
    }

    public decimal maxHourDay
    {
        get { return maxHourDayField; }
        set { maxHourDayField = value; }
    }

    public decimal maxHourWeek
    {
        get { return maxHourWeekField; }
        set { maxHourWeekField = value; }
    }

    public int minShift
    {
        get { return minShiftField; }
        set { minShiftField = value; }
    }

    public int minRest
    {
        get { return minRestField; }
        set { minRestField = value; }
    }

    [SoapElement(DataType = "date")]
    public DateTime publishedTo
    {
        get { return publishedToField; }
        set { publishedToField = value; }
    }

    public string currency
    {
        get { return currencyField; }
        set { currencyField = value; }
    }

    public int noBreaks
    {
        get { return noBreaksField; }
        set { noBreaksField = value; }
    }

    public int premium1
    {
        get { return premium1Field; }
        set { premium1Field = value; }
    }

    public int premium2
    {
        get { return premium2Field; }
        set { premium2Field = value; }
    }

    public int businessBreak
    {
        get { return businessBreakField; }
        set { businessBreakField = value; }
    }

    [SoapIgnore]
    public bool businessBreakSpecified
    {
        get { return businessBreakFieldSpecified; }
        set { businessBreakFieldSpecified = value; }
    }

    public int costCentre
    {
        get { return costCentreField; }
        set { costCentreField = value; }
    }

    public string costCentreExtCode
    {
        get { return costCentreExtCodeField; }
        set { costCentreExtCodeField = value; }
    }

    public int districtId
    {
        get { return districtIdField; }
        set { districtIdField = value; }
    }

    public string country
    {
        get { return countryField; }
        set { countryField = value; }
    }

    public string address
    {
        get { return addressField; }
        set { addressField = value; }
    }

    public string zipCode
    {
        get { return zipCodeField; }
        set { zipCodeField = value; }
    }

    public string city
    {
        get { return cityField; }
        set { cityField = value; }
    }

    public string municipality
    {
        get { return municipalityField; }
        set { municipalityField = value; }
    }

    public int nextBadgeNo
    {
        get { return nextBadgeNoField; }
        set { nextBadgeNoField = value; }
    }

    public string timeZone
    {
        get { return timeZoneField; }
        set { timeZoneField = value; }
    }

    public bool ssoLoginOnly
    {
        get { return ssoLoginOnlyField; }
        set { ssoLoginOnlyField = value; }
    }

    public Geo[] geos
    {
        get { return geosField; }
        set { geosField = value; }
    }

    public DateTime ts
    {
        get { return tsField; }
        set { tsField = value; }
    }

    public StandardOpenHours[] standardOpenHours
    {
        get { return standardOpenHoursField; }
        set { standardOpenHoursField = value; }
    }

    public DeviatingOpenHours[] deviatingOpenHours
    {
        get { return deviatingOpenHoursField; }
        set { deviatingOpenHoursField = value; }
    }

    public string[] validationErrors
    {
        get { return validationErrorsField; }
        set { validationErrorsField = value; }
    }
}
