using MediatR;

namespace FatihBank.Features.AccountsFeatures.Commands
{
    public class DeleteAccountsCommand : IRequest
    {
        public int Id { get; set; }
    }
}
