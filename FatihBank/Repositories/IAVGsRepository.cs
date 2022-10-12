using FatihBank.DTOs;
using FatihBank.Models;

namespace FatihBank.Repositories
{
    public interface IAVGsRepository
    {
        Task<MSS_DEF_AVGs> Add(AVGsDto aVGsDto);
        Task Delete(int id);
        Task<PaginationResponse<MSS_DEF_AVGs>> ListAll(int page, float pageSize);
        Task Update(int id, AVGsDto aVGsDto);
    }
}