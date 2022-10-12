using MediatR;

namespace FatihBank.Features.ChecksFeatures.Commands
{
    public class DeleteChecksCommand : IRequest
    {
        public int Id { get; set; }
    }
}
