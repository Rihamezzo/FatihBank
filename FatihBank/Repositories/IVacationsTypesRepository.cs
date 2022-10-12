using FatihBank.DTOs;
using FatihBank.Models;

namespace FatihBank.Repositories
{
    public interface IVacationsTypesRepository
    {
        Task<MSS_ATT_VacationsTypes> Add(VacationsTypesDto vacationsTypesDto);
        Task Delete(int id);
        Task<PaginationResponse<MSS_ATT_VacationsTypes>> ListAll(int page, float pageSize);
        Task Update(int id, VacationsTypesDto vacationsTypesDto);
    }
}