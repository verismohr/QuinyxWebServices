using System;
using System.Xml.Serialization;

namespace QuinyxWebServices;

[Serializable]
[SoapType(Namespace = "https://api.quinyx.com/soap/FlexForce")]
public class ScheduleTask
{
	private int idField;

	private int scheduleIdField;

	private int categoryIdField;

	private string begTimeField;

	private string endTimeField;

	private DateTime tsField;

	private string nameField;

	private int onCallField;

	public int id
	{
		get
		{
			return idField;
		}
		set
		{
			idField = value;
		}
	}

	public int scheduleId
	{
		get
		{
			return scheduleIdField;
		}
		set
		{
			scheduleIdField = value;
		}
	}

	public int categoryId
	{
		get
		{
			return categoryIdField;
		}
		set
		{
			categoryIdField = value;
		}
	}

	public string begTime
	{
		get
		{
			return begTimeField;
		}
		set
		{
			begTimeField = value;
		}
	}

	public string endTime
	{
		get
		{
			return endTimeField;
		}
		set
		{
			endTimeField = value;
		}
	}

	public DateTime ts
	{
		get
		{
			return tsField;
		}
		set
		{
			tsField = value;
		}
	}

	public string name
	{
		get
		{
			return nameField;
		}
		set
		{
			nameField = value;
		}
	}

	public int onCall
	{
		get
		{
			return onCallField;
		}
		set
		{
			onCallField = value;
		}
	}
}
