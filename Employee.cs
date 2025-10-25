using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class Employee
{
    private int idField;

    private string badgeNoField;

    private string givenNameField;

    private string familyNameField;

    private string address1Field;

    private string address2Field;

    private string zipField;

    private string cityField;

    private string cellPhoneField;

    private string phoneNoField;

    private string emailField;

    private int activeField;

    private DateTime leaveDateField;

    private DateTime lastDayOfEmploymentField;

    private bool lastDayOfEmploymentFieldSpecified;

    private string socsecNoField;

    private string countryField;

    private int restIdField;

    private int staffCatField;

    private string extStaffCategoryField;

    private string staffCatNameField;

    private int sectionField;

    private string sectionNameField;

    private int passiveField;

    private int lockStatusField;

    private bool lockStatusFieldSpecified;

    private string isLockedMsgField;

    private string infoField;

    private DateTime dateOfBirthField;

    private DateTime employedDateField;

    private DateTime industryDateField;

    private bool industryDateFieldSpecified;

    private string cardNoField;

    private string passwordTandAField;

    private string nextOfKindField;

    private string nextPhoneField;

    private int roleField;

    private int rankField;

    private bool rankFieldSpecified;

    private int autoManField;

    private int costCentreField;

    private string costCentreExtCodeField;

    private int punchTypeField;

    private int sexField;

    private int myDistrictField;

    private string reportingToField;

    private int hasBankIdField;

    private bool hasBankIdFieldSpecified;

    private string legalGuardianNameField;

    private string legalGuardianEmailField;

    private AdditionalFieldData[] additionalFieldsField;

    private GroupsRoles[] groupRolesField;

    private DateTime tsField;

    public int id
    {
        get { return idField; }
        set { idField = value; }
    }

    public string badgeNo
    {
        get { return badgeNoField; }
        set { badgeNoField = value; }
    }

    public string givenName
    {
        get { return givenNameField; }
        set { givenNameField = value; }
    }

    public string familyName
    {
        get { return familyNameField; }
        set { familyNameField = value; }
    }

    public string address1
    {
        get { return address1Field; }
        set { address1Field = value; }
    }

    public string address2
    {
        get { return address2Field; }
        set { address2Field = value; }
    }

    public string zip
    {
        get { return zipField; }
        set { zipField = value; }
    }

    public string city
    {
        get { return cityField; }
        set { cityField = value; }
    }

    public string cellPhone
    {
        get { return cellPhoneField; }
        set { cellPhoneField = value; }
    }

    public string phoneNo
    {
        get { return phoneNoField; }
        set { phoneNoField = value; }
    }

    public string email
    {
        get { return emailField; }
        set { emailField = value; }
    }

    public int active
    {
        get { return activeField; }
        set { activeField = value; }
    }

    [SoapElement(DataType = "date")]
    public DateTime leaveDate
    {
        get { return leaveDateField; }
        set { leaveDateField = value; }
    }

    [SoapElement(DataType = "date")]
    public DateTime lastDayOfEmployment
    {
        get { return lastDayOfEmploymentField; }
        set { lastDayOfEmploymentField = value; }
    }

    [SoapIgnore]
    public bool lastDayOfEmploymentSpecified
    {
        get { return lastDayOfEmploymentFieldSpecified; }
        set { lastDayOfEmploymentFieldSpecified = value; }
    }

    public string socsecNo
    {
        get { return socsecNoField; }
        set { socsecNoField = value; }
    }

    public string country
    {
        get { return countryField; }
        set { countryField = value; }
    }

    public int restId
    {
        get { return restIdField; }
        set { restIdField = value; }
    }

    public int staffCat
    {
        get { return staffCatField; }
        set { staffCatField = value; }
    }

    public string extStaffCategory
    {
        get { return extStaffCategoryField; }
        set { extStaffCategoryField = value; }
    }

    public string staffCatName
    {
        get { return staffCatNameField; }
        set { staffCatNameField = value; }
    }

    public int section
    {
        get { return sectionField; }
        set { sectionField = value; }
    }

    public string sectionName
    {
        get { return sectionNameField; }
        set { sectionNameField = value; }
    }

    public int passive
    {
        get { return passiveField; }
        set { passiveField = value; }
    }

    public int lockStatus
    {
        get { return lockStatusField; }
        set { lockStatusField = value; }
    }

    [SoapIgnore]
    public bool lockStatusSpecified
    {
        get { return lockStatusFieldSpecified; }
        set { lockStatusFieldSpecified = value; }
    }

    public string isLockedMsg
    {
        get { return isLockedMsgField; }
        set { isLockedMsgField = value; }
    }

    public string info
    {
        get { return infoField; }
        set { infoField = value; }
    }

    [SoapElement(DataType = "date")]
    public DateTime dateOfBirth
    {
        get { return dateOfBirthField; }
        set { dateOfBirthField = value; }
    }

    [SoapElement(DataType = "date")]
    public DateTime employedDate
    {
        get { return employedDateField; }
        set { employedDateField = value; }
    }

    [SoapElement(DataType = "date")]
    public DateTime industryDate
    {
        get { return industryDateField; }
        set { industryDateField = value; }
    }

    [SoapIgnore]
    public bool industryDateSpecified
    {
        get { return industryDateFieldSpecified; }
        set { industryDateFieldSpecified = value; }
    }

    public string cardNo
    {
        get { return cardNoField; }
        set { cardNoField = value; }
    }

    public string passwordTandA
    {
        get { return passwordTandAField; }
        set { passwordTandAField = value; }
    }

    public string nextOfKind
    {
        get { return nextOfKindField; }
        set { nextOfKindField = value; }
    }

    public string nextPhone
    {
        get { return nextPhoneField; }
        set { nextPhoneField = value; }
    }

    public int role
    {
        get { return roleField; }
        set { roleField = value; }
    }

    public int rank
    {
        get { return rankField; }
        set { rankField = value; }
    }

    [SoapIgnore]
    public bool rankSpecified
    {
        get { return rankFieldSpecified; }
        set { rankFieldSpecified = value; }
    }

    public int autoMan
    {
        get { return autoManField; }
        set { autoManField = value; }
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

    public int punchType
    {
        get { return punchTypeField; }
        set { punchTypeField = value; }
    }

    public int sex
    {
        get { return sexField; }
        set { sexField = value; }
    }

    public int myDistrict
    {
        get { return myDistrictField; }
        set { myDistrictField = value; }
    }

    public string reportingTo
    {
        get { return reportingToField; }
        set { reportingToField = value; }
    }

    public int hasBankId
    {
        get { return hasBankIdField; }
        set { hasBankIdField = value; }
    }

    [SoapIgnore]
    public bool hasBankIdSpecified
    {
        get { return hasBankIdFieldSpecified; }
        set { hasBankIdFieldSpecified = value; }
    }

    public string legalGuardianName
    {
        get { return legalGuardianNameField; }
        set { legalGuardianNameField = value; }
    }

    public string legalGuardianEmail
    {
        get { return legalGuardianEmailField; }
        set { legalGuardianEmailField = value; }
    }

    public AdditionalFieldData[] additionalFields
    {
        get { return additionalFieldsField; }
        set { additionalFieldsField = value; }
    }

    public GroupsRoles[] groupRoles
    {
        get { return groupRolesField; }
        set { groupRolesField = value; }
    }

    public DateTime ts
    {
        get { return tsField; }
        set { tsField = value; }
    }
}
