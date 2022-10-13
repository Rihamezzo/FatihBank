namespace FatihBank.Models
{
    public class MSS_DEF_SMS
    {
        public int Id { get; set; }
        public int sent_by { get; set; }
        public int? sent_by_userId { get; set; }
        public virtual MSS_DEF_Users sent_by_user { get; set; }
        public int sent_to_customer { get; set; }
        public int? sentToCustomerId { get; set; }
        public virtual MSS_DEF_Customers sentToCustomer { get; set; }
        public long phone_number { get; set; }
        public DateTime date { get; set; }
        public string sms { get; set; }
        public string status { get; set; }
        public int type { get; set; }
    }
}
