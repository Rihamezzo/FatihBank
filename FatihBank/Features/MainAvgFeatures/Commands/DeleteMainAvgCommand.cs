using MediatR;

namespace FatihBank.Features.MainAvgFeatures.Commands
{
    public class DeleteMainAvgCommand : IRequest
    {
        public int Id { get; set; }
    }
}