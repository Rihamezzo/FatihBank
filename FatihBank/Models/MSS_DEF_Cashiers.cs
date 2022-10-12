using System.ComponentModel.DataAnnotations;

namespace FatihBank.Models
{
    public class MSS_DEF_Cashiers
    {
        public int Id { get; set; }
        public int currency_id { get; set; }
        public int? currencyId { get; set; }
        public virtual MSS_DEF_Currencies currency { get; set; }
        public string name { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime? date { get; set; }
        public double amount { get; set; }
        public string notes { get; set; }
        public int entered_by { get; set; }
        public DateTime entery_date { get; set; }
        public virtual ICollection<MSS_CAS_Operations> operations { get; set; }
    }
}
