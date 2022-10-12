using FatihBank.DTOs;
using FatihBank.Models;

namespace FatihBank.Repositories
{
    public interface IOrdersRepository
    {
        Task<MSS_DEF_Orders> Add(OrdersDto ordersDto);
        Task Delete(int id);
        Task<PaginationResponse<MSS_DEF_Orders>> ListAll(int page, float pageSize);
        Task Update(int id, OrdersDto ordersDto);
    }
}