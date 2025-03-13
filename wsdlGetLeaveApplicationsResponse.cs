using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(WrapperName = "wsdlGetLeaveApplicationsResponse", WrapperNamespace = "uri:FlexForce", IsWrapped = true)]
public class wsdlGetLeaveApplicationsResponse
{
		[MessageBodyMember(Namespace = "", Order = 0)]
		public LeaveApplication[] @return;

	public wsdlGetLeaveApplicationsResponse()
	{
	}

	public wsdlGetLeaveApplicationsResponse(LeaveApplication[] @return)
	{
		this.@return = @return;
	}
}
