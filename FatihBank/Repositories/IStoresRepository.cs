using FatihBank.DTOs;
using FatihBank.Models;

namespace FatihBank.Repositories
{
    public interface IStoresRepository
    {
        Task<MSS_DEF_Stores> Add(StoresDto storesDto);
        Task Delete(int id);
        Task<PaginationResponse<MSS_DEF_Stores>> ListAll(int page, float pageSize);
        Task Update(int id, StoresDto storesDto);
    }
}