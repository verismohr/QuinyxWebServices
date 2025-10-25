using System.ServiceModel;
using System.ServiceModel.Channels;

namespace QuinyxWebServices;

public class FlexForcePortTypeClient : ClientBase<FlexForcePortType>, FlexForcePortType
{
    public FlexForcePortTypeClient(Binding binding, EndpointAddress remoteAddress)
        : base(binding, remoteAddress) { }

    public wsdlGetRestaurantsAPIKeyResponse wsdlGetRestaurantsAPIKey(
        wsdlGetRestaurantsAPIKeyRequest request
    )
    {
        return base.Channel.wsdlGetRestaurantsAPIKey(request);
    }

    public wsdlGetRestaurantsResponse wsdlGetRestaurants(wsdlGetRestaurantsRequest request)
    {
        return base.Channel.wsdlGetRestaurants(request);
    }

    public wsdlGetRestaurantResponse wsdlGetRestaurant(wsdlGetRestaurantRequest request)
    {
        return base.Channel.wsdlGetRestaurant(request);
    }

    public wsdlUpdateUnitResponse wsdlUpdateUnit(wsdlUpdateUnitRequest request)
    {
        return base.Channel.wsdlUpdateUnit(request);
    }

    public wsdlCreateUnitResponse wsdlCreateUnit(wsdlCreateUnitRequest request)
    {
        return base.Channel.wsdlCreateUnit(request);
    }

    public wsdlGetUnitsAPIKeyResponse wsdlGetUnitsAPIKey(wsdlGetUnitsAPIKeyRequest request)
    {
        return base.Channel.wsdlGetUnitsAPIKey(request);
    }

    public wsdlGetUnitsAPIKeyV2Response wsdlGetUnitsAPIKeyV2(wsdlGetUnitsAPIKeyV2Request request)
    {
        return base.Channel.wsdlGetUnitsAPIKeyV2(request);
    }

    public wsdlGetUnitsResponse wsdlGetUnits(wsdlGetUnitsRequest request)
    {
        return base.Channel.wsdlGetUnits(request);
    }

    public wsdlGetUnitResponse wsdlGetUnit(wsdlGetUnitRequest request)
    {
        return base.Channel.wsdlGetUnit(request);
    }

    public wsdlGetCustomersResponse wsdlGetCustomers(wsdlGetCustomersRequest request)
    {
        return base.Channel.wsdlGetCustomers(request);
    }

    public wsdlGetResultTransferToPayrollResponse wsdlGetResultTransferToPayroll(
        wsdlGetResultTransferToPayrollRequest request
    )
    {
        return base.Channel.wsdlGetResultTransferToPayroll(request);
    }

    public wsdlInitiateTransferToPayrollResponse wsdlInitiateTransferToPayroll(
        wsdlInitiateTransferToPayrollRequest request
    )
    {
        return base.Channel.wsdlInitiateTransferToPayroll(request);
    }

    public wsdlGetPayrollResponse wsdlGetPayroll(wsdlGetPayrollRequest request)
    {
        return base.Channel.wsdlGetPayroll(request);
    }

    public wsdlGetSalaryPeriodLockStatusResponse wsdlGetSalaryPeriodLockStatus(
        wsdlGetSalaryPeriodLockStatusRequest request
    )
    {
        return base.Channel.wsdlGetSalaryPeriodLockStatus(request);
    }

    public wsdlGetPayrollV2Response wsdlGetPayrollV2(wsdlGetPayrollV2Request request)
    {
        return base.Channel.wsdlGetPayrollV2(request);
    }

    public wsdlGetPayrollRawResponse wsdlGetPayrollRaw(wsdlGetPayrollRawRequest request)
    {
        return base.Channel.wsdlGetPayrollRaw(request);
    }

    public wsdlUpdateSectionsResponse wsdlUpdateSections(wsdlUpdateSectionsRequest request)
    {
        return base.Channel.wsdlUpdateSections(request);
    }

    public wsdlGetSectionsResponse wsdlGetSections(wsdlGetSectionsRequest request)
    {
        return base.Channel.wsdlGetSections(request);
    }

    public wsdlUpdateDistrictsResponse wsdlUpdateDistricts(wsdlUpdateDistrictsRequest request)
    {
        return base.Channel.wsdlUpdateDistricts(request);
    }

    public wsdlGetCategoriesResponse wsdlGetCategories(wsdlGetCategoriesRequest request)
    {
        return base.Channel.wsdlGetCategories(request);
    }

    public wsdlGetLeaveReasonsResponse wsdlGetLeaveReasons(wsdlGetLeaveReasonsRequest request)
    {
        return base.Channel.wsdlGetLeaveReasons(request);
    }

    public wsdlGetLeaveApplicationsResponse wsdlGetLeaveApplications(
        wsdlGetLeaveApplicationsRequest request
    )
    {
        return base.Channel.wsdlGetLeaveApplications(request);
    }

