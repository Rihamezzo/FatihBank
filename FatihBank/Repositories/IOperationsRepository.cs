using FatihBank.DTOs;
using FatihBank.Models;

namespace FatihBank.Repositories
{
    public interface IOperationsRepository
    {
        Task<MSS_CAS_Operations> Add(OperationsDto operationsDto);
        Task Delete(int id);
        Task<PaginationResponse<MSS_CAS_Operations>> ListAll(int page, float pageSize);
        Task Update(int id, OperationsDto operationsDto);
    }
}