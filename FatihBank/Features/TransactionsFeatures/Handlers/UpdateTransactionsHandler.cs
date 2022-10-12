using AutoMapper;
using FatihBank.DTOs;
using FatihBank.Features.TransactionsFeatures.Commands;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.TransactionsFeatures.Handlers
{
    public class UpdateTransactionsHandler : IRequestHandler<UpdateTransactionsCommand, Unit>
    {
        private readonly ITransactionsRepository transactionsRepository;
        private readonly IMapper mapper;

        public UpdateTransactionsHandler(ITransactionsRepository transactionsRepository, IMapper mapper)
        {
            this.transactionsRepository = transactionsRepository;
            this.mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateTransactionsCommand request, CancellationToken cancellationToken)
        {
            var transactionsDto = mapper.Map<TransactionsDto>(request);
            await transactionsRepository.Update(request.Id, transactionsDto);
            return Unit.Value;
        }
    }
}