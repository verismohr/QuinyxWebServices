using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(
    WrapperName = "wsdlgetStandardBankHolidays",
    WrapperNamespace = "uri:FlexForce",
    IsWrapped = true
)]
public class wsdlgetStandardBankHolidaysRequest
{
    [MessageBodyMember(Namespace = "", Order = 0)]
    public string apiKey;

    [MessageBodyMember(Namespace = "", Order = 1)]
    public string fromDate;

    [MessageBodyMember(Namespace = "", Order = 2)]
    public string toDate;

    public wsdlgetStandardBankHolidaysRequest() { }

    public wsdlgetStandardBankHolidaysRequest(string apiKey, string fromDate, string toDate)
    {
        this.apiKey = apiKey;
        this.fromDate = fromDate;
        this.toDate = toDate;
    }
}
