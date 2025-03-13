using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(WrapperName = "wsdlGetPayrollRawResponse", WrapperNamespace = "uri:FlexForce", IsWrapped = true)]
public class wsdlGetPayrollRawResponse
{
		[MessageBodyMember(Namespace = "", Order = 0)]
		public PayrollRaw[] @return;

	public wsdlGetPayrollRawResponse()
	{
	}

	public wsdlGetPayrollRawResponse(PayrollRaw[] @return)
	{
		this.@return = @return;
	}
}
