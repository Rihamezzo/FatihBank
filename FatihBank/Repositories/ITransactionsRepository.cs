using FatihBank.DTOs;
using FatihBank.Models;

namespace FatihBank.Repositories
{
    public interface ITransactionsRepository
    {
        Task<MSS_DEF_Transactions> Add(TransactionsDto transactionsDto);
        Task Delete(int id);
        Task<PaginationResponse<MSS_DEF_Transactions>> ListAll(int page, float pageSize);
        Task Update(int id, TransactionsDto transactionsDto);
    }
}