using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(
    WrapperName = "wsdlProcessLeaves",
    WrapperNamespace = "uri:FlexForce",
    IsWrapped = true
)]
public class wsdlProcessLeavesRequest
{
    [MessageBodyMember(Namespace = "", Order = 0)]
    public string apiKey;

    [MessageBodyMember(Namespace = "", Order = 1)]
    public ProcessLeavesRecord[] ProcessLeavesRecords;

    public wsdlProcessLeavesRequest() { }

    public wsdlProcessLeavesRequest(string apiKey, ProcessLeavesRecord[] ProcessLeavesRecords)
    {
        this.apiKey = apiKey;
        this.ProcessLeavesRecords = ProcessLeavesRecords;
    }
}
