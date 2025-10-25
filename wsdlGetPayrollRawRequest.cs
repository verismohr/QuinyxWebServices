using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(
    WrapperName = "wsdlGetPayrollRaw",
    WrapperNamespace = "uri:FlexForce",
    IsWrapped = true
)]
public class wsdlGetPayrollRawRequest
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

    public wsdlGetPayrollRawRequest() { }

    public wsdlGetPayrollRawRequest(
        string apiKey,
        string fromDate,
        string toDate,
        int attest,
        string pSalType
    )
    {
        this.apiKey = apiKey;
        this.fromDate = fromDate;
        this.toDate = toDate;
        this.attest = attest;
        this.pSalType = pSalType;
    }
}
