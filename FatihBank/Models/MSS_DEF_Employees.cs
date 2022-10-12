using FatihBank.DTOs;

namespace FatihBank.Models
{
    public class MSS_DEF_Employees
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string last_name { get; set; }
        public string nationality { get; set; }
        public DateTime? birthdate { get; set; }
        public long? mobile { get; set; }
        public long? phone { get; set; }
        public string passport { get; set; }
        public string idphoto { get; set; }
        public string address { get; set; }
        public string notes { get; set; }
    }
}
