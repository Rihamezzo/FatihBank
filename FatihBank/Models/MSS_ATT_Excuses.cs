namespace FatihBank.Models
{
    public class MSS_ATT_Excuses
    {
        public int Id { get; set; }
        public int employee_id { get; set; }
        public int? employeeId { get; set; }
        public virtual MSS_DEF_Employees employee { get; set; }
        public DateTime request_date { get; set; }

        public DateTime excuses_date { get; set; }
        public int excuses_type { get; set; }
        public int? excusesTypeId { get; set; }
        public virtual MSS_ATT_ExcusesTypes excusesType { get; set; }

        public DateTime leave_time { get; set; }
        public DateTime return_time { get; set; }
        public DateTime actual_return_time { get; set; }
        public int status { get; set; }
        public int processed_by { get; set; }
        public DateTime process_date { get; set; }

        public string notes { get; set; }
    }
}
