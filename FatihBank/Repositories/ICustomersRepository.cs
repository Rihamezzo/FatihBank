using FatihBank.DTOs;
using FatihBank.Models;

namespace FatihBank.Repositories
{
    public interface ICustomersRepository
    {
        Task<PaginationResponse<MSS_DEF_Customers>> ListAll(int page, float pageSize);
        Task<MSS_DEF_Customers> Add(CustomersDto customersDto);
        Task Delete(int id);
        Task Update(int id, CustomersDto customersDto);
    }
}