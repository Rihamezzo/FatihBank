using AutoMapper;
using FatihBank.DTOs;
using FatihBank.Features.MonthlyListFeatures.Commands;
using FatihBank.Models;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.MonthlyListFeatures.Handlers
{
    public class AddToMonthlyListHandler : IRequestHandler<AddToMonthlyListCommand, MSS_CUS_Add_To_Monthly_List>
    {
        private readonly IAddToMonthlyListRepository addToMonthlyListRepository;
        private readonly IMapper mapper;

        public AddToMonthlyListHandler(IAddToMonthlyListRepository addToMonthlyListRepository, IMapper mapper)
        {
            this.addToMonthlyListRepository = addToMonthlyListRepository;
            this.mapper = mapper;
        }

        public async Task<MSS_CUS_Add_To_Monthly_List> Handle(AddToMonthlyListCommand request, CancellationToken cancellationToken)
        {
            var addToMonthlyListDto = mapper.Map<AddToMonthlyListDto>(request);
            return await addToMonthlyListRepository.Add(addToMonthlyListDto);
        }
    }
}