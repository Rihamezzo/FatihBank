using AutoMapper;
using FatihBank.DTOs;
using FatihBank.Features.ExcusesFeatures.Commands;
using FatihBank.Models;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.ExcusesFeatures.Handlers
{
    public class AddExcusesHandler : IRequestHandler<AddExcusesCommand, MSS_ATT_Excuses>
    {
        private readonly IExcusesRepository excusesRepository;
        private readonly IMapper mapper;

        public AddExcusesHandler(IExcusesRepository excusesRepository, IMapper mapper)
        {
            this.excusesRepository = excusesRepository;
            this.mapper = mapper;
        }

        public async Task<MSS_ATT_Excuses> Handle(AddExcusesCommand request, CancellationToken cancellationToken)
        {
            var excusesDto = mapper.Map<ExcusesDto>(request);
            return await excusesRepository.Add(excusesDto);
        }
    }
}