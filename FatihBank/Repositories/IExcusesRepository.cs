using FatihBank.DTOs;
using FatihBank.Models;

namespace FatihBank.Repositories
{
    public interface IExcusesRepository
    {
        Task<MSS_ATT_Excuses> Add(ExcusesDto excusesDto);
        Task Delete(int id);
        Task<PaginationResponse<MSS_ATT_Excuses>> ListAll(int page, float pageSize);
        Task Update(int id, ExcusesDto excusesDto);
    }
}