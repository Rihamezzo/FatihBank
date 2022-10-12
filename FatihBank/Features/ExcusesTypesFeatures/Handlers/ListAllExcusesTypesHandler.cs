using FatihBank.DTOs;
using FatihBank.Features.ExcusesTypesFeatures.Queries;
using FatihBank.Models;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.ExcusesTypesFeatures.Handlers
{
    public class ListAllExcusesTypesHandler : IRequestHandler<ListAllExcusesTypesQuery, PaginationResponse<MSS_ATT_ExcusesTypes>>
    {
        private readonly IExcusesTypesRepository excusesTypesRepository;

        public ListAllExcusesTypesHandler(IExcusesTypesRepository excusesTypesRepository)
        {
            this.excusesTypesRepository = excusesTypesRepository;
        }

        public async Task<PaginationResponse<MSS_ATT_ExcusesTypes>> Handle(ListAllExcusesTypesQuery request, CancellationToken cancellationToken)
        {
            return await excusesTypesRepository.ListAll(request.page, request.pageSize);
        }
    }
}