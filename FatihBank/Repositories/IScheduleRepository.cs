using FatihBank.DTOs;
using FatihBank.Models;

namespace FatihBank.Repositories
{
    public interface IScheduleRepository
    {
        Task<MSS_DEF_Schedule> Add(ScheduleDto scheduleDto);
        Task Delete(int id);
        Task<PaginationResponse<MSS_DEF_Schedule>> ListAll(int page, float pageSize);
        Task Update(int id, ScheduleDto scheduleDto);
    }
}