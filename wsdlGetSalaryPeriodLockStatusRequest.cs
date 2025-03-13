using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(WrapperName = "wsdlGetSalaryPeriodLockStatus", WrapperNamespace = "uri:FlexForce", IsWrapped = true)]
public class wsdlGetSalaryPeriodLockStatusRequest
{
		[MessageBodyMember(Namespace = "", Order = 0)]
		public string apiKey;

	public wsdlGetSalaryPeriodLockStatusRequest()
	{
	}

	public wsdlGetSalaryPeriodLockStatusRequest(string apiKey)
	{
		this.apiKey = apiKey;
	}
}
