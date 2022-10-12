using MediatR;

namespace FatihBank.Features.MCDFeatures.Commands
{
    public class DeleteMCDCommand : IRequest
    {
        public int Id { get; set; }
    }
}