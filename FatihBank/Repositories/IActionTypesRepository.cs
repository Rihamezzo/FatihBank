using FatihBank.DTOs;
using FatihBank.Models;

namespace FatihBank.Repositories
{
    public interface IActionTypesRepository
    {
        Task<MSS_INF_Action_Types> Add(ActionTypesDto actionTypesDto);
        Task Delete(int id);
        Task<PaginationResponse<MSS_INF_Action_Types>> ListAll(int page, float pageSize);
        Task Update(int id, ActionTypesDto actionTypesDto);
    }
}