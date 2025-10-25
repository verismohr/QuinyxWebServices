using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(
    WrapperName = "wsdlCreateUnit",
    WrapperNamespace = "uri:FlexForce",
    IsWrapped = true
)]
public class wsdlCreateUnitRequest
{
    [MessageBodyMember(Namespace = "", Order = 0)]
    public string apiKey;

    [MessageBodyMember(Namespace = "", Order = 1)]
    public unitInfo unitInfo;

    public wsdlCreateUnitRequest() { }

    public wsdlCreateUnitRequest(string apiKey, unitInfo unitInfo)
    {
        this.apiKey = apiKey;
        this.unitInfo = unitInfo;
    }
}
