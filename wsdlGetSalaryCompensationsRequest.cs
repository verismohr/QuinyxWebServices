using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(
    WrapperName = "wsdlGetSalaryCompensations",
    WrapperNamespace = "uri:FlexForce",
    IsWrapped = true
)]
public class wsdlGetSalaryCompensationsRequest
{
    [MessageBodyMember(Namespace = "", Order = 0)]
    public string apiKey;

    public wsdlGetSalaryCompensationsRequest() { }

    public wsdlGetSalaryCompensationsRequest(string apiKey)
    {
        this.apiKey = apiKey;
    }
}
