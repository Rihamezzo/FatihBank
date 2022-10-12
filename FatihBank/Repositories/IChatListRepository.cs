using FatihBank.DTOs;
using FatihBank.Models;

namespace FatihBank.Repositories
{
    public interface IChatListRepository
    {
        Task<MSS_CHT_ChatList> Add(ChatListDto chatListDto);
        Task Delete(int id);
        Task<PaginationResponse<MSS_CHT_ChatList>> ListAll(int page, float pageSize);
        Task Update(int id, ChatListDto chatListDto);
    }
}