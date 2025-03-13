using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(WrapperName = "wsdlGetAgreementInfoByDate", WrapperNamespace = "uri:FlexForce", IsWrapped = true)]
public class wsdlGetAgreementInfoByDateRequest
{
		[MessageBodyMember(Namespace = "", Order = 0)]
		public string apiKey;

		[MessageBodyMember(Namespace = "", Order = 1)]
		public InfoByDate infoByDate;

	public wsdlGetAgreementInfoByDateRequest()
	{
	}

	public wsdlGetAgreementInfoByDateRequest(string apiKey, InfoByDate infoByDate)
	{
		this.apiKey = apiKey;
		this.infoByDate = infoByDate;
	}
}
