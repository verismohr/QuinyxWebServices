using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(
    WrapperName = "wsdlUpdateAgreementsV2",
    WrapperNamespace = "uri:FlexForce",
    IsWrapped = true
)]
public class wsdlUpdateAgreementsV2Request
{
    [MessageBodyMember(Namespace = "", Order = 0)]
    public string apiKey;

    [MessageBodyMember(Namespace = "", Order = 1)]
    public UpdateAgreementV2[] agreements;

    public wsdlUpdateAgreementsV2Request() { }

    public wsdlUpdateAgreementsV2Request(string apiKey, UpdateAgreementV2[] agreements)
    {
        this.apiKey = apiKey;
        this.agreements = agreements;
    }
}
