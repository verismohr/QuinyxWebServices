using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(WrapperName = "wsdlUpdateStandardBankHolidaysResponse", WrapperNamespace = "uri:FlexForce", IsWrapped = true)]
public class wsdlUpdateStandardBankHolidaysResponse
{
		[MessageBodyMember(Namespace = "", Order = 0)]
		public standardBankHoliday[] @return;

	public wsdlUpdateStandardBankHolidaysResponse()
	{
	}

	public wsdlUpdateStandardBankHolidaysResponse(standardBankHoliday[] @return)
	{
		this.@return = @return;
	}
}
