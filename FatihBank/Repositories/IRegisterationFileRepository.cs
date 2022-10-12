using FatihBank.DTOs;
using FatihBank.Models;

namespace FatihBank.Repositories
{
    public interface IRegisterationFileRepository
    {
        Task<MSS_INF_RegisterationFile> Add(RegisterationFileDto registerationFileDto);
        Task Delete(int id);
        Task<PaginationResponse<MSS_INF_RegisterationFile>> ListAll(int page, float pageSize);
        Task Update(int id, RegisterationFileDto registerationFileDto);
    }
}