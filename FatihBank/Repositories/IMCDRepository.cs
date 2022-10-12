using FatihBank.DTOs;
using FatihBank.Models;

namespace FatihBank.Repositories
{
    public interface IMCDRepository
    {
        Task<MSS_DEF_MCD> Add(MCDDto mCDDto);
        Task Delete(int id);
        Task<PaginationResponse<MSS_DEF_MCD>> ListAll(int page, float pageSize);
        Task Update(int id, MCDDto mCDDto);
    }
}