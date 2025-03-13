using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(WrapperName = "wsdlUpdateAgreementsV2Response", WrapperNamespace = "uri:FlexForce", IsWrapped = true)]
public class wsdlUpdateAgreementsV2Response
{
		[MessageBodyMember(Namespace = "", Order = 0)]
		public UpdateAgreementV2[] @return;

	public wsdlUpdateAgreementsV2Response()
	{
	}

	public wsdlUpdateAgreementsV2Response(UpdateAgreementV2[] @return)
	{
		this.@return = @return;
	}
}
