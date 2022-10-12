using AutoMapper;
using FatihBank.DTOs;
using FatihBank.Features.MSS_DEF_CashiersFeatures.Commands;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.MSS_DEF_CashiersFeatures.Handlers
{
    public class UpdateCashiersHandler : IRequestHandler<UpdateCashiersCommand, Unit>
    {
        private readonly IMapper mapper;
        private readonly ICashiersRepository cashiersRepository;

        public UpdateCashiersHandler(IMapper mapper, ICashiersRepository cashiersRepository)
        {
            this.mapper = mapper;
            this.cashiersRepository = cashiersRepository;
        }

        public async Task<Unit> Handle(UpdateCashiersCommand request, CancellationToken cancellationToken)
        {
            var cashiersDto = mapper.Map<CashiersDto>(request);
            await cashiersRepository.Update(request.Id, cashiersDto);
            return Unit.Value;
        }
    }
}
