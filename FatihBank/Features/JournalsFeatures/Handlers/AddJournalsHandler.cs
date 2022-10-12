using AutoMapper;
using FatihBank.DTOs;
using FatihBank.Features.JournalsFeatures.Commands;
using FatihBank.Models;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.JournalsFeatures.Handlers
{
    public class AddJournalsHandler : IRequestHandler<AddJournalsCommand, MSS_DEF_Journals>
    {
        private readonly IJournalsRepository journalsRepository;
        private readonly IMapper mapper;

        public AddJournalsHandler(IJournalsRepository journalsRepository, IMapper mapper)
        {
            this.journalsRepository = journalsRepository;
            this.mapper = mapper;
        }

        public async Task<MSS_DEF_Journals> Handle(AddJournalsCommand request, CancellationToken cancellationToken)
        {
            var journalsDto = mapper.Map<JournalsDto>(request);
            return await journalsRepository.Add(journalsDto);
        }
    }

    public class AddJournalsDetailsHandler : IRequestHandler<AddJournalsDetailsCommand, MSS_JOU_Details>
    {
        private readonly IJournalsDetailsRepository journalsDetailsRepository;
        private readonly IMapper mapper;

        public AddJournalsDetailsHandler(IJournalsDetailsRepository journalsDetailsRepository, IMapper mapper)
        {
            this.journalsDetailsRepository = journalsDetailsRepository;
            this.mapper = mapper;
        }

        public async Task<MSS_JOU_Details> Handle(AddJournalsDetailsCommand request, CancellationToken cancellationToken)
        {
            var journalsDetailsDto = mapper.Map<JournalsDetailsDto>(request);
            return await journalsDetailsRepository.Add(journalsDetailsDto);
        }
    }
}
