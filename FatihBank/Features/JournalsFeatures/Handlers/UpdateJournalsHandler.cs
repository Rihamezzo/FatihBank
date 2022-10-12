using AutoMapper;
using FatihBank.DTOs;
using FatihBank.Features.JournalsFeatures.Commands;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.JournalsFeatures.Handlers
{
    public class UpdateJournalsHandler : IRequestHandler<UpdateJournalsCommand, Unit>
    {
        private readonly IJournalsRepository journalsRepository;
        private readonly IMapper mapper;

        public UpdateJournalsHandler(IJournalsRepository journalsRepository, IMapper mapper)
        {
            this.journalsRepository = journalsRepository;
            this.mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateJournalsCommand request, CancellationToken cancellationToken)
        {
            var journalsDto = mapper.Map<JournalsDto>(request);
            await journalsRepository.Update(request.Id, journalsDto);
            return Unit.Value;
        }
    }

    public class UpdateJournalsDetailsHandler : IRequestHandler<UpdateJournalsDetailsCommand, Unit>
    {
        private readonly IJournalsDetailsRepository journalsDetailsRepository;
        private readonly IMapper mapper;

        public UpdateJournalsDetailsHandler(IJournalsDetailsRepository journalsDetailsRepository, IMapper mapper)
        {
            this.journalsDetailsRepository = journalsDetailsRepository;
            this.mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateJournalsDetailsCommand request, CancellationToken cancellationToken)
        {
            var journalsDetailsDto = mapper.Map<JournalsDetailsDto>(request);
            await journalsDetailsRepository.Update(request.Id, journalsDetailsDto);
            return Unit.Value;
        }
    }
}
