using FatihBank.DTOs;
using MediatR;

namespace FatihBank.Features.ScheduleFeatures.Commands
{
    public class UpdateScheduleCommand : IRequest
    {
		public int Id { get; set; }
		public string name { get; set; }
		public int day_of_holiday { get; set; }
		public DateTime work_start_time { get; set; }
		public DateTime work_leave_time { get; set; }
		public int amount_of_accepted_late { get; set; }
		public double discount_for_late_pre_hour { get; set; }
		public double reward_for_additional_work_per_hour { get; set; }
		public int entered_by { get; set; }
		public DateTime entry_date { get; set; }
		public virtual ICollection<MonthInfoDto>? month_Infos { get; set; }
	}
}