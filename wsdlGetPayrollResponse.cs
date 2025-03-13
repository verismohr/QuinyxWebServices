using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(WrapperName = "wsdlGetPayrollResponse", WrapperNamespace = "uri:FlexForce", IsWrapped = true)]
public class wsdlGetPayrollResponse
{
		[MessageBodyMember(Namespace = "", Order = 0)]
		public Payroll[] @return;

	public wsdlGetPayrollResponse()
	{
	}

	public wsdlGetPayrollResponse(Payroll[] @return)
	{
		this.@return = @return;
	}
}
