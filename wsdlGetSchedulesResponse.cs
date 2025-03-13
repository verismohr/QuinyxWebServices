using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(WrapperName = "wsdlGetSchedulesResponse", WrapperNamespace = "uri:FlexForce", IsWrapped = true)]
public class wsdlGetSchedulesResponse
{
		[MessageBodyMember(Namespace = "", Order = 0)]
		public Schedule[] @return;

	public wsdlGetSchedulesResponse()
	{
	}

	public wsdlGetSchedulesResponse(Schedule[] @return)
	{
		this.@return = @return;
	}
}
