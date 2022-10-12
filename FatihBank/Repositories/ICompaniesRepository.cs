using FatihBank.DTOs;
using FatihBank.Models;

namespace FatihBank.Repositories
{
    public interface ICompaniesRepository
    {
        Task<MSS_TRS_Companies> Add(CompaniesDto companiesDto);
        Task Delete(int id);
        Task<PaginationResponse<MSS_TRS_Companies>> ListAll(int page, float pageSize);
        Task Update(int id, CompaniesDto companiesDto);
    }
}