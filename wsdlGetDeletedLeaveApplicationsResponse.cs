using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(WrapperName = "wsdlGetDeletedLeaveApplicationsResponse", WrapperNamespace = "uri:FlexForce", IsWrapped = true)]
public class wsdlGetDeletedLeaveApplicationsResponse
{
		[MessageBodyMember(Namespace = "", Order = 0)]
		public LeaveApplication[] @return;

	public wsdlGetDeletedLeaveApplicationsResponse()
	{
	}

	public wsdlGetDeletedLeaveApplicationsResponse(LeaveApplication[] @return)
	{
		this.@return = @return;
	}
}
