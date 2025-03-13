using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(WrapperName = "wsdlSendQmail", WrapperNamespace = "uri:FlexForce", IsWrapped = true)]
public class wsdlSendQmailRequest
{
		[MessageBodyMember(Namespace = "", Order = 0)]
		public string apiKey;

		[MessageBodyMember(Namespace = "", Order = 1)]
		public Mail[] mail;

	public wsdlSendQmailRequest()
	{
	}

	public wsdlSendQmailRequest(string apiKey, Mail[] mail)
	{
		this.apiKey = apiKey;
		this.mail = mail;
	}
}
