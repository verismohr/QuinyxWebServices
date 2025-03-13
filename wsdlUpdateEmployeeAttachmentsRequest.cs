using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(WrapperName = "wsdlUpdateEmployeeAttachments", WrapperNamespace = "uri:FlexForce", IsWrapped = true)]
public class wsdlUpdateEmployeeAttachmentsRequest
{
		[MessageBodyMember(Namespace = "", Order = 0)]
		public string apiKey;

		[MessageBodyMember(Namespace = "", Order = 1)]
		public EmployeeAttachment[] employees;

	public wsdlUpdateEmployeeAttachmentsRequest()
	{
	}

	public wsdlUpdateEmployeeAttachmentsRequest(string apiKey, EmployeeAttachment[] employees)
	{
		this.apiKey = apiKey;
		this.employees = employees;
	}
}
