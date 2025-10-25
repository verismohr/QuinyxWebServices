using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(
    WrapperName = "wsdlGetAgreementInfoByDateResponse",
    WrapperNamespace = "uri:FlexForce",
    IsWrapped = true
)]
public class wsdlGetAgreementInfoByDateResponse
{
    [MessageBodyMember(Namespace = "", Order = 0)]
    public AgreementInfoByDate[] @return;

    public wsdlGetAgreementInfoByDateResponse() { }

    public wsdlGetAgreementInfoByDateResponse(AgreementInfoByDate[] @return)
    {
        this.@return = @return;
    }
}
