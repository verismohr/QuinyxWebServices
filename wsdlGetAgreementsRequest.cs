using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(WrapperName = "wsdlGetAgreements", WrapperNamespace = "uri:FlexForce", IsWrapped = true)]
public class wsdlGetAgreementsRequest
{
		[MessageBodyMember(Namespace = "", Order = 0)]
		public string apiKey;

		[MessageBodyMember(Namespace = "", Order = 1)]
		public int sectionId;

		[MessageBodyMember(Namespace = "", Order = 2)]
		public int employeeId;

		[MessageBodyMember(Namespace = "", Order = 3)]
		public string badgeNo;

		[MessageBodyMember(Namespace = "", Order = 4)]
		public string lastModified;

	public wsdlGetAgreementsRequest()
	{
	}

	public wsdlGetAgreementsRequest(string apiKey, int sectionId, int employeeId, string badgeNo, string lastModified)
	{
		this.apiKey = apiKey;
		this.sectionId = sectionId;
		this.employeeId = employeeId;
		this.badgeNo = badgeNo;
		this.lastModified = lastModified;
	}
}
