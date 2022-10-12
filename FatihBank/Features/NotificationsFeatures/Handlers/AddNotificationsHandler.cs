
using AutoMapper;
using FatihBank.DTOs;
using FatihBank.Features.NotificationsFeatures.Commands;
using FatihBank.Models;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.NotificationsFeatures.Handlers
{
    public class AddNotificationsHandler : IRequestHandler<AddNotificationsCommand, MSS_INF_Notifications>
    {
        private readonly INotificationsRepository notificationsRepository;
        private readonly IMapper mapper;

        public AddNotificationsHandler(INotificationsRepository notificationsRepository, IMapper mapper)
        {
            this.notificationsRepository = notificationsRepository;
            this.mapper = mapper;
        }

        public async Task<MSS_INF_Notifications> Handle(AddNotificationsCommand request, CancellationToken cancellationToken)
        {
            var notificationsDto = mapper.Map<NotificationsDto>(request);
            return await notificationsRepository.Add(notificationsDto);
        }
    }
}