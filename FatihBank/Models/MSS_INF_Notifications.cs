namespace FatihBank.Models
{
    public class MSS_INF_Notifications
    {
        public int Id { get; set; }
        public int from_id { get; set; }
        public int? fromId { get; set; }
        public virtual MSS_DEF_Users from { get; set; }
        public int to_id { get; set; }
        public int? toId { get; set; }
        public virtual MSS_DEF_Users to { get; set; }
        public int object_id { get; set; }
        public int action_id { get; set; }
        public string obj { get; set; }
        public string action { get; set; }
        public bool is_read { get; set; }
        public DateTime created_at { get; set; }
        public DateTime? last_update { get; set; }
    }
}
