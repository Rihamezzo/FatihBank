using System.ComponentModel.DataAnnotations.Schema;

namespace FatihBank.Models
{
    public class MSS_ATT_Discounts
    {
		public int Id { get; set; }
		public int employee_id { get; set; }
		public int? employeeId { get; set; }
		public virtual MSS_DEF_Employees employee { get; set; }

		[Column(TypeName = "Date")]
		public DateTime date { get; set; }
		public double discount { get; set; }
		public string reason { get; set; }
		public bool on_salary { get; set; }
		public int entered_by { get; set; }
		public DateTime entry_date { get; set; }
	}
}
