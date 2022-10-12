using MediatR;

namespace FatihBank.Features.CountriesFeatures.Commands
{
    public class DeleteCountriesCommand : IRequest
    {
        public int Id { get; set; }
    }
}