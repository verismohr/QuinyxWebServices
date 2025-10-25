using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(
    WrapperName = "wsdlGetEmployeesResponse",
    WrapperNamespace = "uri:FlexForce",
    IsWrapped = true
)]
public class wsdlGetEmployeesResponse
{
    [MessageBodyMember(Namespace = "", Order = 0)]
    public Employee[] @return;

    public wsdlGetEmployeesResponse() { }

    public wsdlGetEmployeesResponse(Employee[] @return)
    {
        this.@return = @return;
    }
}
