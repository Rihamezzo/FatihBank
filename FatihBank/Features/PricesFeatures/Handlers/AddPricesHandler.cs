using AutoMapper;
using FatihBank.DTOs;
using FatihBank.Features.PricesFeatures.Commands;
using FatihBank.Models;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.PricesFeatures.Handlers
{
    public class AddPricesHandler : IRequestHandler<AddPricesCommand, MSS_DEF_Prices>
    {
        private readonly IPricesRepository pricesRepository;
        private readonly IMapper mapper;

        public AddPricesHandler(IPricesRepository pricesRepository, IMapper mapper)
        {
            this.pricesRepository = pricesRepository;
            this.mapper = mapper;
        }

        public async Task<MSS_DEF_Prices> Handle(AddPricesCommand request, CancellationToken cancellationToken)
        {
            var pricesDto = mapper.Map<PricesDto>(request);
            return await pricesRepository.Add(pricesDto);
        }
    }
}