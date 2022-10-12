using FatihBank.DTOs;
using FatihBank.Models;

namespace FatihBank.Repositories
{
    public interface IDailyAttendanceRepository
    {
        Task<MSS_ATT_Daily_Attendance> Add(DailyAttendanceDto dailyAttendanceDto);
        Task Delete(int id);
        Task<PaginationResponse<MSS_ATT_Daily_Attendance>> ListAll(int page, float pageSize);
        Task Update(int id, DailyAttendanceDto dailyAttendanceDto);
    }
}