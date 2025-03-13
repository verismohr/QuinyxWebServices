using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(WrapperName = "wsdlGetEmployeePortraitResponse", WrapperNamespace = "uri:FlexForce", IsWrapped = true)]
public class wsdlGetEmployeePortraitResponse
{
		[MessageBodyMember(Namespace = "", Order = 0)]
		public Portrait @return;

	public wsdlGetEmployeePortraitResponse()
	{
	}

	public wsdlGetEmployeePortraitResponse(Portrait @return)
	{
		this.@return = @return;
	}
}
