using MediatR;

namespace FatihBank.Features.ActionTypesFeatures.Commands
{
    public class DeleteActionTypesCommand : IRequest
    {
        public int Id { get; set; }
    }
}