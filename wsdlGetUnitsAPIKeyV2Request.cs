using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(WrapperName = "wsdlGetUnitsAPIKeyV2", WrapperNamespace = "uri:FlexForce", IsWrapped = true)]
public class wsdlGetUnitsAPIKeyV2Request
{
		[MessageBodyMember(Namespace = "", Order = 0)]
		public string apiKey;

	public wsdlGetUnitsAPIKeyV2Request()
	{
	}

	public wsdlGetUnitsAPIKeyV2Request(string apiKey)
	{
		this.apiKey = apiKey;
	}
}
