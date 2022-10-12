using FatihBank.DTOs;
using FatihBank.Models;

namespace FatihBank.Repositories
{
    public interface ICountriesRepository
    {
        Task<MSS_DEF_Countries> Add(CountriesDto countriesDto);
        Task Delete(int id);
        Task<PaginationResponse<MSS_DEF_Countries>> ListAll(int page, float pageSize);
        Task Update(int id, CountriesDto countriesDto);
    }
}