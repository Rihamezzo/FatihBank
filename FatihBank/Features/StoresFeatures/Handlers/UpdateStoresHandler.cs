using AutoMapper;
using FatihBank.DTOs;
using FatihBank.Features.StoresFeatures.Commands;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.StoresFeatures.Handlers
{
    public class UpdateStoresHandler : IRequestHandler<UpdateStoresCommand, Unit>
    {
        private readonly IStoresRepository storesRepository;
        private readonly IMapper mapper;

        public UpdateStoresHandler(IStoresRepository storesRepository, IMapper mapper)
        {
            this.storesRepository = storesRepository;
            this.mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateStoresCommand request, CancellationToken cancellationToken)
        {
            var storesDto = mapper.Map<StoresDto>(request);
            await storesRepository.Update(request.Id, storesDto);
            return Unit.Value;
        }
    }
}