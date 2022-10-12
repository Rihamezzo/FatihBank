using FatihBank.DTOs;
using FatihBank.Features.VacationsTypesFeatures.Queries;
using FatihBank.Models;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.VacationsTypesFeatures.Handlers
{
    public class ListAllVacationsTypesHandler : IRequestHandler<ListAllVacationsTypesQuery, PaginationResponse<MSS_ATT_VacationsTypes>>
    {
        private readonly IVacationsTypesRepository vacationsTypesRepository;

        public ListAllVacationsTypesHandler(IVacationsTypesRepository vacationsTypesRepository)
        {
            this.vacationsTypesRepository = vacationsTypesRepository;
        }

        public async Task<PaginationResponse<MSS_ATT_VacationsTypes>> Handle(ListAllVacationsTypesQuery request, CancellationToken cancellationToken)
        {
            return await vacationsTypesRepository.ListAll(request.page, request.pageSize);
        }
    }
}