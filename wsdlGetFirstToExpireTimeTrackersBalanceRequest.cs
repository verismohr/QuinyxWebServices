using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(WrapperName = "wsdlGetFirstToExpireTimeTrackersBalance", WrapperNamespace = "uri:FlexForce", IsWrapped = true)]
public class wsdlGetFirstToExpireTimeTrackersBalanceRequest
{
		[MessageBodyMember(Namespace = "", Order = 0)]
		public string apiKey;

		[MessageBodyMember(Namespace = "", Order = 1)]
		public ttFirstToExpireBalanceItem[] timeTrackers;

	public wsdlGetFirstToExpireTimeTrackersBalanceRequest()
	{
	}

	public wsdlGetFirstToExpireTimeTrackersBalanceRequest(string apiKey, ttFirstToExpireBalanceItem[] timeTrackers)
	{
		this.apiKey = apiKey;
		this.timeTrackers = timeTrackers;
	}
}
