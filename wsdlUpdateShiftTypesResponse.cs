using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(WrapperName = "wsdlUpdateShiftTypesResponse", WrapperNamespace = "uri:FlexForce", IsWrapped = true)]
public class wsdlUpdateShiftTypesResponse
{
		[MessageBodyMember(Namespace = "", Order = 0)]
		public UpdateShiftType[] @return;

	public wsdlUpdateShiftTypesResponse()
	{
	}

	public wsdlUpdateShiftTypesResponse(UpdateShiftType[] @return)
	{
		this.@return = @return;
	}
}
