using MediatR;

namespace FatihBank.Features.RegisterationFileFeatures.Commands
{
    public class DeleteRegisterationFileCommand : IRequest
    {
        public int Id { get; set; }
    }
}