using FatihBank.DTOs;
using FatihBank.Models;

namespace FatihBank.Repositories
{
    public interface IRewardsRepository
    {
        Task<MSS_ATT_Rewards> Add(RewardsDto rewardsDto);
        Task Delete(int id);
        Task<PaginationResponse<MSS_ATT_Rewards>> ListAll(int page, float pageSize);
        Task Update(int id, RewardsDto rewardsDto);
    }
}