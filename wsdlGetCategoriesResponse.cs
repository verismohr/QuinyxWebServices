using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(WrapperName = "wsdlGetCategoriesResponse", WrapperNamespace = "uri:FlexForce", IsWrapped = true)]
public class wsdlGetCategoriesResponse
{
		[MessageBodyMember(Namespace = "", Order = 0)]
		public Category[] @return;

	public wsdlGetCategoriesResponse()
	{
	}

	public wsdlGetCategoriesResponse(Category[] @return)
	{
		this.@return = @return;
	}
}
