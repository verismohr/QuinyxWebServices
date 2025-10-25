using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(
    WrapperName = "wsdlUpdateEmployeePortraits",
    WrapperNamespace = "uri:FlexForce",
    IsWrapped = true
)]
public class wsdlUpdateEmployeePortraitsRequest
{
    [MessageBodyMember(Namespace = "", Order = 0)]
    public string apiKey;

    [MessageBodyMember(Namespace = "", Order = 1)]
    public UpdateEmployeePortrait[] employeePortraits;

    public wsdlUpdateEmployeePortraitsRequest() { }

    public wsdlUpdateEmployeePortraitsRequest(
        string apiKey,
        UpdateEmployeePortrait[] employeePortraits
    )
    {
        this.apiKey = apiKey;
        this.employeePortraits = employeePortraits;
    }
}
