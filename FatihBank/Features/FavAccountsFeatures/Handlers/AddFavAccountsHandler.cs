
using AutoMapper;
using FatihBank.DTOs;
using FatihBank.Features.FavAccountsFeatures.Commands;
using FatihBank.Models;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.FavAccountsFeatures.Handlers
{
    public class AddFavAccountsHandler : IRequestHandler<AddFavAccountsCommand, MSS_FAV_FavAccounts>
    {
        private readonly IFavAccountsRepository favAccountsRepository;
        private readonly IMapper mapper;

        public AddFavAccountsHandler(IFavAccountsRepository favAccountsRepository, IMapper mapper)
        {
            this.favAccountsRepository = favAccountsRepository;
            this.mapper = mapper;
        }

        public async Task<MSS_FAV_FavAccounts> Handle(AddFavAccountsCommand request, CancellationToken cancellationToken)
        {
            var favAccountsDto = mapper.Map<FavAccountsDto>(request);
            return await favAccountsRepository.Add(favAccountsDto);
        }
    }
}
