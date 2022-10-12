using AutoMapper;
using FatihBank.DTOs;
using FatihBank.Features.ChecksFeatures.Commands;
using FatihBank.Models;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.ChecksFeatures.Handlers
{
    public class AddChecksHandler : IRequestHandler<AddChecksCommand, MSS_ACC_Checks>
    {
        private readonly IMapper mapper;
        private readonly IChecksRepository checksRepository;

        public AddChecksHandler(IMapper mapper, IChecksRepository checksRepository)
        {
            this.mapper = mapper;
            this.checksRepository = checksRepository;
        }

        public async Task<MSS_ACC_Checks> Handle(AddChecksCommand request, CancellationToken cancellationToken)
        {
            var checksDto = mapper.Map<ChecksDto>(request);
            return await checksRepository.Add(checksDto);
        }
    }
}
