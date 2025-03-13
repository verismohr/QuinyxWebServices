using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(WrapperName = "wsdlCreateUnitResponse", WrapperNamespace = "uri:FlexForce", IsWrapped = true)]
public class wsdlCreateUnitResponse
{
		[MessageBodyMember(Namespace = "", Order = 0)]
		public createUnitInfo @return;

	public wsdlCreateUnitResponse()
	{
	}

	public wsdlCreateUnitResponse(createUnitInfo @return)
	{
		this.@return = @return;
	}
}
