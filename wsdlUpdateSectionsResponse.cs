using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(WrapperName = "wsdlUpdateSectionsResponse", WrapperNamespace = "uri:FlexForce", IsWrapped = true)]
public class wsdlUpdateSectionsResponse
{
		[MessageBodyMember(Namespace = "", Order = 0)]
		public Section[] @return;

	public wsdlUpdateSectionsResponse()
	{
	}

	public wsdlUpdateSectionsResponse(Section[] @return)
	{
		this.@return = @return;
	}
}
