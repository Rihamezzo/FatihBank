using FatihBank.DTOs;
using FatihBank.Models;

namespace FatihBank.Repositories
{
    public interface IPricesRepository
    {
        Task<MSS_DEF_Prices> Add(PricesDto pricesDto);
        Task Delete(int id);
        Task<PaginationResponse<MSS_DEF_Prices>> ListAll(int page, float pageSize);
        Task Update(int id, PricesDto pricesDto);
    }
}