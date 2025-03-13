using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(WrapperName = "wsdlUpdateUnit", WrapperNamespace = "uri:FlexForce", IsWrapped = true)]
public class wsdlUpdateUnitRequest
{
		[MessageBodyMember(Namespace = "", Order = 0)]
		public string apiKey;

		[MessageBodyMember(Namespace = "", Order = 1)]
		public updateUnit unitInfo;

	public wsdlUpdateUnitRequest()
	{
	}

	public wsdlUpdateUnitRequest(string apiKey, updateUnit unitInfo)
	{
		this.apiKey = apiKey;
		this.unitInfo = unitInfo;
	}
}
