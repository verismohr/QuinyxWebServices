using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(WrapperName = "wsdlGetSectionsResponse", WrapperNamespace = "uri:FlexForce", IsWrapped = true)]
public class wsdlGetSectionsResponse
{
		[MessageBodyMember(Namespace = "", Order = 0)]
		public Section[] @return;

	public wsdlGetSectionsResponse()
	{
	}

	public wsdlGetSectionsResponse(Section[] @return)
	{
		this.@return = @return;
	}
}
