using FatihBank.Models;
using MediatR;

namespace FatihBank.Features.FavAccountsFeatures.Commands
{
    public class AddFavAccountsCommand : IRequest<MSS_FAV_FavAccounts>
    {
        public int Id { get; set; }
        public int account_id { get; set; }
        public int? accountId { get; set; }
    }
}