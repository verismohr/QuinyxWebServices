using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(WrapperName = "wsdlGetOvertimeMethods", WrapperNamespace = "uri:FlexForce", IsWrapped = true)]
public class wsdlGetOvertimeMethodsRequest
{
		[MessageBodyMember(Namespace = "", Order = 0)]
		public string apiKey;

		[MessageBodyMember(Namespace = "", Order = 1)]
		public string lastModified;

	public wsdlGetOvertimeMethodsRequest()
	{
	}

	public wsdlGetOvertimeMethodsRequest(string apiKey, string lastModified)
	{
		this.apiKey = apiKey;
		this.lastModified = lastModified;
	}
}
