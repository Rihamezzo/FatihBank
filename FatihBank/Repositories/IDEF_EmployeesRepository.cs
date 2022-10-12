using FatihBank.DTOs;
using FatihBank.Models;

namespace FatihBank.Repositories
{
    public interface IDEF_EmployeesRepository
    {
        Task<MSS_N_DEF_Employees> Add(DEF_EmployeesDto dEF_EmployeesDto);
        Task Delete(int id);
        Task<PaginationResponse<MSS_N_DEF_Employees>> ListAll(int page, float pageSize);
        Task Update(int id, DEF_EmployeesDto dEF_EmployeesDto);
    }
}