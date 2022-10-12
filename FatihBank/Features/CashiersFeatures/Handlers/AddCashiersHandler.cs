using AutoMapper;
using FatihBank.DTOs;
using FatihBank.Features.MSS_DEF_CashiersFeatures.Commands;
using FatihBank.Models;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.MSS_DEF_CashiersFeatures.Handlers
{
    public class AddCashiersHandler : IRequestHandler<AddCashiersCommand, MSS_DEF_Cashiers>
    {
        private readonly IMapper mapper;
        private readonly ICashiersRepository cashiersRepository;

        public AddCashiersHandler(IMapper mapper, ICashiersRepository cashiersRepository)
        {
            this.mapper = mapper;
            this.cashiersRepository = cashiersRepository;
        }

        public async Task<MSS_DEF_Cashiers> Handle(AddCashiersCommand request, CancellationToken cancellationToken)
        {
            var cashiersDto = mapper.Map<CashiersDto>(request);
            return await cashiersRepository.Add(cashiersDto);
        }
    }
}
