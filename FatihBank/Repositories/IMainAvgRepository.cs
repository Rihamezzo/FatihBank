using FatihBank.DTOs;
using FatihBank.Models;

namespace FatihBank.Repositories
{
    public interface IMainAvgRepository
    {
        Task<MSS_AVG_MainAvg> Add(MainAvgDto mainAvgDto);
        Task Delete(int id);
        Task<PaginationResponse<MSS_AVG_MainAvg>> ListAll(int page, float pageSize);
        Task Update(int id, MainAvgDto mainAvgDto);
    }
}