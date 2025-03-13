using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(WrapperName = "wsdlGetDeletedEmployees", WrapperNamespace = "uri:FlexForce", IsWrapped = true)]
public class wsdlGetDeletedEmployeesRequest
{
		[MessageBodyMember(Namespace = "", Order = 0)]
		public string apiKey;

		[MessageBodyMember(Namespace = "", Order = 1)]
		public string deletedSince;

	public wsdlGetDeletedEmployeesRequest()
	{
	}

	public wsdlGetDeletedEmployeesRequest(string apiKey, string deletedSince)
	{
		this.apiKey = apiKey;
		this.deletedSince = deletedSince;
	}
}
