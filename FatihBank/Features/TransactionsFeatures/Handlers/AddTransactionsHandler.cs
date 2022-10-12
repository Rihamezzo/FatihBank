using AutoMapper;
using FatihBank.DTOs;
using FatihBank.Features.TransactionsFeatures.Commands;
using FatihBank.Models;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.TransactionsFeatures.Handlers
{
    public class AddTransactionsHandler : IRequestHandler<AddTransactionsCommand, MSS_DEF_Transactions>
    {
        private readonly ITransactionsRepository transactionsRepository;
        private readonly IMapper mapper;

        public AddTransactionsHandler(ITransactionsRepository transactionsRepository, IMapper mapper)
        {
            this.transactionsRepository = transactionsRepository;
            this.mapper = mapper;
        }

        public async Task<MSS_DEF_Transactions> Handle(AddTransactionsCommand request, CancellationToken cancellationToken)
        {
            var transactionsDto = mapper.Map<TransactionsDto>(request);
            return await transactionsRepository.Add(transactionsDto);
        }
    }
}