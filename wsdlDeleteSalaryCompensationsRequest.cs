using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(
    WrapperName = "wsdlDeleteSalaryCompensations",
    WrapperNamespace = "uri:FlexForce",
    IsWrapped = true
)]
public class wsdlDeleteSalaryCompensationsRequest
{
    [MessageBodyMember(Namespace = "", Order = 0)]
    public string apiKey;

    [MessageBodyMember(Namespace = "", Order = 1)]
    public SalaryCompensation[] salaryCompensations;

    public wsdlDeleteSalaryCompensationsRequest() { }

    public wsdlDeleteSalaryCompensationsRequest(
        string apiKey,
        SalaryCompensation[] salaryCompensations
    )
    {
        this.apiKey = apiKey;
        this.salaryCompensations = salaryCompensations;
    }
}
