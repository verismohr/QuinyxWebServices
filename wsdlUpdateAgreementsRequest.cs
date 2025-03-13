using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(WrapperName = "wsdlUpdateAgreements", WrapperNamespace = "uri:FlexForce", IsWrapped = true)]
public class wsdlUpdateAgreementsRequest
{
		[MessageBodyMember(Namespace = "", Order = 0)]
		public string apiKey;

		[MessageBodyMember(Namespace = "", Order = 1)]
		public UpdateAgreement[] agreements;

	public wsdlUpdateAgreementsRequest()
	{
	}

	public wsdlUpdateAgreementsRequest(string apiKey, UpdateAgreement[] agreements)
	{
		this.apiKey = apiKey;
		this.agreements = agreements;
	}
}
