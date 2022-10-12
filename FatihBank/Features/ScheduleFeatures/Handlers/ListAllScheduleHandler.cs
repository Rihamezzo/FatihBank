using FatihBank.DTOs;
using FatihBank.Features.ScheduleFeatures.Queries;
using FatihBank.Models;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.ScheduleFeatures.Handlers
{
    public class ListAllScheduleHandler : IRequestHandler<ListAllScheduleQuery, PaginationResponse<MSS_DEF_Schedule>>
    {
        private readonly IScheduleRepository scheduleRepository;

        public ListAllScheduleHandler(IScheduleRepository scheduleRepository)
        {
            this.scheduleRepository = scheduleRepository;
        }

        public async Task<PaginationResponse<MSS_DEF_Schedule>> Handle(ListAllScheduleQuery request, CancellationToken cancellationToken)
        {
            return await scheduleRepository.ListAll(request.page, request.pageSize);
        }
    }
}