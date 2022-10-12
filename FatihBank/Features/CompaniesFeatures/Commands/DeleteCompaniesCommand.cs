using MediatR;

namespace FatihBank.Features.CompaniesFeatures.Commands
{
    public class DeleteCompaniesCommand : IRequest
    {
        public int Id { get; set; }
    }
}