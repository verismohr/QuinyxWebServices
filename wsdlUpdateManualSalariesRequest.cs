using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(
    WrapperName = "wsdlUpdateManualSalaries",
    WrapperNamespace = "uri:FlexForce",
    IsWrapped = true
)]
public class wsdlUpdateManualSalariesRequest
{
    [MessageBodyMember(Namespace = "", Order = 0)]
    public string apiKey;

    [MessageBodyMember(Namespace = "", Order = 1)]
    public updateManualSalary[] manualSalariesData;

    public wsdlUpdateManualSalariesRequest() { }

    public wsdlUpdateManualSalariesRequest(string apiKey, updateManualSalary[] manualSalariesData)
    {
        this.apiKey = apiKey;
        this.manualSalariesData = manualSalariesData;
    }
}
