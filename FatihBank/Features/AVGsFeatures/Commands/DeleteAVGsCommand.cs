using MediatR;

namespace FatihBank.Features.MSS_DEF_AVGsFeatures.Commands
{
    public class DeleteAVGsCommand : IRequest
    {
        public int Id { get; set; }
    }
}
