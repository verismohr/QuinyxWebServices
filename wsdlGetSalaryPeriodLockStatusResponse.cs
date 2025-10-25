using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(
    WrapperName = "wsdlGetSalaryPeriodLockStatusResponse",
    WrapperNamespace = "uri:FlexForce",
    IsWrapped = true
)]
public class wsdlGetSalaryPeriodLockStatusResponse
{
    [MessageBodyMember(Namespace = "", Order = 0)]
    public string @return;

    public wsdlGetSalaryPeriodLockStatusResponse() { }

    public wsdlGetSalaryPeriodLockStatusResponse(string @return)
    {
        this.@return = @return;
    }
}
