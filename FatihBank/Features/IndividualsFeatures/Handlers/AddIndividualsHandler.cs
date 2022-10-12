using AutoMapper;
using FatihBank.DTOs;
using FatihBank.Features.IndividualsFeatures.Commands;
using FatihBank.Models;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.IndividualsFeatures.Handlers
{
    public class AddIndividualsHandler : IRequestHandler<AddIndividualsCommand, MSS_TRS_Individuals>
    {
        private readonly IIndividualsRepository individualsRepository;
        private readonly IMapper mapper;

        public AddIndividualsHandler(IIndividualsRepository individualsRepository, IMapper mapper)
        {
            this.individualsRepository = individualsRepository;
            this.mapper = mapper;
        }

        public async Task<MSS_TRS_Individuals> Handle(AddIndividualsCommand request, CancellationToken cancellationToken)
        {
            var individualsDto = mapper.Map<IndividualsDto>(request);
            return await individualsRepository.Add(individualsDto);
        }
    }
}