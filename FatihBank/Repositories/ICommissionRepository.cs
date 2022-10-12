using FatihBank.DTOs;
using FatihBank.Models;

namespace FatihBank.Repositories
{
    public interface ICommissionRepository
    {
        Task<MSS_DEF_Commission> Add(CommissionDto commissionDto);
        Task Delete(int id);
        Task<PaginationResponse<MSS_DEF_Commission>> ListAll(int page, float pageSize);
        Task Update(int id, CommissionDto commissionDto);
    }
}