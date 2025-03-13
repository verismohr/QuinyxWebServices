using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(WrapperName = "wsdlGetSchedulesV2", WrapperNamespace = "uri:FlexForce", IsWrapped = true)]
public class wsdlGetSchedulesV2Request
{
		[MessageBodyMember(Namespace = "", Order = 0)]
		public string apiKey;

		[MessageBodyMember(Namespace = "", Order = 1)]
		public GetSchedulesV2 GetSchedulesV2;

	public wsdlGetSchedulesV2Request()
	{
	}

	public wsdlGetSchedulesV2Request(string apiKey, GetSchedulesV2 GetSchedulesV2)
	{
		this.apiKey = apiKey;
		this.GetSchedulesV2 = GetSchedulesV2;
	}
}
