namespace FatihBank.Models
{
    public class MSS_DEF_Modules
    {
        public int Id { get; set; }
        public string name { get; set; }
        public int? group { get; set; }
        public virtual ICollection<MSS_DEF_Permissions> permissions { get; set; }
    }
}
