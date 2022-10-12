using MediatR;

namespace FatihBank.Features.MonthInfoFeatures.Commands
{
    public class DeleteMonthInfoCommand : IRequest
    {
        public int Id { get; set; }
    }
}