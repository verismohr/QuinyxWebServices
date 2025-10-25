using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(
    WrapperName = "wsdlGetPayroll",
    WrapperNamespace = "uri:FlexForce",
    IsWrapped = true
)]
public class wsdlGetPayrollRequest
{
    [MessageBodyMember(Namespace = "", Order = 0)]
    public string apiKey;

    [MessageBodyMember(Namespace = "", Order = 1)]
    public string fromDate;

    [MessageBodyMember(Namespace = "", Order = 2)]
    public string toDate;

    [MessageBodyMember(Namespace = "", Order = 3)]
    public int attest;

    [MessageBodyMember(Namespace = "", Order = 4)]
    public string pSalType;

    [MessageBodyMember(Namespace = "", Order = 5)]
    public int empInUnitOnly;

    [MessageBodyMember(Namespace = "", Order = 6)]
    public int employeeId;

    [MessageBodyMember(Namespace = "", Order = 7)]
    public string badgeNo;

    [MessageBodyMember(Namespace = "", Order = 8)]
    public int isTransferingToPayroll;

    public wsdlGetPayrollRequest() { }

    public wsdlGetPayrollRequest(
        string apiKey,
        string fromDate,
        string toDate,
        int attest,
        string pSalType,
        int empInUnitOnly,
        int employeeId,
        string badgeNo,
        int isTransferingToPayroll
    )
    {
        this.apiKey = apiKey;
        this.fromDate = fromDate;
        this.toDate = toDate;
        this.attest = attest;
        this.pSalType = pSalType;
        this.empInUnitOnly = empInUnitOnly;
        this.employeeId = employeeId;
        this.badgeNo = badgeNo;
        this.isTransferingToPayroll = isTransferingToPayroll;
    }
}
