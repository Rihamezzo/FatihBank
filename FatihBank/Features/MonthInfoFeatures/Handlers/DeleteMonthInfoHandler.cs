using FatihBank.Features.MonthInfoFeatures.Commands;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.MonthInfoFeatures.Handlers
{
    public class DeleteMonthInfoHandler : IRequestHandler<DeleteMonthInfoCommand, Unit>
    {
        private readonly IMonthInfoRepository monthInfoRepository;

        public DeleteMonthInfoHandler(IMonthInfoRepository monthInfoRepository)
        {
            this.monthInfoRepository = monthInfoRepository;
        }

        public async Task<Unit> Handle(DeleteMonthInfoCommand request, CancellationToken cancellationToken)
        {
            await monthInfoRepository.Delete(request.Id);
            return Unit.Value;
        }
    }
}