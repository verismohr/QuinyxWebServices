using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(
    WrapperName = "wsdlUpdateShiftTypes",
    WrapperNamespace = "uri:FlexForce",
    IsWrapped = true
)]
public class wsdlUpdateShiftTypesRequest
{
    [MessageBodyMember(Namespace = "", Order = 0)]
    public string apiKey;

    [MessageBodyMember(Namespace = "", Order = 1)]
    public UpdateShiftType[] shifType;

    public wsdlUpdateShiftTypesRequest() { }

    public wsdlUpdateShiftTypesRequest(string apiKey, UpdateShiftType[] shifType)
    {
        this.apiKey = apiKey;
        this.shifType = shifType;
    }
}
