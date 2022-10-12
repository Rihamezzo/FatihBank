using AutoMapper;
using FatihBank.DTOs;
using FatihBank.Features.DiscountsFeatures.Commands;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.DiscountsFeatures.Handlers
{
    public class UpdateDiscountsHandler : IRequestHandler<UpdateDiscountsCommand, Unit>
    {
        private readonly IDiscountsRepository discountsRepository;
        private readonly IMapper mapper;

        public UpdateDiscountsHandler(IDiscountsRepository discountsRepository, IMapper mapper)
        {
            this.discountsRepository = discountsRepository;
            this.mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateDiscountsCommand request, CancellationToken cancellationToken)
        {
            var discountsDto = mapper.Map<DiscountsDto>(request);
            await discountsRepository.Update(request.Id, discountsDto);
            return Unit.Value;
        }
    }
}