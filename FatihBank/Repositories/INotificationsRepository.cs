using FatihBank.DTOs;
using FatihBank.Models;

namespace FatihBank.Repositories
{
    public interface INotificationsRepository
    {
        Task<MSS_INF_Notifications> Add(NotificationsDto notificationsDto);
        Task Delete(int id);
        Task<PaginationResponse<MSS_INF_Notifications>> ListAll(int page, float pageSize);
        Task Update(int id, NotificationsDto notificationsDto);
    }
}