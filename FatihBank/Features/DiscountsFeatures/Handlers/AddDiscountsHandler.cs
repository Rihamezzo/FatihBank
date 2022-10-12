using AutoMapper;
using FatihBank.DTOs;
using FatihBank.Features.DiscountsFeatures.Commands;
using FatihBank.Models;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.DiscountsFeatures.Handlers
{
    public class AddDiscountsHandler : IRequestHandler<AddDiscountsCommand, MSS_ATT_Discounts>
    {
        private readonly IDiscountsRepository discountsRepository;
        private readonly IMapper mapper;

        public AddDiscountsHandler(IDiscountsRepository discountsRepository, IMapper mapper)
        {
            this.discountsRepository = discountsRepository;
            this.mapper = mapper;
        }

        public async Task<MSS_ATT_Discounts> Handle(AddDiscountsCommand request, CancellationToken cancellationToken)
        {
            var discountsDto = mapper.Map<DiscountsDto>(request);
            return await discountsRepository.Add(discountsDto);
        }
    }
}