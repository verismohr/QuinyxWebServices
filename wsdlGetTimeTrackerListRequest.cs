using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(
    WrapperName = "wsdlGetTimeTrackerList",
    WrapperNamespace = "uri:FlexForce",
    IsWrapped = true
)]
public class wsdlGetTimeTrackerListRequest
{
    [MessageBodyMember(Namespace = "", Order = 0)]
    public string apiKey;

    [MessageBodyMember(Namespace = "", Order = 1)]
    public string selectionId;

    [MessageBodyMember(Namespace = "", Order = 2)]
    public int selectionType;

    public wsdlGetTimeTrackerListRequest() { }

    public wsdlGetTimeTrackerListRequest(string apiKey, string selectionId, int selectionType)
    {
        this.apiKey = apiKey;
        this.selectionId = selectionId;
        this.selectionType = selectionType;
    }
}
