using FatihBank.DTOs;
using FatihBank.Models;

namespace FatihBank.Repositories
{
    public interface IJournalsRepository
    {
        Task<MSS_DEF_Journals> Add(JournalsDto journalsDto);
        Task Delete(int id);
        Task<PaginationResponse<MSS_DEF_Journals>> ListAll(int page, float pageSize);
        Task Update(int id, JournalsDto journalsDto);
    }

    public interface IJournalsDetailsRepository
    {
        Task<MSS_JOU_Details> Add(JournalsDetailsDto journalsDetailsDto);
        Task Delete(int id);
        Task<PaginationResponse<MSS_JOU_Details>> ListAll(int page, float pageSize);
        Task Update(int id, JournalsDetailsDto journalsDetailsDto);
    }
}