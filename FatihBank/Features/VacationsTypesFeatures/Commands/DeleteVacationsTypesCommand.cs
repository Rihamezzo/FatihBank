using MediatR;

namespace FatihBank.Features.VacationsTypesFeatures.Commands
{
    public class DeleteVacationsTypesCommand : IRequest
    {
        public int Id { get; set; }
    }
}