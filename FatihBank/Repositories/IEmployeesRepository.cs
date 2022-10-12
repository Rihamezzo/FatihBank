using FatihBank.DTOs;
using FatihBank.Models;

namespace FatihBank.Repositories
{
    public interface IEmployeesRepository
    {
        Task<MSS_DEF_Employees> Add(EmployeesDto employeesDto);
        Task Delete(int id);
        Task<PaginationResponse<MSS_DEF_Employees>> ListAll(int page, float pageSize);
        Task Update(int id, EmployeesDto employeesDto);
    }
}