    public wsdlGetDeletedLeaveApplicationsResponse wsdlGetDeletedLeaveApplications(
        wsdlGetDeletedLeaveApplicationsRequest request
    )
    {
        return base.Channel.wsdlGetDeletedLeaveApplications(request);
    }

    public wsdlGetLeaveApplicationsV2Response wsdlGetLeaveApplicationsV2(
        wsdlGetLeaveApplicationsV2Request request
    )
    {
        return base.Channel.wsdlGetLeaveApplicationsV2(request);
    }

    public wsdlGetSchedulesResponse wsdlGetSchedules(wsdlGetSchedulesRequest request)
    {
        return base.Channel.wsdlGetSchedules(request);
    }

    public wsdlGetSchedulesForAllUnitsResponse wsdlGetSchedulesForAllUnits(
        wsdlGetSchedulesForAllUnitsRequest request
    )
    {
        return base.Channel.wsdlGetSchedulesForAllUnits(request);
    }

    public wsdlGetDeletedSchedulesResponse wsdlGetDeletedSchedules(
        wsdlGetDeletedSchedulesRequest request
    )
    {
        return base.Channel.wsdlGetDeletedSchedules(request);
    }

    public wsdlGetSchedulesV2Response wsdlGetSchedulesV2(wsdlGetSchedulesV2Request request)
    {
        return base.Channel.wsdlGetSchedulesV2(request);
    }

    public wsdlGetSchedulesV3Response wsdlGetSchedulesV3(wsdlGetSchedulesV3Request request)
    {
        return base.Channel.wsdlGetSchedulesV3(request);
    }

    public wsdlGetScheduleTasksResponse wsdlGetScheduleTasks(wsdlGetScheduleTasksRequest request)
    {
        return base.Channel.wsdlGetScheduleTasks(request);
    }

    public wsdlGetShiftCategoriesResponse wsdlGetShiftCategories(
        wsdlGetShiftCategoriesRequest request
    )
    {
        return base.Channel.wsdlGetShiftCategories(request);
    }

    public wsdlGetAgreementsResponse wsdlGetAgreements(wsdlGetAgreementsRequest request)
    {
        return base.Channel.wsdlGetAgreements(request);
    }

    public wsdlGetOvertimeMethodsResponse wsdlGetOvertimeMethods(
        wsdlGetOvertimeMethodsRequest request
    )
    {
        return base.Channel.wsdlGetOvertimeMethods(request);
    }

    public wsdlGetDeletedEmployeesResponse wsdlGetDeletedEmployees(
        wsdlGetDeletedEmployeesRequest request
    )
    {
        return base.Channel.wsdlGetDeletedEmployees(request);
    }

    public wsdlReverseTransactionsResponse wsdlReverseTransactions(
        wsdlReverseTransactionsRequest request
    )
    {
        return base.Channel.wsdlReverseTransactions(request);
    }

    public wsdlGetEmployeesV2Response wsdlGetEmployeesV2(wsdlGetEmployeesV2Request request)
    {
        return base.Channel.wsdlGetEmployeesV2(request);
    }

    public wsdlGetEmployeesResponse wsdlGetEmployees(wsdlGetEmployeesRequest request)
    {
        return base.Channel.wsdlGetEmployees(request);
    }

    public wsdlGetEmployeeSkillsResponse wsdlGetEmployeeSkills(wsdlGetEmployeeSkillsRequest request)
    {
        return base.Channel.wsdlGetEmployeeSkills(request);
    }

    public wsdlGetEmployeeGroupsResponse wsdlGetEmployeeGroups(wsdlGetEmployeeGroupsRequest request)
    {
        return base.Channel.wsdlGetEmployeeGroups(request);
    }

    public wsdlGetDistrictsResponse wsdlGetDistricts(wsdlGetDistrictsRequest request)
    {
        return base.Channel.wsdlGetDistricts(request);
    }

    public wsdlGetRolesResponse wsdlGetRoles(wsdlGetRolesRequest request)
    {
        return base.Channel.wsdlGetRoles(request);
    }

    public wsdlGetAgreementTemplatesResponse wsdlGetAgreementTemplates(
        wsdlGetAgreementTemplatesRequest request
    )
    {
        return base.Channel.wsdlGetAgreementTemplates(request);
    }

    public wsdlGetAgreementsV2Response wsdlGetAgreementsV2(wsdlGetAgreementsV2Request request)
    {
        return base.Channel.wsdlGetAgreementsV2(request);
    }

    public wsdlDeleteSalaryCompensationsResponse wsdlDeleteSalaryCompensations(
        wsdlDeleteSalaryCompensationsRequest request
    )
    {
        return base.Channel.wsdlDeleteSalaryCompensations(request);
    }

