using MediatR;

namespace FatihBank.Features.OperationsFeatures.Commands
{
    public class DeleteOperationsCommand : IRequest
    {
        public int Id { get; set; }
    }
}