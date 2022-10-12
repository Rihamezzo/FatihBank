using FatihBank.DTOs;
using FatihBank.Models;

namespace FatihBank.Repositories
{
    public interface IChecksRepository
    {
        Task<MSS_ACC_Checks> Add(ChecksDto checksDto);
        Task Delete(int id);
        Task<PaginationResponse<MSS_ACC_Checks>> ListAll(int page, float pageSize);
        Task Update(int id, ChecksDto checksDto);
    }
}