using MediatR;

namespace FatihBank.Features.FavAccountsFeatures.Commands
{
    public class UpdateFavAccountsCommand : IRequest
    {
        public int Id { get; set; }
        public int account_id { get; set; }
        public int? accountId { get; set; }
    }
}