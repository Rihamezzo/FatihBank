using AutoMapper;
using FatihBank.DTOs;
using FatihBank.Features.NotificationsFeatures.Commands;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.NotificationsFeatures.Handlers
{
    public class UpdateNotificationsHandler : IRequestHandler<UpdateNotificationsCommand, Unit>
    {
        private readonly INotificationsRepository notificationsRepository;
        private readonly IMapper mapper;

        public UpdateNotificationsHandler(INotificationsRepository notificationsRepository, IMapper mapper)
        {
            this.notificationsRepository = notificationsRepository;
            this.mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateNotificationsCommand request, CancellationToken cancellationToken)
        {
            var notificationsDto = mapper.Map<NotificationsDto>(request);
            await notificationsRepository.Update(request.Id, notificationsDto);
            return Unit.Value;
        }
    }
}