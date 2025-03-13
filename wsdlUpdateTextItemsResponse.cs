using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(WrapperName = "wsdlUpdateTextItemsResponse", WrapperNamespace = "uri:FlexForce", IsWrapped = true)]
public class wsdlUpdateTextItemsResponse
{
		[MessageBodyMember(Namespace = "", Order = 0)]
		public TextItem[] @return;

	public wsdlUpdateTextItemsResponse()
	{
	}

	public wsdlUpdateTextItemsResponse(TextItem[] @return)
	{
		this.@return = @return;
	}
}
