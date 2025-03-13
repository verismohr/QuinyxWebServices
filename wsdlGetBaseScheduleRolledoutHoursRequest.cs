using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(WrapperName = "wsdlGetBaseScheduleRolledoutHours", WrapperNamespace = "uri:FlexForce", IsWrapped = true)]
public class wsdlGetBaseScheduleRolledoutHoursRequest
{
		[MessageBodyMember(Namespace = "", Order = 0)]
		public string apiKey;

		[MessageBodyMember(Namespace = "", Order = 1)]
		public baseScheduleRollout baseScheduleRollout;

	public wsdlGetBaseScheduleRolledoutHoursRequest()
	{
	}

	public wsdlGetBaseScheduleRolledoutHoursRequest(string apiKey, baseScheduleRollout baseScheduleRollout)
	{
		this.apiKey = apiKey;
		this.baseScheduleRollout = baseScheduleRollout;
	}
}
