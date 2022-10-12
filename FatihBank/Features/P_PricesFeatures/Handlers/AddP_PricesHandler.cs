using AutoMapper;
using FatihBank.DTOs;
using FatihBank.Features.P_PricesFeatures.Commands;
using FatihBank.Models;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.P_PricesFeatures.Handlers
{
    public class AddP_PricesHandler : IRequestHandler<AddP_PricesCommand, MSS_DEF_P_Prices>
    {
        private readonly IP_PricesRepository p_PricesRepository;
        private readonly IMapper mapper;

        public AddP_PricesHandler(IP_PricesRepository p_PricesRepository, IMapper mapper)
        {
            this.p_PricesRepository = p_PricesRepository;
            this.mapper = mapper;
        }

        public async Task<MSS_DEF_P_Prices> Handle(AddP_PricesCommand request, CancellationToken cancellationToken)
        {
            var p_PricesDto = mapper.Map<P_PricesDto>(request);
            return await p_PricesRepository.Add(p_PricesDto);
        }
    }
}
