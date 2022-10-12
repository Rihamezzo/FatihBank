using FatihBank.DTOs;
using FatihBank.Models;

namespace FatihBank.Repositories
{
    public interface IExcusesTypesRepository
    {
        Task<MSS_ATT_ExcusesTypes> Add(ExcusesTypesDto excusesTypesDto);
        Task Delete(int id);
        Task<PaginationResponse<MSS_ATT_ExcusesTypes>> ListAll(int page, float pageSize);
        Task Update(int id, ExcusesTypesDto excusesTypesDto);
    }
}