using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(WrapperName = "wsdlUpdateTimeTrackersResponse", WrapperNamespace = "uri:FlexForce", IsWrapped = true)]
public class wsdlUpdateTimeTrackersResponse
{
		[MessageBodyMember(Namespace = "", Order = 0)]
		public timeTracker[] @return;

	public wsdlUpdateTimeTrackersResponse()
	{
	}

	public wsdlUpdateTimeTrackersResponse(timeTracker[] @return)
	{
		this.@return = @return;
	}
}
