namespace FatihBank.Models
{
    public class MSS_FAV_FavAccounts
    {
        public int Id { get; set; }
        public int account_id { get; set; }
        public int? accountId { get; set; }
        public virtual MSS_DEF_Accounts account { get; set; }
    }
}
