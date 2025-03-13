using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(WrapperName = "wsdlMoveEmployeesResponse", WrapperNamespace = "uri:FlexForce", IsWrapped = true)]
public class wsdlMoveEmployeesResponse
{
		[MessageBodyMember(Namespace = "", Order = 0)]
		public moveEmployee[] @return;

	public wsdlMoveEmployeesResponse()
	{
	}

	public wsdlMoveEmployeesResponse(moveEmployee[] @return)
	{
		this.@return = @return;
	}
}
