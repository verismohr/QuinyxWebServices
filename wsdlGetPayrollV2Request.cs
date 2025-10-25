using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(
    WrapperName = "wsdlGetPayrollV2",
    WrapperNamespace = "uri:FlexForce",
    IsWrapped = true
)]
public class wsdlGetPayrollV2Request
{
    [MessageBodyMember(Namespace = "", Order = 0)]
    public string apiKey;

    [MessageBodyMember(Namespace = "", Order = 1)]
    public getPayrollV2Request getPayrollV2Request;

    public wsdlGetPayrollV2Request() { }

    public wsdlGetPayrollV2Request(string apiKey, getPayrollV2Request getPayrollV2Request)
    {
        this.apiKey = apiKey;
        this.getPayrollV2Request = getPayrollV2Request;
    }
}
