using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(WrapperName = "wsdlGetDeletedSchedules", WrapperNamespace = "uri:FlexForce", IsWrapped = true)]
public class wsdlGetDeletedSchedulesRequest
{
		[MessageBodyMember(Namespace = "", Order = 0)]
		public string apiKey;

		[MessageBodyMember(Namespace = "", Order = 1)]
		public int sectionId;

		[MessageBodyMember(Namespace = "", Order = 2)]
		public int employeeId;

		[MessageBodyMember(Namespace = "", Order = 3)]
		public string badgeNo;

		[MessageBodyMember(Namespace = "", Order = 4)]
		public string fromDate;

		[MessageBodyMember(Namespace = "", Order = 5)]
		public string fromTime;

		[MessageBodyMember(Namespace = "", Order = 6)]
		public string toDate;

		[MessageBodyMember(Namespace = "", Order = 7)]
		public string toTime;

		[MessageBodyMember(Namespace = "", Order = 8)]
		public int unassignedShiftsFromLeave;

		[MessageBodyMember(Namespace = "", Order = 9)]
		public string lastModified;

		[MessageBodyMember(Namespace = "", Order = 10)]
		public string lastModifiedToTime;

	public wsdlGetDeletedSchedulesRequest()
	{
	}

	public wsdlGetDeletedSchedulesRequest(string apiKey, int sectionId, int employeeId, string badgeNo, string fromDate, string fromTime, string toDate, string toTime, int unassignedShiftsFromLeave, string lastModified, string lastModifiedToTime)
	{
		this.apiKey = apiKey;
		this.sectionId = sectionId;
		this.employeeId = employeeId;
		this.badgeNo = badgeNo;
		this.fromDate = fromDate;
		this.fromTime = fromTime;
		this.toDate = toDate;
		this.toTime = toTime;
		this.unassignedShiftsFromLeave = unassignedShiftsFromLeave;
		this.lastModified = lastModified;
		this.lastModifiedToTime = lastModifiedToTime;
	}
}
