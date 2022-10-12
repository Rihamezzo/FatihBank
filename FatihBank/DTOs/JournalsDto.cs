using FatihBank.Models;

namespace FatihBank.DTOs
{
    public class JournalsDto
    {
        public int? Id { get; set; }
        public JournalStatus status { get; set; }
        public string code { get; set; }
        public string notes { get; set; }
        public DateTime date { get; set; }
        public double total_amount { get; set; }
        public int entered_by { get; set; }

        public virtual ICollection<JournalsDetailsDto>? details { get; set; }
    }

    public class JournalsDetailsDto
    {
        public int? Id { get; set; }
        public int? journalId { get; set; }

        public int? accountId { get; set; }
        public int? customerId { get; set; }
        public double? currencyAmount { get; set; }
        public int? currencyId { get; set; }

        public double? inAmount { get; set; }
        public double? outAmount { get; set; }


    }
   
}
