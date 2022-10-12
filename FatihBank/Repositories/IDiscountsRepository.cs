using FatihBank.DTOs;
using FatihBank.Models;

namespace FatihBank.Repositories
{
    public interface IDiscountsRepository
    {
        Task<MSS_ATT_Discounts> Add(DiscountsDto discountsDto);
        Task Delete(int id);
        Task<PaginationResponse<MSS_ATT_Discounts>> ListAll(int page, float pageSize);
        Task Update(int id, DiscountsDto discountsDto);
    }
}