using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(WrapperName = "wsdlGetEmployeePortrait", WrapperNamespace = "uri:FlexForce", IsWrapped = true)]
public class wsdlGetEmployeePortraitRequest
{
		[MessageBodyMember(Namespace = "", Order = 0)]
		public string apiKey;

		[MessageBodyMember(Namespace = "", Order = 1)]
		public string badgeNo;

		[MessageBodyMember(Namespace = "", Order = 2)]
		public string lastModified;

	public wsdlGetEmployeePortraitRequest()
	{
	}

	public wsdlGetEmployeePortraitRequest(string apiKey, string badgeNo, string lastModified)
	{
		this.apiKey = apiKey;
		this.badgeNo = badgeNo;
		this.lastModified = lastModified;
	}
}
