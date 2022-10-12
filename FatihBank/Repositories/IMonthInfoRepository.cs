using FatihBank.DTOs;
using FatihBank.Models;

namespace FatihBank.Repositories
{
    public interface IMonthInfoRepository
    {
        Task<MSS_ATT_Month_Info> Add(MonthInfoDto monthInfoDto);
        Task Delete(int id);
        Task<PaginationResponse<MSS_ATT_Month_Info>> ListAll(int page, float pageSize);
        Task Update(int id, MonthInfoDto monthInfoDto);
    }
}