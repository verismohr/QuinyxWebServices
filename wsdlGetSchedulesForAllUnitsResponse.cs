using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(
    WrapperName = "wsdlGetSchedulesForAllUnitsResponse",
    WrapperNamespace = "uri:FlexForce",
    IsWrapped = true
)]
public class wsdlGetSchedulesForAllUnitsResponse
{
    [MessageBodyMember(Namespace = "", Order = 0)]
    public Schedule[] @return;

    public wsdlGetSchedulesForAllUnitsResponse() { }

    public wsdlGetSchedulesForAllUnitsResponse(Schedule[] @return)
    {
        this.@return = @return;
    }
}
