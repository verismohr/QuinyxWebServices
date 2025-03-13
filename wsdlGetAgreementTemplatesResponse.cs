using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(WrapperName = "wsdlGetAgreementTemplatesResponse", WrapperNamespace = "uri:FlexForce", IsWrapped = true)]
public class wsdlGetAgreementTemplatesResponse
{
		[MessageBodyMember(Namespace = "", Order = 0)]
		public AgreementTemplate[] @return;

	public wsdlGetAgreementTemplatesResponse()
	{
	}

	public wsdlGetAgreementTemplatesResponse(AgreementTemplate[] @return)
	{
		this.@return = @return;
	}
}
