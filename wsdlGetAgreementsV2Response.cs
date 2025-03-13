using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(WrapperName = "wsdlGetAgreementsV2Response", WrapperNamespace = "uri:FlexForce", IsWrapped = true)]
public class wsdlGetAgreementsV2Response
{
		[MessageBodyMember(Namespace = "", Order = 0)]
		public AgreementsV2Response @return;

	public wsdlGetAgreementsV2Response()
	{
	}

	public wsdlGetAgreementsV2Response(AgreementsV2Response @return)
	{
		this.@return = @return;
	}
}
