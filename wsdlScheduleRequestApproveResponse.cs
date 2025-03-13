using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(WrapperName = "wsdlScheduleRequestApproveResponse", WrapperNamespace = "uri:FlexForce", IsWrapped = true)]
public class wsdlScheduleRequestApproveResponse
{
		[MessageBodyMember(Namespace = "", Order = 0)]
		public scheduleRequestResponse @return;

	public wsdlScheduleRequestApproveResponse()
	{
	}

	public wsdlScheduleRequestApproveResponse(scheduleRequestResponse @return)
	{
		this.@return = @return;
	}
}
