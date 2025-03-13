using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(WrapperName = "wsdlUpdateEmployeeAttachmentsResponse", WrapperNamespace = "uri:FlexForce", IsWrapped = true)]
public class wsdlUpdateEmployeeAttachmentsResponse
{
		[MessageBodyMember(Namespace = "", Order = 0)]
		public EmployeeAttachment[] @return;

	public wsdlUpdateEmployeeAttachmentsResponse()
	{
	}

	public wsdlUpdateEmployeeAttachmentsResponse(EmployeeAttachment[] @return)
	{
		this.@return = @return;
	}
}
