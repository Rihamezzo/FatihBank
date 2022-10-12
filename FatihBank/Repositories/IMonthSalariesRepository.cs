using FatihBank.DTOs;
using FatihBank.Models;

namespace FatihBank.Repositories
{
    public interface IMonthSalariesRepository
    {
        Task<MSS_ATT_Month_Salaries> Add(MonthSalariesDto monthSalariesDto);
        Task Delete(int id);
        Task<PaginationResponse<MSS_ATT_Month_Salaries>> ListAll(int page, float pageSize);
        Task Update(int id, MonthSalariesDto monthSalariesDto);
    }
}