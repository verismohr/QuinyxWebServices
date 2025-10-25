using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(
    WrapperName = "wsdlFindEmployeesResponse",
    WrapperNamespace = "uri:FlexForce",
    IsWrapped = true
)]
public class wsdlFindEmployeesResponse
{
    [MessageBodyMember(Namespace = "", Order = 0)]
    public UnitEmployee[] @return;

    public wsdlFindEmployeesResponse() { }

    public wsdlFindEmployeesResponse(UnitEmployee[] @return)
    {
        this.@return = @return;
    }
}
