using AutoMapper;
using FatihBank.DTOs;
using FatihBank.Features.P_PricesFeatures.Commands;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.P_PricesFeatures.Handlers
{
    public class UpdateP_PricesHandler : IRequestHandler<UpdateP_PricesCommand, Unit>
    {
        private readonly IP_PricesRepository p_PricesRepository;
        private readonly IMapper mapper;

        public UpdateP_PricesHandler(IP_PricesRepository p_PricesRepository, IMapper mapper)
        {
            this.p_PricesRepository = p_PricesRepository;
            this.mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateP_PricesCommand request, CancellationToken cancellationToken)
        {
            var p_PricesDto = mapper.Map<P_PricesDto>(request);
            await p_PricesRepository.Update(request.Id, p_PricesDto);
            return Unit.Value;
        }
    }
}