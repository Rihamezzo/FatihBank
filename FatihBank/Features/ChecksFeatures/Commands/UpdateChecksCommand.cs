using MediatR;

namespace FatihBank.Features.ChecksFeatures.Commands
{
    public class UpdateChecksCommand : IRequest
    {
        public int Id { get; set; }
        public int account_id { get; set; }
        public int? accountId { get; set; }
        public string notes { get; set; }
        public DateTime date { get; set; }

        public double amount { get; set; }

        public int entered_by { get; set; }
    }
}
