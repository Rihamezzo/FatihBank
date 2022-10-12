using FatihBank.DTOs;
using FatihBank.Models;

namespace FatihBank.Repositories
{
    public interface IGroupsRepository
    {
        Task<MSS_DEF_Groups> Add(GroupsDto groupsDto);
        Task Delete(int id);
        Task<PaginationResponse<MSS_DEF_Groups>> ListAll(int page, float pageSize);
        Task Update(int id, GroupsDto groupsDto);
    }
}