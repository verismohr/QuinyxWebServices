using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(WrapperName = "wsdlGetLeaveReasons", WrapperNamespace = "uri:FlexForce", IsWrapped = true)]
public class wsdlGetLeaveReasonsRequest
{
		[MessageBodyMember(Namespace = "", Order = 0)]
		public string apiKey;

		[MessageBodyMember(Namespace = "", Order = 1)]
		public string lastModified;

	public wsdlGetLeaveReasonsRequest()
	{
	}

	public wsdlGetLeaveReasonsRequest(string apiKey, string lastModified)
	{
		this.apiKey = apiKey;
		this.lastModified = lastModified;
	}
}
