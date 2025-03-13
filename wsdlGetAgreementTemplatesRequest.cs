using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(WrapperName = "wsdlGetAgreementTemplates", WrapperNamespace = "uri:FlexForce", IsWrapped = true)]
public class wsdlGetAgreementTemplatesRequest
{
		[MessageBodyMember(Namespace = "", Order = 0)]
		public string apiKey;

		[MessageBodyMember(Namespace = "", Order = 1)]
		public int agreementTemplateId;

		[MessageBodyMember(Namespace = "", Order = 2)]
		public string lastModified;

	public wsdlGetAgreementTemplatesRequest()
	{
	}

	public wsdlGetAgreementTemplatesRequest(string apiKey, int agreementTemplateId, string lastModified)
	{
		this.apiKey = apiKey;
		this.agreementTemplateId = agreementTemplateId;
		this.lastModified = lastModified;
	}
}
