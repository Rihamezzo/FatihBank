
using AutoMapper;
using FatihBank.DTOs;
using FatihBank.Features.SMSFeatures.Commands;
using FatihBank.Models;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.SMSFeatures.Handlers
{
    public class AddSMSHandler : IRequestHandler<AddSMSCommand, MSS_DEF_SMS>
    {
        private readonly ISMSRepository SMSRepository;
        private readonly IMapper mapper;

        public AddSMSHandler(ISMSRepository SMSRepository, IMapper mapper)
        {
            this.SMSRepository = SMSRepository;
            this.mapper = mapper;
        }

        public async Task<MSS_DEF_SMS> Handle(AddSMSCommand request, CancellationToken cancellationToken)
        {
            var SMSDto = mapper.Map<SMSDto>(request);
            return await SMSRepository.Add(SMSDto);
        }
    }
}