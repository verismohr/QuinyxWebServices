using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(
    WrapperName = "wsdlUpdateAbsence",
    WrapperNamespace = "uri:FlexForce",
    IsWrapped = true
)]
public class wsdlUpdateAbsenceRequest
{
    [MessageBodyMember(Namespace = "", Order = 0)]
    public string apiKey;

    [MessageBodyMember(Namespace = "", Order = 1)]
    public AbsenceRecord[] absenceRecords;

    public wsdlUpdateAbsenceRequest() { }

    public wsdlUpdateAbsenceRequest(string apiKey, AbsenceRecord[] absenceRecords)
    {
        this.apiKey = apiKey;
        this.absenceRecords = absenceRecords;
    }
}
