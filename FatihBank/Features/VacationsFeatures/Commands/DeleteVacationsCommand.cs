using MediatR;

namespace FatihBank.Features.VacationsFeatures.Commands
{
    public class DeleteVacationsCommand : IRequest
    {
        public int Id { get; set; }
    }
}