    public wsdlUpdateSalaryCompensationsResponse wsdlUpdateSalaryCompensations(
        wsdlUpdateSalaryCompensationsRequest request
    )
    {
        return base.Channel.wsdlUpdateSalaryCompensations(request);
    }

    public wsdlGetSalaryCompensationsResponse wsdlGetSalaryCompensations(
        wsdlGetSalaryCompensationsRequest request
    )
    {
        return base.Channel.wsdlGetSalaryCompensations(request);
    }

    public wsdlGetEligibilityRulesResponse wsdlGetEligibilityRules(
        wsdlGetEligibilityRulesRequest request
    )
    {
        return base.Channel.wsdlGetEligibilityRules(request);
    }

    public wsdlUpdateEligibilityRulesResponse wsdlUpdateEligibilityRules(
        wsdlUpdateEligibilityRulesRequest request
    )
    {
        return base.Channel.wsdlUpdateEligibilityRules(request);
    }

    public wsdlDeleteEligibilityRulesResponse wsdlDeleteEligibilityRules(
        wsdlDeleteEligibilityRulesRequest request
    )
    {
        return base.Channel.wsdlDeleteEligibilityRules(request);
    }

    public wsdlUpdateStandardBankHolidaysResponse wsdlUpdateStandardBankHolidays(
        wsdlUpdateStandardBankHolidaysRequest request
    )
    {
        return base.Channel.wsdlUpdateStandardBankHolidays(request);
    }

    public wsdlgetStandardBankHolidaysResponse wsdlgetStandardBankHolidays(
        wsdlgetStandardBankHolidaysRequest request
    )
    {
        return base.Channel.wsdlgetStandardBankHolidays(request);
    }

    public wsdlGetAgreementTemplatesV2Response wsdlGetAgreementTemplatesV2(
        wsdlGetAgreementTemplatesV2Request request
    )
    {
        return base.Channel.wsdlGetAgreementTemplatesV2(request);
    }

    public wsdlGetAgreementTemplatesSalaryTypesResponse wsdlGetAgreementTemplatesSalaryTypes(
        wsdlGetAgreementTemplatesSalaryTypesRequest request
    )
    {
        return base.Channel.wsdlGetAgreementTemplatesSalaryTypes(request);
    }

    public wsdlProcessLeavesResponse wsdlProcessLeaves(wsdlProcessLeavesRequest request)
    {
        return base.Channel.wsdlProcessLeaves(request);
    }

    public wsdlUpdateAbsenceResponse wsdlUpdateAbsence(wsdlUpdateAbsenceRequest request)
    {
        return base.Channel.wsdlUpdateAbsence(request);
    }

    public wsdlGetEmployeePortraitResponse wsdlGetEmployeePortrait(
        wsdlGetEmployeePortraitRequest request
    )
    {
        return base.Channel.wsdlGetEmployeePortrait(request);
    }

    public wsdlGetAgreementInfoByDateResponse wsdlGetAgreementInfoByDate(
        wsdlGetAgreementInfoByDateRequest request
    )
    {
        return base.Channel.wsdlGetAgreementInfoByDate(request);
    }

    public wsdlUpdateEmployeesResponse wsdlUpdateEmployees(wsdlUpdateEmployeesRequest request)
    {
        return base.Channel.wsdlUpdateEmployees(request);
    }

    public wsdlUpdateEmployeePortraitsResponse wsdlUpdateEmployeePortraits(
        wsdlUpdateEmployeePortraitsRequest request
    )
    {
        return base.Channel.wsdlUpdateEmployeePortraits(request);
    }

    public wsdlGetBaseScheduleRolledoutHoursResponse wsdlGetBaseScheduleRolledoutHours(
        wsdlGetBaseScheduleRolledoutHoursRequest request
    )
    {
        return base.Channel.wsdlGetBaseScheduleRolledoutHours(request);
    }

    public wsdlUpdateShiftTypesResponse wsdlUpdateShiftTypes(wsdlUpdateShiftTypesRequest request)
    {
        return base.Channel.wsdlUpdateShiftTypes(request);
    }

    public wsdlUpdateManualSalariesResponse wsdlUpdateManualSalaries(
        wsdlUpdateManualSalariesRequest request
    )
    {
        return base.Channel.wsdlUpdateManualSalaries(request);
    }

    public wsdlGetTimePunchesResponse wsdlGetTimePunches(wsdlGetTimePunchesRequest request)
    {
        return base.Channel.wsdlGetTimePunches(request);
    }

    public wsdlUpdateTimePunchesResponse wsdlUpdateTimePunches(wsdlUpdateTimePunchesRequest request)
    {
        return base.Channel.wsdlUpdateTimePunches(request);
    }

    public wsdlPunchResponse wsdlPunch(wsdlPunchRequest request)
    {
        return base.Channel.wsdlPunch(request);
    }

