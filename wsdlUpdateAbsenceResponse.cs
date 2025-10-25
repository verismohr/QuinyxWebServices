using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(
    WrapperName = "wsdlUpdateAbsenceResponse",
    WrapperNamespace = "uri:FlexForce",
    IsWrapped = true
)]
public class wsdlUpdateAbsenceResponse
{
    [MessageBodyMember(Namespace = "", Order = 0)]
    public AbsenceRecord[] @return;

    public wsdlUpdateAbsenceResponse() { }

    public wsdlUpdateAbsenceResponse(AbsenceRecord[] @return)
    {
        this.@return = @return;
    }
}
