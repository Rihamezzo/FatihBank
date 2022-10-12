using FatihBank.DTOs;
using FatihBank.Models;

namespace FatihBank.Repositories
{
    public interface IAvgRepository
    {
        Task<MSS_FIN_Avg> Add(AvgDto avgDto);
        Task Delete(int id);
        Task<PaginationResponse<MSS_FIN_Avg>> ListAll(int page, float pageSize);
        Task Update(int id, AvgDto avgDto);
    }
}