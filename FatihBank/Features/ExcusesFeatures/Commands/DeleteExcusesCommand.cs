using MediatR;

namespace FatihBank.Features.ExcusesFeatures.Commands
{
    public class DeleteExcusesCommand : IRequest
    {
        public int Id { get; set; }
    }
}