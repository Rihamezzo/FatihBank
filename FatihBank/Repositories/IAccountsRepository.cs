using FatihBank.DTOs;
using FatihBank.Models;

namespace FatihBank.Repositories
{
    public interface IAccountsRepository
    {
        Task<MSS_DEF_Accounts> Add(AccountsDto accountsDto);
        Task Delete(int id);
        Task<PaginationResponse<MSS_DEF_Accounts>> ListAll(int page, float pageSize);
        Task Update(int id, AccountsDto accountsDto);
    }
}