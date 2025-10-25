using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(
    WrapperName = "wsdlGetDeletedEmployeesResponse",
    WrapperNamespace = "uri:FlexForce",
    IsWrapped = true
)]
public class wsdlGetDeletedEmployeesResponse
{
    [MessageBodyMember(Namespace = "", Order = 0)]
    public DeletedEmployee[] @return;

    public wsdlGetDeletedEmployeesResponse() { }

    public wsdlGetDeletedEmployeesResponse(DeletedEmployee[] @return)
    {
        this.@return = @return;
    }
}
