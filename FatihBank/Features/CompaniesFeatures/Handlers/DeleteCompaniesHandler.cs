using FatihBank.Features.CompaniesFeatures.Commands;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.CompaniesFeatures.Handlers
{
    public class DeleteCompaniesHandler : IRequestHandler<DeleteCompaniesCommand, Unit>
    {
        private readonly ICompaniesRepository companiesRepository;

        public DeleteCompaniesHandler(ICompaniesRepository companiesRepository)
        {
            this.companiesRepository = companiesRepository;
        }

        public async Task<Unit> Handle(DeleteCompaniesCommand request, CancellationToken cancellationToken)
        {
            await companiesRepository.Delete(request.Id);
            return Unit.Value;
        }
    }
}