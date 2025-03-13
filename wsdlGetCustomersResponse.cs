using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(WrapperName = "wsdlGetCustomersResponse", WrapperNamespace = "uri:FlexForce", IsWrapped = true)]
public class wsdlGetCustomersResponse
{
		[MessageBodyMember(Namespace = "", Order = 0)]
		public Customer[] @return;

	public wsdlGetCustomersResponse()
	{
	}

	public wsdlGetCustomersResponse(Customer[] @return)
	{
		this.@return = @return;
	}
}
