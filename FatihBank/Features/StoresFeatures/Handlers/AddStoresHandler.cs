
using AutoMapper;
using FatihBank.DTOs;
using FatihBank.Features.StoresFeatures.Commands;
using FatihBank.Models;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.StoresFeatures.Handlers
{
    public class AddStoresHandler : IRequestHandler<AddStoresCommand, MSS_DEF_Stores>
    {
        private readonly IStoresRepository storesRepository;
        private readonly IMapper mapper;

        public AddStoresHandler(IStoresRepository storesRepository, IMapper mapper)
        {
            this.storesRepository = storesRepository;
            this.mapper = mapper;
        }

        public async Task<MSS_DEF_Stores> Handle(AddStoresCommand request, CancellationToken cancellationToken)
        {
            var storesDto = mapper.Map<StoresDto>(request);
            return await storesRepository.Add(storesDto);
        }
    }
}