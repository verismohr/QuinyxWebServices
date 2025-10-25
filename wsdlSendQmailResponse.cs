using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(
    WrapperName = "wsdlSendQmailResponse",
    WrapperNamespace = "uri:FlexForce",
    IsWrapped = true
)]
public class wsdlSendQmailResponse
{
    [MessageBodyMember(Namespace = "", Order = 0)]
    public Mail[] @return;

    public wsdlSendQmailResponse() { }

    public wsdlSendQmailResponse(Mail[] @return)
    {
        this.@return = @return;
    }
}
