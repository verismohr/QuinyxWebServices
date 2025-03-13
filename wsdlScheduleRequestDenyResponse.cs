using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(WrapperName = "wsdlScheduleRequestDenyResponse", WrapperNamespace = "uri:FlexForce", IsWrapped = true)]
public class wsdlScheduleRequestDenyResponse
{
		[MessageBodyMember(Namespace = "", Order = 0)]
		public scheduleRequestResponse @return;

	public wsdlScheduleRequestDenyResponse()
	{
	}

	public wsdlScheduleRequestDenyResponse(scheduleRequestResponse @return)
	{
		this.@return = @return;
	}
}
