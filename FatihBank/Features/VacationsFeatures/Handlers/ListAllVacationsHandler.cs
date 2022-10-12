using FatihBank.DTOs;
using FatihBank.Features.VacationsFeatures.Queries;
using FatihBank.Models;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.VacationsFeatures.Handlers
{
    public class ListAllVacationsHandler : IRequestHandler<ListAllVacationsQuery, PaginationResponse<MSS_ATT_Vacations>>
    {
        private readonly IVacationsRepository vacationsRepository;

        public ListAllVacationsHandler(IVacationsRepository vacationsRepository)
        {
            this.vacationsRepository = vacationsRepository;
        }

        public async Task<PaginationResponse<MSS_ATT_Vacations>> Handle(ListAllVacationsQuery request, CancellationToken cancellationToken)
        {
            return await vacationsRepository.ListAll(request.page, request.pageSize);
        }
    }
}