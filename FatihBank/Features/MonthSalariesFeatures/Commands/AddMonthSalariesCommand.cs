using FatihBank.Models;
using MediatR;

namespace FatihBank.Features.MonthSalariesFeatures.Commands
{
    public class AddMonthSalariesCommand : IRequest<MSS_ATT_Month_Salaries>
    {
		public int? Id { get; set; }
		public int employee_id { get; set; }
		public int? employeeId { get; set; }
		public string month { get; set; }
		public int attended_days { get; set; }
		public DateTime? from_date { get; set; }
		public DateTime? to_date { get; set; }
		public double net_salary { get; set; }
		public double basic_salary { get; set; }
		public double discount_amount { get; set; }
		public double added_amount { get; set; }
		public bool is_paid { get; set; }
	}
}