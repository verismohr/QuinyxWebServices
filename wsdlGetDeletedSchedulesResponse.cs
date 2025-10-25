using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(
    WrapperName = "wsdlGetDeletedSchedulesResponse",
    WrapperNamespace = "uri:FlexForce",
    IsWrapped = true
)]
public class wsdlGetDeletedSchedulesResponse
{
    [MessageBodyMember(Namespace = "", Order = 0)]
    public Schedule[] @return;

    public wsdlGetDeletedSchedulesResponse() { }

    public wsdlGetDeletedSchedulesResponse(Schedule[] @return)
    {
        this.@return = @return;
    }
}
