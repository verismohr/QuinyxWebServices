using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(
    WrapperName = "wsdlUpdateEmployeesResponse",
    WrapperNamespace = "uri:FlexForce",
    IsWrapped = true
)]
public class wsdlUpdateEmployeesResponse
{
    [MessageBodyMember(Namespace = "", Order = 0)]
    public UpdateEmployee[] @return;

    public wsdlUpdateEmployeesResponse() { }

    public wsdlUpdateEmployeesResponse(UpdateEmployee[] @return)
    {
        this.@return = @return;
    }
}
