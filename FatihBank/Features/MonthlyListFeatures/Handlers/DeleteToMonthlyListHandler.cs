using FatihBank.Features.MonthlyListFeatures.Commands;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.MonthlyListFeatures.Handlers
{
    public class DeleteToMonthlyListHandler : IRequestHandler<DeleteToMonthlyListCommand, Unit>
    {
        private readonly IAddToMonthlyListRepository addToMonthlyListRepository;

        public DeleteToMonthlyListHandler(IAddToMonthlyListRepository addToMonthlyListRepository)
        {
            this.addToMonthlyListRepository = addToMonthlyListRepository;
        }

        public async Task<Unit> Handle(DeleteToMonthlyListCommand request, CancellationToken cancellationToken)
        {
            await addToMonthlyListRepository.Delete(request.Id);
            return Unit.Value;
        }
    }
}
