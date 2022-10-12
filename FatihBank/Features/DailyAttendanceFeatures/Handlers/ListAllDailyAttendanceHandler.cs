using FatihBank.DTOs;
using FatihBank.Features.DailyAttendanceFeatures.Queries;
using FatihBank.Models;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.DailyAttendanceFeatures.Handlers
{
    public class ListAllDailyAttendanceHandler : IRequestHandler<ListAllDailyAttendanceQuery, PaginationResponse<MSS_ATT_Daily_Attendance>>
    {
        private readonly IDailyAttendanceRepository dailyAttendanceRepository;

        public ListAllDailyAttendanceHandler(IDailyAttendanceRepository dailyAttendanceRepository)
        {
            this.dailyAttendanceRepository = dailyAttendanceRepository;
        }

        public async Task<PaginationResponse<MSS_ATT_Daily_Attendance>> Handle(ListAllDailyAttendanceQuery request, CancellationToken cancellationToken)
        {
            return await dailyAttendanceRepository.ListAll(request.page, request.pageSize);
        }
    }
}