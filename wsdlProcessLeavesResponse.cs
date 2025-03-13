using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(WrapperName = "wsdlProcessLeavesResponse", WrapperNamespace = "uri:FlexForce", IsWrapped = true)]
public class wsdlProcessLeavesResponse
{
		[MessageBodyMember(Namespace = "", Order = 0)]
		public ProcessLeavesRecord[] @return;

	public wsdlProcessLeavesResponse()
	{
	}

	public wsdlProcessLeavesResponse(ProcessLeavesRecord[] @return)
	{
		this.@return = @return;
	}
}
