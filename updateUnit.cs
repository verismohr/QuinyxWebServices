using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class updateUnit
{
	private string extUnitIdField;

	private string nameField;

	private string extApplicationIdField;

	private int managerIdField;

	private bool managerIdFieldSpecified;

	private string managerBadgeNoField;

	private int managerGroupIdField;

	private bool managerGroupIdFieldSpecified;

	private decimal maxHourDayField;

	private bool maxHourDayFieldSpecified;

	private decimal maxHourWeekField;

	private bool maxHourWeekFieldSpecified;

	private int minShiftField;

	private bool minShiftFieldSpecified;

	private int minRestField;

	private bool minRestFieldSpecified;

	private DateTime publishedToField;

	private bool publishedToFieldSpecified;

	private string currencyField;

	private int noBreaksField;

	private bool noBreaksFieldSpecified;

	private int premium1Field;

	private bool premium1FieldSpecified;

	private int premium2Field;

	private bool premium2FieldSpecified;

	private int costCentreField;

	private bool costCentreFieldSpecified;

	private string costCentreExtCodeField;

	private int districtIdField;

	private bool districtIdFieldSpecified;

	private string countryField;

	private string addressField;

	private string zipCodeField;

	private string cityField;

	private string municipalityField;

	private int nextBadgeNoField;

	private bool nextBadgeNoFieldSpecified;

	private string timeZoneField;

	private bool ssoLoginOnlyField;

	private bool ssoLoginOnlyFieldSpecified;

	private Geo[] geosField;

	private int geosOptionField;

	private bool geosOptionFieldSpecified;

	private string extGroupIdField;

	private StandardOpenHours[] standardOpenHoursField;

	private DeviatingOpenHours[] deviatingOpenHoursField;

	public string extUnitId
	{
		get
		{
			return extUnitIdField;
		}
		set
		{
			extUnitIdField = value;
		}
	}

	public string name
	{
		get
		{
			return nameField;
		}
		set
		{
			nameField = value;
		}
	}

	public string extApplicationId
	{
		get
		{
			return extApplicationIdField;
		}
		set
		{
			extApplicationIdField = value;
		}
	}

	public int managerId
	{
		get
		{
			return managerIdField;
		}
		set
		{
			managerIdField = value;
		}
	}

	[SoapIgnore]
	public bool managerIdSpecified
	{
		get
		{
			return managerIdFieldSpecified;
		}
		set
		{
			managerIdFieldSpecified = value;
		}
	}

	public string managerBadgeNo
	{
		get
		{
			return managerBadgeNoField;
		}
		set
		{
			managerBadgeNoField = value;
		}
	}

	public int managerGroupId
	{
		get
		{
			return managerGroupIdField;
		}
		set
		{
			managerGroupIdField = value;
		}
	}

	[SoapIgnore]
	public bool managerGroupIdSpecified
	{
		get
		{
			return managerGroupIdFieldSpecified;
		}
		set
		{
			managerGroupIdFieldSpecified = value;
		}
	}

	public decimal maxHourDay
	{
		get
		{
			return maxHourDayField;
		}
		set
		{
			maxHourDayField = value;
		}
	}

	[SoapIgnore]
	public bool maxHourDaySpecified
	{
		get
		{
			return maxHourDayFieldSpecified;
		}
		set
		{
			maxHourDayFieldSpecified = value;
		}
	}

	public decimal maxHourWeek
	{
		get
		{
			return maxHourWeekField;
		}
		set
		{
			maxHourWeekField = value;
		}
	}

	[SoapIgnore]
	public bool maxHourWeekSpecified
	{
		get
		{
			return maxHourWeekFieldSpecified;
		}
		set
		{
			maxHourWeekFieldSpecified = value;
		}
	}

	public int minShift
	{
		get
		{
			return minShiftField;
		}
		set
		{
			minShiftField = value;
		}
	}

	[SoapIgnore]
	public bool minShiftSpecified
	{
		get
		{
			return minShiftFieldSpecified;
		}
		set
		{
			minShiftFieldSpecified = value;
		}
	}

	public int minRest
	{
		get
		{
			return minRestField;
		}
		set
		{
			minRestField = value;
		}
	}

	[SoapIgnore]
	public bool minRestSpecified
	{
		get
		{
			return minRestFieldSpecified;
		}
		set
		{
			minRestFieldSpecified = value;
		}
	}

	[SoapElement(DataType = "date")]
	public DateTime publishedTo
	{
		get
		{
			return publishedToField;
		}
		set
		{
			publishedToField = value;
		}
	}

	[SoapIgnore]
	public bool publishedToSpecified
	{
		get
		{
			return publishedToFieldSpecified;
		}
		set
		{
			publishedToFieldSpecified = value;
		}
	}

	public string currency
	{
		get
		{
			return currencyField;
		}
		set
		{
			currencyField = value;
		}
	}

	public int noBreaks
	{
		get
		{
			return noBreaksField;
		}
		set
		{
			noBreaksField = value;
		}
	}

	[SoapIgnore]
	public bool noBreaksSpecified
	{
		get
		{
			return noBreaksFieldSpecified;
		}
		set
		{
			noBreaksFieldSpecified = value;
		}
	}

	public int premium1
	{
		get
		{
			return premium1Field;
		}
		set
		{
			premium1Field = value;
		}
	}

	[SoapIgnore]
	public bool premium1Specified
	{
		get
		{
			return premium1FieldSpecified;
		}
		set
		{
			premium1FieldSpecified = value;
		}
	}

	public int premium2
	{
		get
		{
			return premium2Field;
		}
		set
		{
			premium2Field = value;
		}
	}

	[SoapIgnore]
	public bool premium2Specified
	{
		get
		{
			return premium2FieldSpecified;
		}
		set
		{
			premium2FieldSpecified = value;
		}
	}

	public int costCentre
	{
		get
		{
			return costCentreField;
		}
		set
		{
			costCentreField = value;
		}
	}

	[SoapIgnore]
	public bool costCentreSpecified
	{
		get
		{
			return costCentreFieldSpecified;
		}
		set
		{
			costCentreFieldSpecified = value;
		}
	}

	public string costCentreExtCode
	{
		get
		{
			return costCentreExtCodeField;
		}
		set
		{
			costCentreExtCodeField = value;
		}
	}

	public int districtId
	{
		get
		{
			return districtIdField;
		}
		set
		{
			districtIdField = value;
		}
	}

	[SoapIgnore]
	public bool districtIdSpecified
	{
		get
		{
			return districtIdFieldSpecified;
		}
		set
		{
			districtIdFieldSpecified = value;
		}
	}

	public string country
	{
		get
		{
			return countryField;
		}
		set
		{
			countryField = value;
		}
	}

	public string address
	{
		get
		{
			return addressField;
		}
		set
		{
			addressField = value;
		}
	}

	public string zipCode
	{
		get
		{
			return zipCodeField;
		}
		set
		{
			zipCodeField = value;
		}
	}

	public string city
	{
		get
		{
			return cityField;
		}
		set
		{
			cityField = value;
		}
	}

	public string municipality
	{
		get
		{
			return municipalityField;
		}
		set
		{
			municipalityField = value;
		}
	}

	public int nextBadgeNo
	{
		get
		{
			return nextBadgeNoField;
		}
		set
		{
			nextBadgeNoField = value;
		}
	}

	[SoapIgnore]
	public bool nextBadgeNoSpecified
	{
		get
		{
			return nextBadgeNoFieldSpecified;
		}
		set
		{
			nextBadgeNoFieldSpecified = value;
		}
	}

	public string timeZone
	{
		get
		{
			return timeZoneField;
		}
		set
		{
			timeZoneField = value;
		}
	}

	public bool ssoLoginOnly
	{
		get
		{
			return ssoLoginOnlyField;
		}
		set
		{
			ssoLoginOnlyField = value;
		}
	}

	[SoapIgnore]
	public bool ssoLoginOnlySpecified
	{
		get
		{
			return ssoLoginOnlyFieldSpecified;
		}
		set
		{
			ssoLoginOnlyFieldSpecified = value;
		}
	}

	public Geo[] geos
	{
		get
		{
			return geosField;
		}
		set
		{
			geosField = value;
		}
	}

	public int geosOption
	{
		get
		{
			return geosOptionField;
		}
		set
		{
			geosOptionField = value;
		}
	}

	[SoapIgnore]
	public bool geosOptionSpecified
	{
		get
		{
			return geosOptionFieldSpecified;
		}
		set
		{
			geosOptionFieldSpecified = value;
		}
	}

	public string extGroupId
	{
		get
		{
			return extGroupIdField;
		}
		set
		{
			extGroupIdField = value;
		}
	}

	public StandardOpenHours[] standardOpenHours
	{
		get
		{
			return standardOpenHoursField;
		}
		set
		{
			standardOpenHoursField = value;
		}
	}

	public DeviatingOpenHours[] deviatingOpenHours
	{
		get
		{
			return deviatingOpenHoursField;
		}
		set
		{
			deviatingOpenHoursField = value;
		}
	}
}
