using FatihBank.DTOs;
using FatihBank.Models;

namespace FatihBank.Repositories
{
    public interface IAddToMonthlyListRepository
    {
        Task<MSS_CUS_Add_To_Monthly_List> Add(AddToMonthlyListDto addToMonthlyListDto);
        Task Delete(int id);
        Task<PaginationResponse<MSS_CUS_Add_To_Monthly_List>> ListAll(int page, float pageSize);
        Task Update(int id, AddToMonthlyListDto addToMonthlyListDto);
    }
}