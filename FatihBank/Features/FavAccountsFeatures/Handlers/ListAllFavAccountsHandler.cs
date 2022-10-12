using FatihBank.DTOs;
using FatihBank.Features.FavAccountsFeatures.Queries;
using FatihBank.Models;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.FavAccountsFeatures.Handlers
{
    public class ListAllFavAccountsHandler : IRequestHandler<ListAllFavAccountsQuery, PaginationResponse<MSS_FAV_FavAccounts>>
    {
        private readonly IFavAccountsRepository favAccountsRepository;

        public ListAllFavAccountsHandler(IFavAccountsRepository favAccountsRepository)
        {
            this.favAccountsRepository = favAccountsRepository;
        }

        public async Task<PaginationResponse<MSS_FAV_FavAccounts>> Handle(ListAllFavAccountsQuery request, CancellationToken cancellationToken)
        {
            return await favAccountsRepository.ListAll(request.page, request.pageSize);
        }
    }
}
