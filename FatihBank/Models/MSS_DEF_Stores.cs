namespace FatihBank.Models
{
    public class MSS_DEF_Stores
    {
        public int Id { get; set; }
        public string name { get; set; }
        public int country_id { get; set; }
        public int? countryId { get; set; }
        public virtual MSS_DEF_Countries country { get; set; }
    }
}
