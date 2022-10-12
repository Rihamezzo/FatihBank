using MediatR;

namespace FatihBank.Features.MonthlyListFeatures.Commands
{
    public class DeleteToMonthlyListCommand : IRequest
    {
        public int Id { get; set; }
    }
}