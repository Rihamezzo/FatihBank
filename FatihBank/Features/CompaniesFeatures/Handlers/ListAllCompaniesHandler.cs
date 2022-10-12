using FatihBank.DTOs;
using FatihBank.Features.CompaniesFeatures.Queries;
using FatihBank.Models;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.CompaniesFeatures.Handlers
{
    public class ListAllCompaniesHandler : IRequestHandler<ListAllCompaniesQuery, PaginationResponse<MSS_TRS_Companies>>
    {
        private readonly ICompaniesRepository companiesRepository;

        public ListAllCompaniesHandler(ICompaniesRepository companiesRepository)
        {
            this.companiesRepository = companiesRepository;
        }

        public async Task<PaginationResponse<MSS_TRS_Companies>> Handle(ListAllCompaniesQuery request, CancellationToken cancellationToken)
        {
            return await companiesRepository.ListAll(request.page, request.pageSize);
        }
    }
}