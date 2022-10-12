namespace FatihBank.Models
{
    public class MSS_DEF_Permissions
    {
        public int Id { get; set; }
        public int module_id { get; set; }
        public int? module1Id { get; set; }
        public virtual MSS_DEF_Modules module1 { get; set; }
        public int user_id { get; set; }
        public int? userId { get; set; }
        public virtual MSS_DEF_Users user { get; set; }
        public int type { get; set; }

        public string module { get; set; }
    }
}
