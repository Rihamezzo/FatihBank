using FatihBank.DTOs;
using FatihBank.Features.CountriesFeatures.Queries;
using FatihBank.Models;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.CountriesFeatures.Handlers
{
    public class ListAllCountriesHandler : IRequestHandler<ListAllCountriesQuery, PaginationResponse<MSS_DEF_Countries>>
    {
        private readonly ICountriesRepository countriesRepository;

        public ListAllCountriesHandler(ICountriesRepository countriesRepository)
        {
            this.countriesRepository = countriesRepository;
        }

        public async Task<PaginationResponse<MSS_DEF_Countries>> Handle(ListAllCountriesQuery request, CancellationToken cancellationToken)
        {
            return await countriesRepository.ListAll(request.page, request.pageSize);
        }
    }
}
