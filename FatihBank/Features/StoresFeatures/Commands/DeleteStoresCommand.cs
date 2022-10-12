using MediatR;

namespace FatihBank.Features.StoresFeatures.Commands
{
    public class DeleteStoresCommand : IRequest
    {
        public int Id { get; set; }
    }
}