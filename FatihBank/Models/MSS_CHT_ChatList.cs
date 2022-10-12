namespace FatihBank.Models
{
    public class MSS_CHT_ChatList
    {
        public int Id { get; set; }
        public int s_1 { get; set; }
        public int? user1Id { get; set; }
        public virtual MSS_DEF_Users user1 { get; set; }
        public int s_2 { get; set; }
        public int? user2Id { get; set; }
        public virtual MSS_DEF_Users user2 { get; set; }
        public DateTime created_at { get; set; }
    }
}
