using System.ComponentModel.DataAnnotations.Schema;

namespace FatihBank.Models
{
    public class MSS_N_DEF_Employees
    {
		public MSS_N_DEF_Employees()
		{
			guid = Guid.NewGuid();
		}

		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public Guid guid { get; set; }
		public int Id { get; set; }
		public string first_name { get; set; }
		public string last_name { get; set; }
		public string father_name { get; set; }
		public string mother_name { get; set; }
		public string birth_place { get; set; }
		public string national_id { get; set; }

		public int? customer_id { get; set; }
		public int? customerId { get; set; }
		public virtual MSS_DEF_Customers customer { get; set; }
		//public Enums.Gender gender { get; set; }
		public int? salary_account { get; set; }
		public string personal_photo { get; set; }

		public string finger_id { get; set; }
		public string email { get; set; }
		public string job_position { get; set; }
		public string identity_photo { get; set; }
		public string nationality { get; set; }
		public double salary_per_hour { get; set; }
		public int attendance_schedule { get; set; }
		public int? is_resigned { get; set; }
		public DateTime birthdate { get; set; }
		public string major { get; set; }
		public DateTime enroll_date { get; set; }
		public string address { get; set; }
		public long phone_number { get; set; }
		public long mobile_number { get; set; }
		public int entered_by { get; set; }
		public DateTime entry_date { get; set; }
	}
}
