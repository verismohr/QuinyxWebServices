using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(
    WrapperName = "wsdlGetAgreementTemplatesV2Response",
    WrapperNamespace = "uri:FlexForce",
    IsWrapped = true
)]
public class wsdlGetAgreementTemplatesV2Response
{
    [MessageBodyMember(Namespace = "", Order = 0)]
    public AgreementTemplatesV2Response @return;

    public wsdlGetAgreementTemplatesV2Response() { }

    public wsdlGetAgreementTemplatesV2Response(AgreementTemplatesV2Response @return)
    {
        this.@return = @return;
    }
}
