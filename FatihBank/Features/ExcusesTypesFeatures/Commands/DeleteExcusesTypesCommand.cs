using MediatR;

namespace FatihBank.Features.ExcusesTypesFeatures.Commands
{
    public class DeleteExcusesTypesCommand : IRequest
    {
        public int Id { get; set; }
    }
}