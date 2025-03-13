using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(WrapperName = "wsdlGetFirstToExpireTimeTrackersBalanceResponse", WrapperNamespace = "uri:FlexForce", IsWrapped = true)]
public class wsdlGetFirstToExpireTimeTrackersBalanceResponse
{
		[MessageBodyMember(Namespace = "", Order = 0)]
		public ttFirstToExpireBalanceResultItem[] @return;

	public wsdlGetFirstToExpireTimeTrackersBalanceResponse()
	{
	}

	public wsdlGetFirstToExpireTimeTrackersBalanceResponse(ttFirstToExpireBalanceResultItem[] @return)
	{
		this.@return = @return;
	}
}
