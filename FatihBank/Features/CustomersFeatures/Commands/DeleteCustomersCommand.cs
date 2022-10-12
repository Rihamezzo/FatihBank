using MediatR;

namespace FatihBank.Features.MSS_DEF_CustomersFeatures.Commands
{
    public class DeleteCustomersCommand : IRequest
    {
        public int Id { get; set; }
    }
}
