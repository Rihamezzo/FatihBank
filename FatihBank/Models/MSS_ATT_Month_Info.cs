namespace FatihBank.Models
{
    public class MSS_ATT_Month_Info
    {
		public int Id { get; set; }
		public string month { get; set; }
		public int employee_id { get; set; }
		public int? employeeId { get; set; }
		public virtual MSS_DEF_Employees employee { get; set; }
		public int schedule_id { get; set; }
		public int? scheduleId { get; set; }
		public virtual MSS_DEF_Schedule schedule { get; set; }
		public double due_days { get; set; }
		public double due_hours { get; set; }
		public double absent_days { get; set; }
		public double late_hours { get; set; }
		public double excused_days { get; set; }

		public double? add_hours { get; set; }
		public double real_days { get; set; }
		public double real_hours { get; set; }
	}
}
