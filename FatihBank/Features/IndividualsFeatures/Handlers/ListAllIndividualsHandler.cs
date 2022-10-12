using FatihBank.DTOs;
using FatihBank.Features.IndividualsFeatures.Queries;
using FatihBank.Models;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.IndividualsFeatures.Handlers
{
    public class ListAllIndividualsHandler : IRequestHandler<ListAllIndividualsQuery, PaginationResponse<MSS_TRS_Individuals>>
    {
        private readonly IIndividualsRepository individualsRepository;

        public ListAllIndividualsHandler(IIndividualsRepository individualsRepository)
        {
            this.individualsRepository = individualsRepository;
        }

        public async Task<PaginationResponse<MSS_TRS_Individuals>> Handle(ListAllIndividualsQuery request, CancellationToken cancellationToken)
        {
            return await individualsRepository.ListAll(request.page, request.pageSize);
        }
    }
}