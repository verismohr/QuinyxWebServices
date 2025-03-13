using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(WrapperName = "wsdlGetShiftCategoriesResponse", WrapperNamespace = "uri:FlexForce", IsWrapped = true)]
public class wsdlGetShiftCategoriesResponse
{
		[MessageBodyMember(Namespace = "", Order = 0)]
		public ShiftCategory[] @return;

	public wsdlGetShiftCategoriesResponse()
	{
	}

	public wsdlGetShiftCategoriesResponse(ShiftCategory[] @return)
	{
		this.@return = @return;
	}
}
