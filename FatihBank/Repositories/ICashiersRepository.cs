using FatihBank.DTOs;
using FatihBank.Models;

namespace FatihBank.Repositories
{
    public interface ICashiersRepository
    {
        Task<MSS_DEF_Cashiers> Add(CashiersDto cashiersDto);
        Task Delete(int id);
        Task<PaginationResponse<MSS_DEF_Cashiers>> ListAll(int page, float pageSize);
        Task Update(int id, CashiersDto cashiersDto);
    }
}