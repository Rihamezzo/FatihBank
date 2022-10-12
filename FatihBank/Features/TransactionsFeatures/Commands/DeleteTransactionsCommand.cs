using MediatR;

namespace FatihBank.Features.TransactionsFeatures.Commands
{
    public class DeleteTransactionsCommand : IRequest
    {
        public int Id { get; set; }
    }
}