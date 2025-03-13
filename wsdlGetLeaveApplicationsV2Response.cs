using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(WrapperName = "wsdlGetLeaveApplicationsV2Response", WrapperNamespace = "uri:FlexForce", IsWrapped = true)]
public class wsdlGetLeaveApplicationsV2Response
{
		[MessageBodyMember(Namespace = "", Order = 0)]
		public GetLeaveApplicationsV2Response @return;

	public wsdlGetLeaveApplicationsV2Response()
	{
	}

	public wsdlGetLeaveApplicationsV2Response(GetLeaveApplicationsV2Response @return)
	{
		this.@return = @return;
	}
}
