using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(WrapperName = "wsdlPunch", WrapperNamespace = "uri:FlexForce", IsWrapped = true)]
public class wsdlPunchRequest
{
    [MessageBodyMember(Namespace = "", Order = 0)]
    public string apiKey;

    [MessageBodyMember(Namespace = "", Order = 1)]
    public string badgeNumber;

    [MessageBodyMember(Namespace = "", Order = 2)]
    public string cardNumber;

    [MessageBodyMember(Namespace = "", Order = 3)]
    public int action;

    [MessageBodyMember(Namespace = "", Order = 4)]
    public string externalCostCentre;

    [MessageBodyMember(Namespace = "", Order = 5)]
    public string timestamp;

    public wsdlPunchRequest() { }

    public wsdlPunchRequest(
        string apiKey,
        string badgeNumber,
        string cardNumber,
        int action,
        string externalCostCentre,
        string timestamp
    )
    {
        this.apiKey = apiKey;
        this.badgeNumber = badgeNumber;
        this.cardNumber = cardNumber;
        this.action = action;
        this.externalCostCentre = externalCostCentre;
        this.timestamp = timestamp;
    }
}
