using FatihBank.DTOs;
using FatihBank.Models;
using MediatR;

namespace FatihBank.Features.DailyAttendanceFeatures.Queries
{
    public class ListAllDailyAttendanceQuery : IRequest<PaginationResponse<MSS_ATT_Daily_Attendance>>
    {
        public int page { get; set; }
        public int pageSize { get; set; }

        public ListAllDailyAttendanceQuery(int page, int pageSize)
        {
            this.page = page;
            this.pageSize = pageSize;
        }
    }
}
