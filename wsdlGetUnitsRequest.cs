using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(WrapperName = "wsdlGetUnits", WrapperNamespace = "uri:FlexForce", IsWrapped = true)]
public class wsdlGetUnitsRequest
{
		[MessageBodyMember(Namespace = "", Order = 0)]
		public string apiKey;

		[MessageBodyMember(Namespace = "", Order = 1)]
		public string modifiedAfter;

	public wsdlGetUnitsRequest()
	{
	}

	public wsdlGetUnitsRequest(string apiKey, string modifiedAfter)
	{
		this.apiKey = apiKey;
		this.modifiedAfter = modifiedAfter;
	}
}
