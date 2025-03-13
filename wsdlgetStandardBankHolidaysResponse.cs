using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(WrapperName = "wsdlgetStandardBankHolidaysResponse", WrapperNamespace = "uri:FlexForce", IsWrapped = true)]
public class wsdlgetStandardBankHolidaysResponse
{
		[MessageBodyMember(Namespace = "", Order = 0)]
		public standardBankHoliday[] @return;

	public wsdlgetStandardBankHolidaysResponse()
	{
	}

	public wsdlgetStandardBankHolidaysResponse(standardBankHoliday[] @return)
	{
		this.@return = @return;
	}
}
