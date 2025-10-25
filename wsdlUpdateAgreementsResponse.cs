using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(
    WrapperName = "wsdlUpdateAgreementsResponse",
    WrapperNamespace = "uri:FlexForce",
    IsWrapped = true
)]
public class wsdlUpdateAgreementsResponse
{
    [MessageBodyMember(Namespace = "", Order = 0)]
    public UpdateAgreement[] @return;

    public wsdlUpdateAgreementsResponse() { }

    public wsdlUpdateAgreementsResponse(UpdateAgreement[] @return)
    {
        this.@return = @return;
    }
}
