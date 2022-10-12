
using FatihBank.Models;
using MediatR;

namespace FatihBank.Features.JournalsFeatures.Commands
{
    public class AddJournalsCommand : IRequest<MSS_DEF_Journals>
    {
        public int? Id { get; set; }
        public JournalStatus status { get; set; }
        public string code { get; set; }
        public string notes { get; set; }
        public DateTime date { get; set; }
        public double total_amount { get; set; }
        public int entered_by { get; set; }

        public virtual ICollection<MSS_JOU_Details>? details { get; set; }
    }

    public class AddJournalsDetailsCommand : IRequest<MSS_JOU_Details>
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