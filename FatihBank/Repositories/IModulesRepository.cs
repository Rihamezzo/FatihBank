using FatihBank.DTOs;
using FatihBank.Models;

namespace FatihBank.Repositories
{
    public interface IModulesRepository
    {
        Task<MSS_DEF_Modules> Add(ModulesDto modulesDto);
        Task Delete(int id);
        Task<PaginationResponse<MSS_DEF_Modules>> ListAll(int page, float pageSize);
        Task Update(int id, ModulesDto modulesDto);
    }
}