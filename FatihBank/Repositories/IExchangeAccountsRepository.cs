using FatihBank.DTOs;
using FatihBank.Models;

namespace FatihBank.Repositories
{
    public interface IExchangeAccountsRepository
    {
        Task<MSS_DEF_Exchange_Accounts> Add(ExchangeAccountsDto exchangeAccountsDto);
        Task Delete(int id);
        Task<PaginationResponse<MSS_DEF_Exchange_Accounts>> ListAll(int page, float pageSize);
        Task Update(int id, ExchangeAccountsDto exchangeAccountsDto);
    }
}