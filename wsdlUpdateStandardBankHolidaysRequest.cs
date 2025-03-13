using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(WrapperName = "wsdlUpdateStandardBankHolidays", WrapperNamespace = "uri:FlexForce", IsWrapped = true)]
public class wsdlUpdateStandardBankHolidaysRequest
{
		[MessageBodyMember(Namespace = "", Order = 0)]
		public string apiKey;

		[MessageBodyMember(Namespace = "", Order = 1)]
		public standardBankHoliday[] bankHolidays;

	public wsdlUpdateStandardBankHolidaysRequest()
	{
	}

	public wsdlUpdateStandardBankHolidaysRequest(string apiKey, standardBankHoliday[] bankHolidays)
	{
		this.apiKey = apiKey;
		this.bankHolidays = bankHolidays;
	}
}
