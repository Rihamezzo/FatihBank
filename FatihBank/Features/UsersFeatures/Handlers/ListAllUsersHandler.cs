using FatihBank.DTOs;
using MediatR;
using FatihBank.Models;
using FatihBank.Features.MSS_DEF_UsersFeatures.Queries;
using FatihBank.Repositories;

namespace FatihBank.Features.MSS_DEF_UsersFeatures.Handlers
{
    public class ListAllUsersHandler : IRequestHandler<ListAllUsersQuery, PaginationResponse<MSS_DEF_Users>?>
    {
        private readonly IUsersRepository usersRepository;

        public ListAllUsersHandler(IUsersRepository usersRepository)
        {
            this.usersRepository = usersRepository;
        }
        public async Task<PaginationResponse<MSS_DEF_Users>?> Handle(ListAllUsersQuery request, CancellationToken cancellationToken)
        {
            return await usersRepository.ListAll(request.page,request.pageSize);
        }
    }
}
