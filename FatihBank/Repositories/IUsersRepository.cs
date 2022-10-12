using FatihBank.DTOs;
using FatihBank.Models;

namespace FatihBank.Repositories
{
    public interface IUsersRepository
    {
        Task<MSS_DEF_Users> Add(UsersDto usersDto);
        Task Delete(int userId);
        Task<PaginationResponse<MSS_DEF_Users>> ListAll(int page, float pageSize);
        Task Update(int id,UsersDto usersDto);
    }
}