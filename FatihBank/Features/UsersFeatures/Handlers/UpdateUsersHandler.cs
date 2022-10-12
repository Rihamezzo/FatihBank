using MediatR;
using FatihBank.Features.MSS_DEF_UsersFeatures.Commands;
using FatihBank.Repositories;
using FatihBank.DTOs;
using AutoMapper;

namespace FatihBank.Features.MSS_DEF_UsersFeatures.Handlers
{
    public class UpdateUsersHandler : IRequestHandler<UpdateUsersCommand, Unit>
    {
        private readonly IMapper _mapper;
        private readonly IUsersRepository usersRepository;

        public UpdateUsersHandler(IMapper mapper, IUsersRepository usersRepository)
        {
            _mapper = mapper;
            this.usersRepository = usersRepository;
        }

        public async Task<Unit> Handle(UpdateUsersCommand request, CancellationToken cancellationToken)
        {
            var userDto = _mapper.Map<UsersDto>(request);
            await usersRepository.Update(request.Id,userDto);
            return Unit.Value;
        }
    }
}
