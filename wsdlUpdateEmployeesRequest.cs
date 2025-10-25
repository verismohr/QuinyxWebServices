using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(
    WrapperName = "wsdlUpdateEmployees",
    WrapperNamespace = "uri:FlexForce",
    IsWrapped = true
)]
public class wsdlUpdateEmployeesRequest
{
    [MessageBodyMember(Namespace = "", Order = 0)]
    public string apiKey;

    [MessageBodyMember(Namespace = "", Order = 1)]
    public UpdateEmployee[] employees;

    public wsdlUpdateEmployeesRequest() { }

    public wsdlUpdateEmployeesRequest(string apiKey, UpdateEmployee[] employees)
    {
        this.apiKey = apiKey;
        this.employees = employees;
    }
}
