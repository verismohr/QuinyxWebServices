using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class UpdateEmployee
{
	private string badgeNoField;

	private string loginIdField;

	private string givenNameField;

	private string familyNameField;

	private int restIdField;

	private bool restIdFieldSpecified;

	private string emailField;

	private int emailFixConflictField;

	private bool emailFixConflictFieldSpecified;

	private string phoneNoField;

	private string cellPhoneField;

	private DateTime dateOfBirthField;

	private bool dateOfBirthFieldSpecified;

	private DateTime employedDateField;

	private bool employedDateFieldSpecified;

	private DateTime industryDateField;

	private bool industryDateFieldSpecified;

	private DateTime earlyAccessDateField;

	private bool earlyAccessDateFieldSpecified;

	private string address1Field;

	private string address2Field;

	private string zipField;

	private string cityField;

	private string cardNoField;

	private int staffCatField;

	private bool staffCatFieldSpecified;

	private string extStaffCategoryField;

	private int punchTypeField;

	private bool punchTypeFieldSpecified;

	private string passwordField;

	private string passwordTandAField;

	private int activeField;

	private bool activeFieldSpecified;

	private int passiveField;

	private bool passiveFieldSpecified;

	private int lockStatusField;

	private bool lockStatusFieldSpecified;

	private string isLockedMsgField;

	private DateTime leaveDateField;

	private bool leaveDateFieldSpecified;

	private string socsecNoField;

	private string countryField;

	private int costCentreField;

	private bool costCentreFieldSpecified;

	private int roleField;

	private bool roleFieldSpecified;

	private int rankField;

	private bool rankFieldSpecified;

	private int sexField;

	private bool sexFieldSpecified;

	private string nextOfKindField;

	private string nextPhoneField;

	private string infoField;

	private int copyToMailField;

	private bool copyToMailFieldSpecified;

	private int useSMSField;

	private bool useSMSFieldSpecified;

	private int useMailField;

	private bool useMailFieldSpecified;

	private int useQmailField;

	private bool useQmailFieldSpecified;

	private string reportingToField;

	private int resetPasswordField;

	private bool resetPasswordFieldSpecified;

	private string extCostCentreField;

	private string extSectionIdField;

	private string newBadgeNoField;

	private bool deleteFutureUnattestedPunchesField;

	private bool deleteFutureUnattestedPunchesFieldSpecified;

	private int shareAbleField;

	private bool shareAbleFieldSpecified;

	private WorkInUnit[] workInUnitsField;

	private int workInUnitsUpdateOptionField;

	private bool workInUnitsUpdateOptionFieldSpecified;

	private int sharedSchedulingField;

	private bool sharedSchedulingFieldSpecified;

	private int allowAttestOfOwnPunchesField;

	private bool allowAttestOfOwnPunchesFieldSpecified;

	private int hasBankIdField;

	private bool hasBankIdFieldSpecified;

	private string legalGuardianNameField;

	private string legalGuardianEmailField;

	private bool keepShiftsOnMoveField;

	private bool keepShiftsOnMoveFieldSpecified;

	private int myDistrictField;

	private bool myDistrictFieldSpecified;

	private AdditionalFieldData[] additionalFieldsField;

	private bool throwExceptionOnHomeUnitEndDateField;

	private bool throwExceptionOnHomeUnitEndDateFieldSpecified;

	private bool replaceNeoGroupField;

	private bool replaceNeoGroupFieldSpecified;

	private bool updateNeoGroupField;

	private bool updateNeoGroupFieldSpecified;

	private bool generateNextBadgeNoField;

	private bool generateNextBadgeNoFieldSpecified;

	private GroupsRoles[] groupRolesField;

	private string[] validationErrorsField;

	public string badgeNo
	{
		get
		{
			return badgeNoField;
		}
		set
		{
			badgeNoField = value;
		}
	}

	public string loginId
	{
		get
		{
			return loginIdField;
		}
		set
		{
			loginIdField = value;
		}
	}

	public string givenName
	{
		get
		{
			return givenNameField;
		}
		set
		{
			givenNameField = value;
		}
	}

	public string familyName
	{
		get
		{
			return familyNameField;
		}
		set
		{
			familyNameField = value;
		}
	}

	public int restId
	{
		get
		{
			return restIdField;
		}
		set
		{
			restIdField = value;
		}
	}

	[SoapIgnore]
	public bool restIdSpecified
	{
		get
		{
			return restIdFieldSpecified;
		}
		set
		{
			restIdFieldSpecified = value;
		}
	}

	public string email
	{
		get
		{
			return emailField;
		}
		set
		{
			emailField = value;
		}
	}

	public int emailFixConflict
	{
		get
		{
			return emailFixConflictField;
		}
		set
		{
			emailFixConflictField = value;
		}
	}

	[SoapIgnore]
	public bool emailFixConflictSpecified
	{
		get
		{
			return emailFixConflictFieldSpecified;
		}
		set
		{
			emailFixConflictFieldSpecified = value;
		}
	}

	public string phoneNo
	{
		get
		{
			return phoneNoField;
		}
		set
		{
			phoneNoField = value;
		}
	}

	public string cellPhone
	{
		get
		{
			return cellPhoneField;
		}
		set
		{
			cellPhoneField = value;
		}
	}

	[SoapElement(DataType = "date")]
	public DateTime dateOfBirth
	{
		get
		{
			return dateOfBirthField;
		}
		set
		{
			dateOfBirthField = value;
		}
	}

	[SoapIgnore]
	public bool dateOfBirthSpecified
	{
		get
		{
			return dateOfBirthFieldSpecified;
		}
		set
		{
			dateOfBirthFieldSpecified = value;
		}
	}

	[SoapElement(DataType = "date")]
	public DateTime employedDate
	{
		get
		{
			return employedDateField;
		}
		set
		{
			employedDateField = value;
		}
	}

	[SoapIgnore]
	public bool employedDateSpecified
	{
		get
		{
			return employedDateFieldSpecified;
		}
		set
		{
			employedDateFieldSpecified = value;
		}
	}

	[SoapElement(DataType = "date")]
	public DateTime industryDate
	{
		get
		{
			return industryDateField;
		}
		set
		{
			industryDateField = value;
		}
	}

	[SoapIgnore]
	public bool industryDateSpecified
	{
		get
		{
			return industryDateFieldSpecified;
		}
		set
		{
			industryDateFieldSpecified = value;
		}
	}

	[SoapElement(DataType = "date")]
	public DateTime earlyAccessDate
	{
		get
		{
			return earlyAccessDateField;
		}
		set
		{
			earlyAccessDateField = value;
		}
	}

	[SoapIgnore]
	public bool earlyAccessDateSpecified
	{
		get
		{
			return earlyAccessDateFieldSpecified;
		}
		set
		{
			earlyAccessDateFieldSpecified = value;
		}
	}

	public string address1
	{
		get
		{
			return address1Field;
		}
		set
		{
			address1Field = value;
		}
	}

	public string address2
	{
		get
		{
			return address2Field;
		}
		set
		{
			address2Field = value;
		}
	}

	public string zip
	{
		get
		{
			return zipField;
		}
		set
		{
			zipField = value;
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

	public string cardNo
	{
		get
		{
			return cardNoField;
		}
		set
		{
			cardNoField = value;
		}
	}

	public int staffCat
	{
		get
		{
			return staffCatField;
		}
		set
		{
			staffCatField = value;
		}
	}

	[SoapIgnore]
	public bool staffCatSpecified
	{
		get
		{
			return staffCatFieldSpecified;
		}
		set
		{
			staffCatFieldSpecified = value;
		}
	}

	public string extStaffCategory
	{
		get
		{
			return extStaffCategoryField;
		}
		set
		{
			extStaffCategoryField = value;
		}
	}

	public int punchType
	{
		get
		{
			return punchTypeField;
		}
		set
		{
			punchTypeField = value;
		}
	}

	[SoapIgnore]
	public bool punchTypeSpecified
	{
		get
		{
			return punchTypeFieldSpecified;
		}
		set
		{
			punchTypeFieldSpecified = value;
		}
	}

	public string password
	{
		get
		{
			return passwordField;
		}
		set
		{
			passwordField = value;
		}
	}

	public string passwordTandA
	{
		get
		{
			return passwordTandAField;
		}
		set
		{
			passwordTandAField = value;
		}
	}

	public int active
	{
		get
		{
			return activeField;
		}
		set
		{
			activeField = value;
		}
	}

	[SoapIgnore]
	public bool activeSpecified
	{
		get
		{
			return activeFieldSpecified;
		}
		set
		{
			activeFieldSpecified = value;
		}
	}

	public int passive
	{
		get
		{
			return passiveField;
		}
		set
		{
			passiveField = value;
		}
	}

	[SoapIgnore]
	public bool passiveSpecified
	{
		get
		{
			return passiveFieldSpecified;
		}
		set
		{
			passiveFieldSpecified = value;
		}
	}

	public int lockStatus
	{
		get
		{
			return lockStatusField;
		}
		set
		{
			lockStatusField = value;
		}
	}

	[SoapIgnore]
	public bool lockStatusSpecified
	{
		get
		{
			return lockStatusFieldSpecified;
		}
		set
		{
			lockStatusFieldSpecified = value;
		}
	}

	public string isLockedMsg
	{
		get
		{
			return isLockedMsgField;
		}
		set
		{
			isLockedMsgField = value;
		}
	}

	[SoapElement(DataType = "date")]
	public DateTime leaveDate
	{
		get
		{
			return leaveDateField;
		}
		set
		{
			leaveDateField = value;
		}
	}

	[SoapIgnore]
	public bool leaveDateSpecified
	{
		get
		{
			return leaveDateFieldSpecified;
		}
		set
		{
			leaveDateFieldSpecified = value;
		}
	}

	public string socsecNo
	{
		get
		{
			return socsecNoField;
		}
		set
		{
			socsecNoField = value;
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

	public int role
	{
		get
		{
			return roleField;
		}
		set
		{
			roleField = value;
		}
	}

	[SoapIgnore]
	public bool roleSpecified
	{
		get
		{
			return roleFieldSpecified;
		}
		set
		{
			roleFieldSpecified = value;
		}
	}

	public int rank
	{
		get
		{
			return rankField;
		}
		set
		{
			rankField = value;
		}
	}

	[SoapIgnore]
	public bool rankSpecified
	{
		get
		{
			return rankFieldSpecified;
		}
		set
		{
			rankFieldSpecified = value;
		}
	}

	public int sex
	{
		get
		{
			return sexField;
		}
		set
		{
			sexField = value;
		}
	}

	[SoapIgnore]
	public bool sexSpecified
	{
		get
		{
			return sexFieldSpecified;
		}
		set
		{
			sexFieldSpecified = value;
		}
	}

	public string nextOfKind
	{
		get
		{
			return nextOfKindField;
		}
		set
		{
			nextOfKindField = value;
		}
	}

	public string nextPhone
	{
		get
		{
			return nextPhoneField;
		}
		set
		{
			nextPhoneField = value;
		}
	}

	public string info
	{
		get
		{
			return infoField;
		}
		set
		{
			infoField = value;
		}
	}

	public int copyToMail
	{
		get
		{
			return copyToMailField;
		}
		set
		{
			copyToMailField = value;
		}
	}

	[SoapIgnore]
	public bool copyToMailSpecified
	{
		get
		{
			return copyToMailFieldSpecified;
		}
		set
		{
			copyToMailFieldSpecified = value;
		}
	}

	public int useSMS
	{
		get
		{
			return useSMSField;
		}
		set
		{
			useSMSField = value;
		}
	}

	[SoapIgnore]
	public bool useSMSSpecified
	{
		get
		{
			return useSMSFieldSpecified;
		}
		set
		{
			useSMSFieldSpecified = value;
		}
	}

	public int useMail
	{
		get
		{
			return useMailField;
		}
		set
		{
			useMailField = value;
		}
	}

	[SoapIgnore]
	public bool useMailSpecified
	{
		get
		{
			return useMailFieldSpecified;
		}
		set
		{
			useMailFieldSpecified = value;
		}
	}

	public int useQmail
	{
		get
		{
			return useQmailField;
		}
		set
		{
			useQmailField = value;
		}
	}

	[SoapIgnore]
	public bool useQmailSpecified
	{
		get
		{
			return useQmailFieldSpecified;
		}
		set
		{
			useQmailFieldSpecified = value;
		}
	}

	public string reportingTo
	{
		get
		{
			return reportingToField;
		}
		set
		{
			reportingToField = value;
		}
	}

	public int resetPassword
	{
		get
		{
			return resetPasswordField;
		}
		set
		{
			resetPasswordField = value;
		}
	}

	[SoapIgnore]
	public bool resetPasswordSpecified
	{
		get
		{
			return resetPasswordFieldSpecified;
		}
		set
		{
			resetPasswordFieldSpecified = value;
		}
	}

	public string extCostCentre
	{
		get
		{
			return extCostCentreField;
		}
		set
		{
			extCostCentreField = value;
		}
	}

	public string extSectionId
	{
		get
		{
			return extSectionIdField;
		}
		set
		{
			extSectionIdField = value;
		}
	}

	public string newBadgeNo
	{
		get
		{
			return newBadgeNoField;
		}
		set
		{
			newBadgeNoField = value;
		}
	}

	public bool DeleteFutureUnattestedPunches
	{
		get
		{
			return deleteFutureUnattestedPunchesField;
		}
		set
		{
			deleteFutureUnattestedPunchesField = value;
		}
	}

	[SoapIgnore]
	public bool DeleteFutureUnattestedPunchesSpecified
	{
		get
		{
			return deleteFutureUnattestedPunchesFieldSpecified;
		}
		set
		{
			deleteFutureUnattestedPunchesFieldSpecified = value;
		}
	}

	public int shareAble
	{
		get
		{
			return shareAbleField;
		}
		set
		{
			shareAbleField = value;
		}
	}

	[SoapIgnore]
	public bool shareAbleSpecified
	{
		get
		{
			return shareAbleFieldSpecified;
		}
		set
		{
			shareAbleFieldSpecified = value;
		}
	}

	public WorkInUnit[] workInUnits
	{
		get
		{
			return workInUnitsField;
		}
		set
		{
			workInUnitsField = value;
		}
	}

	public int workInUnitsUpdateOption
	{
		get
		{
			return workInUnitsUpdateOptionField;
		}
		set
		{
			workInUnitsUpdateOptionField = value;
		}
	}

	[SoapIgnore]
	public bool workInUnitsUpdateOptionSpecified
	{
		get
		{
			return workInUnitsUpdateOptionFieldSpecified;
		}
		set
		{
			workInUnitsUpdateOptionFieldSpecified = value;
		}
	}

	public int sharedScheduling
	{
		get
		{
			return sharedSchedulingField;
		}
		set
		{
			sharedSchedulingField = value;
		}
	}

	[SoapIgnore]
	public bool sharedSchedulingSpecified
	{
		get
		{
			return sharedSchedulingFieldSpecified;
		}
		set
		{
			sharedSchedulingFieldSpecified = value;
		}
	}

	public int allowAttestOfOwnPunches
	{
		get
		{
			return allowAttestOfOwnPunchesField;
		}
		set
		{
			allowAttestOfOwnPunchesField = value;
		}
	}

	[SoapIgnore]
	public bool allowAttestOfOwnPunchesSpecified
	{
		get
		{
			return allowAttestOfOwnPunchesFieldSpecified;
		}
		set
		{
			allowAttestOfOwnPunchesFieldSpecified = value;
		}
	}

	public int hasBankId
	{
		get
		{
			return hasBankIdField;
		}
		set
		{
			hasBankIdField = value;
		}
	}

	[SoapIgnore]
	public bool hasBankIdSpecified
	{
		get
		{
			return hasBankIdFieldSpecified;
		}
		set
		{
			hasBankIdFieldSpecified = value;
		}
	}

	public string legalGuardianName
	{
		get
		{
			return legalGuardianNameField;
		}
		set
		{
			legalGuardianNameField = value;
		}
	}

	public string legalGuardianEmail
	{
		get
		{
			return legalGuardianEmailField;
		}
		set
		{
			legalGuardianEmailField = value;
		}
	}

	public bool keepShiftsOnMove
	{
		get
		{
			return keepShiftsOnMoveField;
		}
		set
		{
			keepShiftsOnMoveField = value;
		}
	}

	[SoapIgnore]
	public bool keepShiftsOnMoveSpecified
	{
		get
		{
			return keepShiftsOnMoveFieldSpecified;
		}
		set
		{
			keepShiftsOnMoveFieldSpecified = value;
		}
	}

	public int myDistrict
	{
		get
		{
			return myDistrictField;
		}
		set
		{
			myDistrictField = value;
		}
	}

	[SoapIgnore]
	public bool myDistrictSpecified
	{
		get
		{
			return myDistrictFieldSpecified;
		}
		set
		{
			myDistrictFieldSpecified = value;
		}
	}

	public AdditionalFieldData[] additionalFields
	{
		get
		{
			return additionalFieldsField;
		}
		set
		{
			additionalFieldsField = value;
		}
	}

	public bool throwExceptionOnHomeUnitEndDate
	{
		get
		{
			return throwExceptionOnHomeUnitEndDateField;
		}
		set
		{
			throwExceptionOnHomeUnitEndDateField = value;
		}
	}

	[SoapIgnore]
	public bool throwExceptionOnHomeUnitEndDateSpecified
	{
		get
		{
			return throwExceptionOnHomeUnitEndDateFieldSpecified;
		}
		set
		{
			throwExceptionOnHomeUnitEndDateFieldSpecified = value;
		}
	}

	public bool replaceNeoGroup
	{
		get
		{
			return replaceNeoGroupField;
		}
		set
		{
			replaceNeoGroupField = value;
		}
	}

	[SoapIgnore]
	public bool replaceNeoGroupSpecified
	{
		get
		{
			return replaceNeoGroupFieldSpecified;
		}
		set
		{
			replaceNeoGroupFieldSpecified = value;
		}
	}

	public bool updateNeoGroup
	{
		get
		{
			return updateNeoGroupField;
		}
		set
		{
			updateNeoGroupField = value;
		}
	}

	[SoapIgnore]
	public bool updateNeoGroupSpecified
	{
		get
		{
			return updateNeoGroupFieldSpecified;
		}
		set
		{
			updateNeoGroupFieldSpecified = value;
		}
	}

	public bool generateNextBadgeNo
	{
		get
		{
			return generateNextBadgeNoField;
		}
		set
		{
			generateNextBadgeNoField = value;
		}
	}

	[SoapIgnore]
	public bool generateNextBadgeNoSpecified
	{
		get
		{
			return generateNextBadgeNoFieldSpecified;
		}
		set
		{
			generateNextBadgeNoFieldSpecified = value;
		}
	}

	public GroupsRoles[] groupRoles
	{
		get
		{
			return groupRolesField;
		}
		set
		{
			groupRolesField = value;
		}
	}

	public string[] validationErrors
	{
		get
		{
			return validationErrorsField;
		}
		set
		{
			validationErrorsField = value;
		}
	}
}
