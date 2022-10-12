using AutoMapper;
using FatihBank.DTOs;
using FatihBank.Features.AccountsFeatures.Commands;
using FatihBank.Models;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.MSS_DEF_AccountsFeatures.Handlers
{
    public class AddAccountsHandler : IRequestHandler<AddAccountsCommand, MSS_DEF_Accounts>
    {
        private readonly IAccountsRepository accountsRepository;
        private readonly IMapper mapper;

        public AddAccountsHandler(IAccountsRepository accountsRepository, IMapper mapper)
        {
            this.accountsRepository = accountsRepository;
            this.mapper = mapper;
        }

        public async Task<MSS_DEF_Accounts> Handle(AddAccountsCommand request, CancellationToken cancellationToken)
        {
           var accountsDto = mapper.Map<AccountsDto>(request);
            return await accountsRepository.Add(accountsDto);
        }
    }
}
