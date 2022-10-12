using FatihBank.Models;
using MediatR;
using System.ComponentModel.DataAnnotations.Schema;

namespace FatihBank.Features.DailyAttendanceFeatures.Commands
{
    public class AddDailyAttendanceCommand : IRequest<MSS_ATT_Daily_Attendance>
    {
		public int? Id { get; set; }
		[Column(TypeName = "Date")]
		public DateTime date { get; set; }
		public int employee_id { get; set; }
		public int? employeeId { get; set; }
		public DateTime in_come_time { get; set; }
		public DateTime leave_time { get; set; }
		public int is_absent { get; set; }
		public int is_excused { get; set; }
		public int schedule_id { get; set; }
		public int? scheduleId { get; set; }
		public int late_minutes { get; set; }

		public int? additional_minutes { get; set; }
	}
}
