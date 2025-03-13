using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(WrapperName = "wsdlGetActiveAndAbsenceHoursResponse", WrapperNamespace = "uri:FlexForce", IsWrapped = true)]
public class wsdlGetActiveAndAbsenceHoursResponse
{
		[MessageBodyMember(Namespace = "", Order = 0)]
		public EmployeeTime[] @return;

	public wsdlGetActiveAndAbsenceHoursResponse()
	{
	}

	public wsdlGetActiveAndAbsenceHoursResponse(EmployeeTime[] @return)
	{
		this.@return = @return;
	}
}
