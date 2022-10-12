using FatihBank.DTOs;
using FatihBank.Models;

namespace FatihBank.Repositories
{
    public interface ICurrenciesRepository
    {
        Task<MSS_DEF_Currencies> Add(CurrenciesDto currenciesDto);
        Task Delete(int id);
        Task<PaginationResponse<MSS_DEF_Currencies>> ListAll(int page, float pageSize);
        Task Update(int id, CurrenciesDto currenciesDto);
    }
}