using FatihBank.Features.MonthSalariesFeatures.Commands;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.MonthSalariesFeatures.Handlers
{
    public class DeleteMonthSalariesHandler : IRequestHandler<DeleteMonthSalariesCommand, Unit>
    {
        private readonly IMonthSalariesRepository monthSalariesRepository;

        public DeleteMonthSalariesHandler(IMonthSalariesRepository monthSalariesRepository)
        {
            this.monthSalariesRepository = monthSalariesRepository;
        }

        public async Task<Unit> Handle(DeleteMonthSalariesCommand request, CancellationToken cancellationToken)
        {
            await monthSalariesRepository.Delete(request.Id);
            return Unit.Value;
        }
    }
}
