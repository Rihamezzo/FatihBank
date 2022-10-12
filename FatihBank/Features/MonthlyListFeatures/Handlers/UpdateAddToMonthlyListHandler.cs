using AutoMapper;
using FatihBank.DTOs;
using FatihBank.Features.MonthlyListFeatures.Commands;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.MonthlyListFeatures.Handlers
{
    public class UpdateToMonthlyListHandler : IRequestHandler<UpdateToMonthlyListCommand, Unit>
    {
        private readonly IAddToMonthlyListRepository addToMonthlyListRepository;
        private readonly IMapper mapper;

        public UpdateToMonthlyListHandler(IAddToMonthlyListRepository addToMonthlyListRepository, IMapper mapper)
        {
            this.addToMonthlyListRepository = addToMonthlyListRepository;
            this.mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateToMonthlyListCommand request, CancellationToken cancellationToken)
        {
            var addToMonthlyListDto = mapper.Map<AddToMonthlyListDto>(request);
            await addToMonthlyListRepository.Update(request.Id, addToMonthlyListDto);
            return Unit.Value;
        }
    }
}
