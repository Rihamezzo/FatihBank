using MediatR;

namespace FatihBank.Features.AvgFeatures.Commands
{
    public class DeleteAvgCommand : IRequest
    {
        public int Id { get; set; }
    }
}