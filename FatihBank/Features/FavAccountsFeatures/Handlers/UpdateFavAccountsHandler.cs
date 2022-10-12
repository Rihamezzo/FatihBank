using AutoMapper;
using FatihBank.DTOs;
using FatihBank.Features.FavAccountsFeatures.Commands;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.FavAccountsFeatures.Handlers
{
    public class UpdateFavAccountsHandler : IRequestHandler<UpdateFavAccountsCommand, Unit>
    {
        private readonly IFavAccountsRepository favAccountsRepository;
        private readonly IMapper mapper;

        public UpdateFavAccountsHandler(IFavAccountsRepository favAccountsRepository, IMapper mapper)
        {
            this.favAccountsRepository = favAccountsRepository;
            this.mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateFavAccountsCommand request, CancellationToken cancellationToken)
        {
            var favAccountsDto = mapper.Map<FavAccountsDto>(request);
            await favAccountsRepository.Update(request.Id, favAccountsDto);
            return Unit.Value;
        }
    }
}