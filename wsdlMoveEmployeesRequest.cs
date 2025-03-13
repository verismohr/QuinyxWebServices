using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(WrapperName = "wsdlMoveEmployees", WrapperNamespace = "uri:FlexForce", IsWrapped = true)]
public class wsdlMoveEmployeesRequest
{
		[MessageBodyMember(Namespace = "", Order = 0)]
		public string apiKey;

		[MessageBodyMember(Namespace = "", Order = 1)]
		public moveEmployee[] moveEmployees;

	public wsdlMoveEmployeesRequest()
	{
	}

	public wsdlMoveEmployeesRequest(string apiKey, moveEmployee[] moveEmployees)
	{
		this.apiKey = apiKey;
		this.moveEmployees = moveEmployees;
	}
}
