using FatihBank.DTOs;
using FatihBank.Models;
using MediatR;

namespace FatihBank.Features.ChatListFeatures.Queries
{
    public class ListAllChatListQuery : IRequest<PaginationResponse<MSS_CHT_ChatList>>
    {
        public int page { get; set; }
        public int pageSize { get; set; }

        public ListAllChatListQuery(int page, int pageSize)
        {
            this.page = page;
            this.pageSize = pageSize;
        }
    }
}