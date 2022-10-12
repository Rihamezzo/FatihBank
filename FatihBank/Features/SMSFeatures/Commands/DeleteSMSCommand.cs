using MediatR;

namespace FatihBank.Features.SMSFeatures.Commands
{
    public class DeleteSMSCommand : IRequest
    {
        public int Id { get; set; }
    }
}