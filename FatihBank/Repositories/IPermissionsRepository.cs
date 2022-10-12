using FatihBank.DTOs;
using FatihBank.Models;

namespace FatihBank.Repositories
{
    public interface IPermissionsRepository
    {
        Task<MSS_DEF_Permissions> Add(PermissionsDto permissionsDto);
        Task Delete(int id);
        Task<PaginationResponse<MSS_DEF_Permissions>> ListAll(int page, float pageSize);
        Task Update(int id, PermissionsDto permissionsDto);
    }
}