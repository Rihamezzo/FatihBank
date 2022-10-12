namespace FatihBank.Models
{
    public class MSS_ATT_VacationsTypes
    {
        public int Id { get; set; }
        public string name { get; set; }
        public virtual ICollection<MSS_ATT_Vacations> vacations { get; set; }
    }
}
