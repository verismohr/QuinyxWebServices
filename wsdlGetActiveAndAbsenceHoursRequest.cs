using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(
    WrapperName = "wsdlGetActiveAndAbsenceHours",
    WrapperNamespace = "uri:FlexForce",
    IsWrapped = true
)]
public class wsdlGetActiveAndAbsenceHoursRequest
{
    [MessageBodyMember(Namespace = "", Order = 0)]
    public string apiKey;

    [MessageBodyMember(Namespace = "", Order = 1)]
    public string date;

    [MessageBodyMember(Namespace = "", Order = 2)]
    public string[] agreementsNames;

    public wsdlGetActiveAndAbsenceHoursRequest() { }

    public wsdlGetActiveAndAbsenceHoursRequest(string apiKey, string date, string[] agreementsNames)
    {
        this.apiKey = apiKey;
        this.date = date;
        this.agreementsNames = agreementsNames;
    }
}
