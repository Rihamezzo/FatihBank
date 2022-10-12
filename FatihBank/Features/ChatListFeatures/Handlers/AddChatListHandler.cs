
using AutoMapper;
using FatihBank.DTOs;
using FatihBank.Features.ChatListFeatures.Commands;
using FatihBank.Models;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.ChatListFeatures.Handlers
{
    public class AddChatListHandler : IRequestHandler<AddChatListCommand, MSS_CHT_ChatList>
    {
        private readonly IChatListRepository chatListRepository;
        private readonly IMapper mapper;

        public AddChatListHandler(IChatListRepository chatListRepository, IMapper mapper)
        {
            this.chatListRepository = chatListRepository;
            this.mapper = mapper;
        }

        public async Task<MSS_CHT_ChatList> Handle(AddChatListCommand request, CancellationToken cancellationToken)
        {
            var chatListDto = mapper.Map<ChatListDto>(request);
            return await chatListRepository.Add(chatListDto);
        }
    }
}
