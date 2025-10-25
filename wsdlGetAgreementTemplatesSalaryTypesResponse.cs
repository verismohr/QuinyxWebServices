using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(
    WrapperName = "wsdlGetAgreementTemplatesSalaryTypesResponse",
    WrapperNamespace = "uri:FlexForce",
    IsWrapped = true
)]
public class wsdlGetAgreementTemplatesSalaryTypesResponse
{
    [MessageBodyMember(Namespace = "", Order = 0)]
    public AgreementTemplatesSalaryTypesResponse @return;

    public wsdlGetAgreementTemplatesSalaryTypesResponse() { }

    public wsdlGetAgreementTemplatesSalaryTypesResponse(
        AgreementTemplatesSalaryTypesResponse @return
    )
    {
        this.@return = @return;
    }
}
