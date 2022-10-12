using FatihBank.DTOs;
using FatihBank.Models;

namespace FatihBank.Repositories
{
    public interface IVacationsRepository
    {
        Task<MSS_ATT_Vacations> Add(VacationsDto vacationsDto);
        Task Delete(int id);
        Task<PaginationResponse<MSS_ATT_Vacations>> ListAll(int page, float pageSize);
        Task Update(int id, VacationsDto vacationsDto);
    }
}