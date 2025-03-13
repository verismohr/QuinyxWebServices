using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(WrapperName = "wsdlUpdateSalaryCompensationsResponse", WrapperNamespace = "uri:FlexForce", IsWrapped = true)]
public class wsdlUpdateSalaryCompensationsResponse
{
		[MessageBodyMember(Namespace = "", Order = 0)]
		public SalaryCompensation[] @return;

	public wsdlUpdateSalaryCompensationsResponse()
	{
	}

	public wsdlUpdateSalaryCompensationsResponse(SalaryCompensation[] @return)
	{
		this.@return = @return;
	}
}
