using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(
    WrapperName = "wsdlGetAgreementsResponse",
    WrapperNamespace = "uri:FlexForce",
    IsWrapped = true
)]
public class wsdlGetAgreementsResponse
{
    [MessageBodyMember(Namespace = "", Order = 0)]
    public Agreement[] @return;

    public wsdlGetAgreementsResponse() { }

    public wsdlGetAgreementsResponse(Agreement[] @return)
    {
        this.@return = @return;
    }
}
