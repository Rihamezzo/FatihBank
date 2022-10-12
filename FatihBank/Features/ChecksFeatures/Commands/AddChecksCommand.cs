using MediatR;
using FatihBank.Models;

namespace FatihBank.Features.ChecksFeatures.Commands
{
    public class AddChecksCommand : IRequest<MSS_ACC_Checks>
    {
        public int? Id { get; set; }
        public int account_id { get; set; }
        public int? accountId { get; set; }
        public string notes { get; set; }
        public DateTime date { get; set; }

        public double amount { get; set; }

        public int entered_by { get; set; }
    }
}
