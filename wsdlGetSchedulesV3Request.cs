using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(WrapperName = "wsdlGetSchedulesV3", WrapperNamespace = "uri:FlexForce", IsWrapped = true)]
public class wsdlGetSchedulesV3Request
{
		[MessageBodyMember(Namespace = "", Order = 0)]
		public string apiKey;

		[MessageBodyMember(Namespace = "", Order = 1)]
		public GetSchedulesV3 GetSchedulesV3;

	public wsdlGetSchedulesV3Request()
	{
	}

	public wsdlGetSchedulesV3Request(string apiKey, GetSchedulesV3 GetSchedulesV3)
	{
		this.apiKey = apiKey;
		this.GetSchedulesV3 = GetSchedulesV3;
	}
}
