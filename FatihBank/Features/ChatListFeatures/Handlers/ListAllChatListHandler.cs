using FatihBank.DTOs;
using FatihBank.Features.ChatListFeatures.Queries;
using FatihBank.Models;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.ChatListFeatures.Handlers
{
    public class ListAllChatListHandler : IRequestHandler<ListAllChatListQuery, PaginationResponse<MSS_CHT_ChatList>>
    {
        private readonly IChatListRepository chatListRepository;

        public ListAllChatListHandler(IChatListRepository chatListRepository)
        {
            this.chatListRepository = chatListRepository;
        }

        public async Task<PaginationResponse<MSS_CHT_ChatList>> Handle(ListAllChatListQuery request, CancellationToken cancellationToken)
        {
            return await chatListRepository.ListAll(request.page, request.pageSize);
        }
    }
}
