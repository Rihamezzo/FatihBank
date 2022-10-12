using AutoMapper;
using FatihBank.DTOs;
using FatihBank.Features.AccountsFeatures.Commands;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.MSS_DEF_AccountsFeatures.Handlers
{
    public class UpdateAccountsHandler : IRequestHandler<UpdateAccountsCommand,Unit>
    {
        private readonly IAccountsRepository accountsRepository;
        private readonly IMapper mapper;

        public UpdateAccountsHandler(IAccountsRepository accountsRepository, IMapper mapper)
        {
            this.accountsRepository = accountsRepository;
            this.mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateAccountsCommand request, CancellationToken cancellationToken)
        {

            var accountsDto = mapper.Map<AccountsDto>(request);
            await accountsRepository.Update(request.Id, accountsDto);   
            return Unit.Value;
        }
    }
}
