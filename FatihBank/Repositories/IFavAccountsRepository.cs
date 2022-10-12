using FatihBank.DTOs;
using FatihBank.Models;

namespace FatihBank.Repositories
{
    public interface IFavAccountsRepository
    {
        Task<MSS_FAV_FavAccounts> Add(FavAccountsDto favAccountsDto);
        Task Delete(int id);
        Task<PaginationResponse<MSS_FAV_FavAccounts>> ListAll(int page, float pageSize);
        Task Update(int id, FavAccountsDto favAccountsDto);
    }
}