using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(WrapperName = "wsdlGetEmployeesV2Response", WrapperNamespace = "uri:FlexForce", IsWrapped = true)]
public class wsdlGetEmployeesV2Response
{
		[MessageBodyMember(Namespace = "", Order = 0)]
		public Employee[] @return;

	public wsdlGetEmployeesV2Response()
	{
	}

	public wsdlGetEmployeesV2Response(Employee[] @return)
	{
		this.@return = @return;
	}
}
