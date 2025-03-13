using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(WrapperName = "wsdlFindEmployees", WrapperNamespace = "uri:FlexForce", IsWrapped = true)]
public class wsdlFindEmployeesRequest
{
		[MessageBodyMember(Namespace = "", Order = 0)]
		public string apiKey;

		[MessageBodyMember(Namespace = "", Order = 1)]
		public badgeNo[] badgeNoList;

		[MessageBodyMember(Namespace = "", Order = 2)]
		public email[] emailList;

	public wsdlFindEmployeesRequest()
	{
	}

	public wsdlFindEmployeesRequest(string apiKey, badgeNo[] badgeNoList, email[] emailList)
	{
		this.apiKey = apiKey;
		this.badgeNoList = badgeNoList;
		this.emailList = emailList;
	}
}
