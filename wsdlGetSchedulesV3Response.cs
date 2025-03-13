using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(WrapperName = "wsdlGetSchedulesV3Response", WrapperNamespace = "uri:FlexForce", IsWrapped = true)]
public class wsdlGetSchedulesV3Response
{
		[MessageBodyMember(Namespace = "", Order = 0)]
		public SchedulesV3Response @return;

	public wsdlGetSchedulesV3Response()
	{
	}

	public wsdlGetSchedulesV3Response(SchedulesV3Response @return)
	{
		this.@return = @return;
	}
}
