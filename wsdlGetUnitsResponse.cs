using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(WrapperName = "wsdlGetUnitsResponse", WrapperNamespace = "uri:FlexForce", IsWrapped = true)]
public class wsdlGetUnitsResponse
{
		[MessageBodyMember(Namespace = "", Order = 0)]
		public Unit[] @return;

	public wsdlGetUnitsResponse()
	{
	}

	public wsdlGetUnitsResponse(Unit[] @return)
	{
		this.@return = @return;
	}
}
