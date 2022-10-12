
using MediatR;

namespace FatihBank.Features.FavAccountsFeatures.Commands
{
    public class DeleteFavAccountsCommand : IRequest
    {
        public int Id { get; set; }
    }
}