namespace FatihBank.Models
{
    public class MSS_ATT_Vacations
    {
        public int Id { get; set; }
        public int employee_id { get; set; }
        public int? employeeId { get; set; }
        public virtual MSS_DEF_Employees employee { get; set; }
        public int vacation_type { get; set; }
        public int? vacationTypeId { get; set; }
        public virtual MSS_ATT_VacationsTypes vacationsType { get; set; }
        public int no_of_days { get; set; }
        public DateTime request_date { get; set; }

        public DateTime start_date { get; set; }
        public DateTime end_date { get; set; }
        public int status { get; set; }
        public int processed_by { get; set; }
        public DateTime process_date { get; set; }

        public string notes { get; set; }
    }
}
