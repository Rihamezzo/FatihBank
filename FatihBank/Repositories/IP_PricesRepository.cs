using FatihBank.DTOs;
using FatihBank.Models;

namespace FatihBank.Repositories
{
    public interface IP_PricesRepository
    {
        Task<MSS_DEF_P_Prices> Add(P_PricesDto p_PricesDto);
        Task Delete(int id);
        Task<PaginationResponse<MSS_DEF_P_Prices>> ListAll(int page, float pageSize);
        Task Update(int id, P_PricesDto p_PricesDto);
    }
}