using AutoMapper;
using FatihBank.DTOs;
using FatihBank.Features.PricesFeatures.Commands;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.PricesFeatures.Handlers
{
    public class UpdatePricesHandler : IRequestHandler<UpdatePricesCommand, Unit>
    {
        private readonly IPricesRepository pricesRepository;
        private readonly IMapper mapper;

        public UpdatePricesHandler(IPricesRepository pricesRepository, IMapper mapper)
        {
            this.pricesRepository = pricesRepository;
            this.mapper = mapper;
        }

        public async Task<Unit> Handle(UpdatePricesCommand request, CancellationToken cancellationToken)
        {
            var pricesDto = mapper.Map<PricesDto>(request);
            await pricesRepository.Update(request.Id, pricesDto);
            return Unit.Value;
        }
    }
}