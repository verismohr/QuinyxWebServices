using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(WrapperName = "wsdlUpdateShiftsResponse", WrapperNamespace = "uri:FlexForce", IsWrapped = true)]
public class wsdlUpdateShiftsResponse
{
		[MessageBodyMember(Namespace = "", Order = 0)]
		public Shift[] @return;

	public wsdlUpdateShiftsResponse()
	{
	}

	public wsdlUpdateShiftsResponse(Shift[] @return)
	{
		this.@return = @return;
	}
}
