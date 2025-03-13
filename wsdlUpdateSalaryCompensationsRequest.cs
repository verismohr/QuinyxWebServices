using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(WrapperName = "wsdlUpdateSalaryCompensations", WrapperNamespace = "uri:FlexForce", IsWrapped = true)]
public class wsdlUpdateSalaryCompensationsRequest
{
		[MessageBodyMember(Namespace = "", Order = 0)]
		public string apiKey;

		[MessageBodyMember(Namespace = "", Order = 1)]
		public SalaryCompensation[] salaryCompensations;

	public wsdlUpdateSalaryCompensationsRequest()
	{
	}

	public wsdlUpdateSalaryCompensationsRequest(string apiKey, SalaryCompensation[] salaryCompensations)
	{
		this.apiKey = apiKey;
		this.salaryCompensations = salaryCompensations;
	}
}
