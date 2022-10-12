using AutoMapper;
using FatihBank.DTOs;
using FatihBank.Features.ChatListFeatures.Commands;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.ChatListFeatures.Handlers
{
    public class UpdateChatListHandler : IRequestHandler<UpdateChatListCommand, Unit>
    {
        private readonly IChatListRepository chatListRepository;
        private readonly IMapper mapper;

        public UpdateChatListHandler(IChatListRepository chatListRepository, IMapper mapper)
        {
            this.chatListRepository = chatListRepository;
            this.mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateChatListCommand request, CancellationToken cancellationToken)
        {
            var chatListDto = mapper.Map<ChatListDto>(request);
            await chatListRepository.Update(request.Id, chatListDto);
            return Unit.Value;
        }
    }
}
