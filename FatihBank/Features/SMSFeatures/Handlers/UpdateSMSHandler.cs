using AutoMapper;
using FatihBank.DTOs;
using FatihBank.Features.SMSFeatures.Commands;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.SMSFeatures.Handlers
{
    public class UpdateSMSHandler : IRequestHandler<UpdateSMSCommand, Unit>
    {
        private readonly ISMSRepository SMSRepository;
        private readonly IMapper mapper;

        public UpdateSMSHandler(ISMSRepository SMSRepository, IMapper mapper)
        {
            this.SMSRepository = SMSRepository;
            this.mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateSMSCommand request, CancellationToken cancellationToken)
        {
            var SMSDto = mapper.Map<SMSDto>(request);
            await SMSRepository.Update(request.Id, SMSDto);
            return Unit.Value;
        }
    }
}
