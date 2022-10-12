using MediatR;

namespace FatihBank.Features.MonthSalariesFeatures.Commands
{
    public class DeleteMonthSalariesCommand : IRequest
    {
        public int Id { get; set; }
    }
}