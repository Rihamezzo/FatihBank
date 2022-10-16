using MediatR;
using System.ComponentModel.DataAnnotations.Schema;

namespace FatihBank.Features.RewardsFeatures.Commands
{
    public class UpdateRewardsCommand : IRequest
    {
		public int Id { get; set; }
		public int employee_id { get; set; }
		public int? employeeId { get; set; }
		[Column(TypeName = "Date")]
		public DateTime date { get; set; }
		public double reward { get; set; }
		public string reason { get; set; }
		public bool on_salary { get; set; }
		public int entered_by { get; set; }
		public DateTime entry_date { get; set; }
	}
}