using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(WrapperName = "wsdlGetLeaveApplicationsV2", WrapperNamespace = "uri:FlexForce", IsWrapped = true)]
public class wsdlGetLeaveApplicationsV2Request
{
		[MessageBodyMember(Namespace = "", Order = 0)]
		public string apiKey;

		[MessageBodyMember(Namespace = "", Order = 1)]
		public getLeaveApplicationsV2Request getLeaveApplicationsV2Request;

	public wsdlGetLeaveApplicationsV2Request()
	{
	}

	public wsdlGetLeaveApplicationsV2Request(string apiKey, getLeaveApplicationsV2Request getLeaveApplicationsV2Request)
	{
		this.apiKey = apiKey;
		this.getLeaveApplicationsV2Request = getLeaveApplicationsV2Request;
	}
}
