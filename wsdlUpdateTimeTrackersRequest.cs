using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(WrapperName = "wsdlUpdateTimeTrackers", WrapperNamespace = "uri:FlexForce", IsWrapped = true)]
public class wsdlUpdateTimeTrackersRequest
{
		[MessageBodyMember(Namespace = "", Order = 0)]
		public string apiKey;

		[MessageBodyMember(Namespace = "", Order = 1)]
		public timeTracker[] timeTrackers;

	public wsdlUpdateTimeTrackersRequest()
	{
	}

	public wsdlUpdateTimeTrackersRequest(string apiKey, timeTracker[] timeTrackers)
	{
		this.apiKey = apiKey;
		this.timeTrackers = timeTrackers;
	}
}
