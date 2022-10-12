using MediatR;
using FatihBank.Features.MSS_DEF_UsersFeatures.Commands;
using FatihBank.Models;
using FatihBank.Repositories;
using FatihBank.DTOs;
using AutoMapper;

namespace FatihBank.Features.MSS_DEF_UsersFeatures.Handlers
{
    public class AddUsersHandler : IRequestHandler<AddUsersCommand, MSS_DEF_Users?>
    {
        private readonly IUsersRepository usersRepository;
        private readonly IMapper mapper;

        public AddUsersHandler(IUsersRepository usersRepository, IMapper mapper)
        {
            this.usersRepository = usersRepository;
            this.mapper = mapper;
        }

        public async Task<MSS_DEF_Users?> Handle(AddUsersCommand request, CancellationToken cancellationToken)
        {
            var usersDto = mapper.Map<UsersDto>(request);
            return await usersRepository.Add(usersDto);
        }
    }
}
