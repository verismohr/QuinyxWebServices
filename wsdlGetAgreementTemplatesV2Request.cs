using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(
    WrapperName = "wsdlGetAgreementTemplatesV2",
    WrapperNamespace = "uri:FlexForce",
    IsWrapped = true
)]
public class wsdlGetAgreementTemplatesV2Request
{
    [MessageBodyMember(Namespace = "", Order = 0)]
    public string apiKey;

    [MessageBodyMember(Namespace = "", Order = 1)]
    public GetAgreementTemplatesV2 GetAgreementTemplatesV2;

    public wsdlGetAgreementTemplatesV2Request() { }

    public wsdlGetAgreementTemplatesV2Request(
        string apiKey,
        GetAgreementTemplatesV2 GetAgreementTemplatesV2
    )
    {
        this.apiKey = apiKey;
        this.GetAgreementTemplatesV2 = GetAgreementTemplatesV2;
    }
}
