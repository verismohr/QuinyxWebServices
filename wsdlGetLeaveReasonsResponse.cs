using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(WrapperName = "wsdlGetLeaveReasonsResponse", WrapperNamespace = "uri:FlexForce", IsWrapped = true)]
public class wsdlGetLeaveReasonsResponse
{
		[MessageBodyMember(Namespace = "", Order = 0)]
		public LeaveReason[] @return;

	public wsdlGetLeaveReasonsResponse()
	{
	}

	public wsdlGetLeaveReasonsResponse(LeaveReason[] @return)
	{
		this.@return = @return;
	}
}