    public wsdlGetActiveAndAbsenceHoursResponse wsdlGetActiveAndAbsenceHours(
        wsdlGetActiveAndAbsenceHoursRequest request
    )
    {
        return base.Channel.wsdlGetActiveAndAbsenceHours(request);
    }

    public wsdlUpdateAgreementsV2Response wsdlUpdateAgreementsV2(
        wsdlUpdateAgreementsV2Request request
    )
    {
        return base.Channel.wsdlUpdateAgreementsV2(request);
    }

    public wsdlUpdateAgreementsResponse wsdlUpdateAgreements(wsdlUpdateAgreementsRequest request)
    {
        return base.Channel.wsdlUpdateAgreements(request);
    }

    public wsdlUpdateTextItemsResponse wsdlUpdateTextItems(wsdlUpdateTextItemsRequest request)
    {
        return base.Channel.wsdlUpdateTextItems(request);
    }

    public wsdlGetTextItemsResponse wsdlGetTextItems(wsdlGetTextItemsRequest request)
    {
        return base.Channel.wsdlGetTextItems(request);
    }

    public wsdlGetNeoRolesResponse wsdlGetNeoRoles(wsdlGetNeoRolesRequest request)
    {
        return base.Channel.wsdlGetNeoRoles(request);
    }

    public wsdlGetNeoGroupsResponse wsdlGetNeoGroups(wsdlGetNeoGroupsRequest request)
    {
        return base.Channel.wsdlGetNeoGroups(request);
    }

    public wsdlUpdateShiftsResponse wsdlUpdateShifts(wsdlUpdateShiftsRequest request)
    {
        return base.Channel.wsdlUpdateShifts(request);
    }

    public wsdlSendQmailResponse wsdlSendQmail(wsdlSendQmailRequest request)
    {
        return base.Channel.wsdlSendQmail(request);
    }

    public wsdlUpdateEmployeeAttachmentsResponse wsdlUpdateEmployeeAttachments(
        wsdlUpdateEmployeeAttachmentsRequest request
    )
    {
        return base.Channel.wsdlUpdateEmployeeAttachments(request);
    }

    public wsdlGetErrorMessagesResponse wsdlGetErrorMessages(wsdlGetErrorMessagesRequest request)
    {
        return base.Channel.wsdlGetErrorMessages(request);
    }

    public wsdlGetSkillCategoriesResponse wsdlGetSkillCategories(
        wsdlGetSkillCategoriesRequest request
    )
    {
        return base.Channel.wsdlGetSkillCategories(request);
    }

    public wsdlUpdateSkillsResponse wsdlUpdateSkills(wsdlUpdateSkillsRequest request)
    {
        return base.Channel.wsdlUpdateSkills(request);
    }

    public wsdlUpdateEmployeeSkillsResponse wsdlUpdateEmployeeSkills(
        wsdlUpdateEmployeeSkillsRequest request
    )
    {
        return base.Channel.wsdlUpdateEmployeeSkills(request);
    }

    public wsdlMoveEmployeesResponse wsdlMoveEmployees(wsdlMoveEmployeesRequest request)
    {
        return base.Channel.wsdlMoveEmployees(request);
    }

    public wsdlScheduleRequestDenyResponse wsdlScheduleRequestDeny(
        wsdlScheduleRequestDenyRequest request
    )
    {
        return base.Channel.wsdlScheduleRequestDeny(request);
    }

    public wsdlScheduleRequestApproveResponse wsdlScheduleRequestApprove(
        wsdlScheduleRequestApproveRequest request
    )
    {
        return base.Channel.wsdlScheduleRequestApprove(request);
    }

    public wsdlUpdateTimeTrackersResponse wsdlUpdateTimeTrackers(
        wsdlUpdateTimeTrackersRequest request
    )
    {
        return base.Channel.wsdlUpdateTimeTrackers(request);
    }

    public wsdlGetTimeTrackerListResponse wsdlGetTimeTrackerList(
        wsdlGetTimeTrackerListRequest request
    )
    {
        return base.Channel.wsdlGetTimeTrackerList(request);
    }

    public wsdlGetTimeTrackersBalanceResponse wsdlGetTimeTrackersBalance(
        wsdlGetTimeTrackersBalanceRequest request
    )
    {
        return base.Channel.wsdlGetTimeTrackersBalance(request);
    }

    public wsdlGetFirstToExpireTimeTrackersBalanceResponse wsdlGetFirstToExpireTimeTrackersBalance(
        wsdlGetFirstToExpireTimeTrackersBalanceRequest request
    )
    {
        return base.Channel.wsdlGetFirstToExpireTimeTrackersBalance(request);
    }

    public wsdlFindEmployeesResponse wsdlFindEmployees(wsdlFindEmployeesRequest request)
    {
        return base.Channel.wsdlFindEmployees(request);
    }
}
