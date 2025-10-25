using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(
    WrapperName = "wsdlGetAgreementTemplatesSalaryTypes",
    WrapperNamespace = "uri:FlexForce",
    IsWrapped = true
)]
public class wsdlGetAgreementTemplatesSalaryTypesRequest
{
    [MessageBodyMember(Namespace = "", Order = 0)]
    public string apiKey;

    [MessageBodyMember(Namespace = "", Order = 1)]
    public GetAgreementTemplatesSalaryTypesRequest GetAgreementTemplatesSalaryTypesRequest;

    public wsdlGetAgreementTemplatesSalaryTypesRequest() { }

    public wsdlGetAgreementTemplatesSalaryTypesRequest(
        string apiKey,
        GetAgreementTemplatesSalaryTypesRequest GetAgreementTemplatesSalaryTypesRequest
    )
    {
        this.apiKey = apiKey;
        this.GetAgreementTemplatesSalaryTypesRequest = GetAgreementTemplatesSalaryTypesRequest;
    }
}
