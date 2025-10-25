using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(
    WrapperName = "wsdlGetAgreementsV2",
    WrapperNamespace = "uri:FlexForce",
    IsWrapped = true
)]
public class wsdlGetAgreementsV2Request
{
    [MessageBodyMember(Namespace = "", Order = 0)]
    public string apiKey;

    [MessageBodyMember(Namespace = "", Order = 1)]
    public GetAgreementsV2 GetAgreementsV2;

    public wsdlGetAgreementsV2Request() { }

    public wsdlGetAgreementsV2Request(string apiKey, GetAgreementsV2 GetAgreementsV2)
    {
        this.apiKey = apiKey;
        this.GetAgreementsV2 = GetAgreementsV2;
    }
}
