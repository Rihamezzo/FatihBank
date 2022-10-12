using MediatR;

namespace FatihBank.Features.VouchersFeatures.Commands
{
    public class DeleteVouchersCommand : IRequest
    {
        public int Id { get; set; }
    }
}