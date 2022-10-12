using MediatR;

namespace FatihBank.Features.MSS_DEF_CommissionFeatures.Commands
{
    public class DeleteCommissionCommand : IRequest
    {
        public int Id { get; set; }
    }
}
