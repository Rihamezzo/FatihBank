using FatihBank.DTOs;
using FatihBank.Features.ExcusesFeatures.Queries;
using FatihBank.Models;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.ExcusesFeatures.Handlers
{
    public class ListAllExcusesHandler : IRequestHandler<ListAllExcusesQuery, PaginationResponse<MSS_ATT_Excuses>>
    {
        private readonly IExcusesRepository excusesRepository;

        public ListAllExcusesHandler(IExcusesRepository excusesRepository)
        {
            this.excusesRepository = excusesRepository;
        }

        public async Task<PaginationResponse<MSS_ATT_Excuses>> Handle(ListAllExcusesQuery request, CancellationToken cancellationToken)
        {
            return await excusesRepository.ListAll(request.page, request.pageSize);
        }
    }
}